const mongoose = require("mongoose");
const {Schema} = mongoose;


const libroSchema = new Schema({
    nombre:{type:String},
    descrpicion:{type:String},
    autor:{type:String},
    fecha:{type:Date, default: Date.now},
});




module.exports = mongoose.model('Libro',libroSchema);
