const express =require('express')
const cors = require('cors')

const { 
    libroRoutes
} = require('./src/routes')

const app = express();

//Directorio publico
app.use(express.static('public'));

//cors
app.use(cors())

//Lectura de body
app.use(express.json())

//RUTAS
app.use('/api/libro', libroRoutes);


module.exports = app;