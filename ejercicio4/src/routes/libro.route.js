const { Router } = require('express');
const { libroController } = require('../controller');

const router = Router();

router.post('/crear', libroController.crearLibro);
router.get('/', libroController.traerTodos);
router.get('/:id', libroController.traerPorId);
router.get('/fecha/:fecha', libroController.traerPorFecha);
router.put('/:id', libroController.editar);
router.delete('/', libroController.eliminar);

module.exports = router; 