const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const userSchema = new Schema({
  name: {
    type: String,
    required: true,
    trim: true
  },
  age: {
    type: String,
    required: true,
    trim: true
  },
  email: {
    type: String,
    required: true,
    trim: true,
    unique: true
  },
  password: {
    type: String,
    required: true,
    trim: true
  },
  startingWeight: {
    type: String,
    required: true,
    trim: true
  },
  actualWeight: {
    type: String,
    required: true,
    trim: true
  },
}, {
  timestamps: true
});

module.exports = userSchema;

