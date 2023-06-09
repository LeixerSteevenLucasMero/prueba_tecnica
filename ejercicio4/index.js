require('dotenv').config();
const { dbConnection } = require('./src/config/db');
const app = require('./app');

const main = async () => {
    try {
        await dbConnection();
        app.listen(process.env.PORT, () =>{
            console.log(`Servidor corriendo en el puerto ${process.env.PORT}`)
        })
        
    } catch (error) {
        console.log("Error al conectar con las base de datos")
    }
    
}

console.log("")
main();
