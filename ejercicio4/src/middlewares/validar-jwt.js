const { response } = require('express');
const jwt = require('jsonwebtoken');

const validarJWT = ( req, res = response, next ) => {
    // x-token headers
    const token = req.header('x-token');
    
    if ( !token ) {
        return res.status(401).json({
            ok: false,
            msg: 'No hay token en la petición'
        });
    }

    try {
        
        const { id_usuario } = jwt.verify(
            token,
            process.env.SECRETKEY
        );

        req.id_usuario = id_usuario;
        //req.nombres = nombres;

    } catch (error) {
        return res.status(401).json({
            ok: false,
            msg: 'Token no válido'
        });
    }
    next();
}


module.exports = {
    validarJWT
}
