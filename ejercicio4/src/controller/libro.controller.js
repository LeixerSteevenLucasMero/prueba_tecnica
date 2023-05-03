const { Libro } = require("../models");

const crearLibro = async (req, res) => {
    try {
        console.log(req.body)
        const LibroDB = await Libro.findOne({ nombre: req.body.nombre });

        if (LibroDB) {
            return res.status(400).json({
                msg: `El Libro ${LibroDB.nombre} ya existe`
            });
        }
        const data = {
            ...req.body
        }
        

        const libro = await new Libro(data);
        await libro.save();

        res.status(200).json({
            msg: 'Creado con exito',
            libro
        });
    } catch (error) {
        console.log(error)
        res.status(500).json({
            msg: 'Error del servidor',
        });
    }

};

const traerTodos = async (req, res) => {
    try {
        const libros = await Libro.find()

        res.status(200).json({
            msg: 'obtenidos con exito',
            libros
        });
    } catch (error) {
        res.status(500).json({
            msg: 'Error del servidor'
        });
    }
}

const editar = async (req, res) => {
    try {
        const id = req.params.id
        const libro = await Libro.findByIdAndUpdate(id, {...req,body})
        res.status(200).json({
            msg: 'Actualizado con exito',
            libro
        });
    } catch (error) {
        res.status(500).json({
            msg: 'Error del servidor'
        });
    }
}

const eliminar = async (req, res) => {
    try {
        const id = req.params.id
        await Libro.findByIdAndDelete(id)
        res.status(200).json({
            msg: 'Eliminado con exito',
        });
    } catch (error) {
        res.status(500).json({
            msg: 'Error del servidor'
        });
    }
}


const traerPorId = async (req, res) => {
    try {
        const id = req.params.id
        let libro = await Libro.findById(id)
        res.status(200).json({
            msg: 'ok',
            libro
        });
    } catch (error) {
        res.status(500).json({
            msg: 'Error del servidor'
        });
    }
}

const traerPorFecha = async (req, res) => {
    try {
        const fecha = req.params.fecha;
        const libros = await Libro.find({fecha: fecha});
        res.status(200).json({
            msg: 'ok',
            libros
        });
    } catch (error) {
        res.status(500).json({
            msg: 'Error del servidor'
        });
    }
}

module.exports = {
    crearLibro,
    traerTodos,
    editar,
    eliminar,
    traerPorId,
    traerPorFecha,
}