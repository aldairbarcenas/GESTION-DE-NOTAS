-- VALIDAR QUE EL PS EXISTA

SELECT *
FROM sys.procedures
WHERE name = 'SP_CrudMaterias';