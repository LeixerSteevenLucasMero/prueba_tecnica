using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;


namespace Ejercicio2
{

    public class RegistroCN
    {
        public int Passengerid { get; set; }
        public int urvived { get; set; }
        public int Pclass { get; set; }
        public string Sex { get; set; }
        public String Age { get; set; }
        public int SibSp { get; set; }
        public int Parch { get; set; }
        public double Fare { get; set; }
        public string Embarked { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Leixer Lucas Mero\source\repos\ejercicio2\ejercicio2\csv\train_and_test2.csv";
            var records = new List<RegistroCN>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var record = new RegistroCN
                    {
                        Passengerid = csv.GetField<int>("Passengerid"),
                        urvived = csv.GetField<int>("2urvived"),
                        Pclass = csv.GetField<int>("Pclass"),
                        Sex = csv.GetField("Sex"),
                        Age = csv.GetField("Age"),
                        SibSp = csv.GetField<int>("sibsp"),
                        Parch = csv.GetField<int>("Parch"),
                        Fare = csv.GetField<double>("Fare"),
                        Embarked = csv.GetField("Embarked")
                    };
                    records.Add(record);
                }
            }

            bool exit = false;
            while (!exit)
            {
                //pas1:Realizar un menú

                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("0. Mostrar lista de datos");
                Console.WriteLine("1. Mostrar cantidad de hombres mayores de 17 años");
                Console.WriteLine("2. Mostrar cantidad de mujeres mayores de 17 años");
                Console.WriteLine("3. Mostrar cantidad de niños menores de 13 años");
                Console.WriteLine("4. Mostrar cantidad de niñas menores de 13 años");
                Console.WriteLine("5. Mostrar cantidad de adolescentes (entre 13 y 17 años)");
                Console.WriteLine("6. Salir");
               
                //paso2:lista de datos
                string option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        foreach (var record in records)
                        {
                            Console.WriteLine($"Passengerid: {record.Passengerid}   - Survived {record.urvived}   - Pclass   {record.Pclass}  - Sex  {record.Sex} - Age  {record.Age} - SibSp  {record.SibSp} - Parch  {record.Parch} - Fare {record.Fare} - Embarked {record.Embarked}");

                        }
                        break;
                //paso3: Mostrar la cantidad de hombres (mayores de 17 años)
                    case "1":
                        int hombresMayores = 0;
                        foreach (var record in records)
                        {
                            if (record.Sex == "0" && !string.IsNullOrEmpty(record.Age) && float.Parse(record.Age) > 17)
                            {
                                hombresMayores++;
                            }
                        }
                        Console.WriteLine($"La cantidad de hombres mayores de 17 años es: {hombresMayores}");
                        break;
                //paso4: Mostrar la cantidad de mujeres (mayores de 17 años)
                    case "2":
                        int mujeresMayores = 0;
                        foreach (var record in records)
                        {
                            if (record.Sex == "1" && !string.IsNullOrEmpty(record.Age) && float.Parse(record.Age) > 17)
                            {
                                mujeresMayores++;
                            }
                        }
                        Console.WriteLine($"La cantidad de mujeres mayores de 17 años es: {mujeresMayores}");
                        break;
                //paso5: Mostrar la cantidad de niños (menores de 13 años).
                    case "3":
                        int ninos = 0;
                        foreach (var record in records)
                        {
                            if (!string.IsNullOrEmpty(record.Age) && float.Parse(record.Age) < 13)
                            {
                                if (record.Sex == "0")
                                {
                                    ninos++;
                                }
                            }
                        }
                        Console.WriteLine($"La cantidad de niños menores de 13 años es: {ninos}");
                        break;



                }



            }
        }
    }
}
