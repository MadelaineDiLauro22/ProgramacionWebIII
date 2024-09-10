USE AsistenteFacultativo;

-- Habilitar IDENTITY_INSERT para la tabla Materias
SET IDENTITY_INSERT dbo.Materias ON;

INSERT INTO dbo.Materias (ID, Nombre, CargaHoraria, Comisiones)
VALUES 
(2619, 'PROGRAMACION B�SICA I', 8.0, '[{"Id":2353,"diasyhorarios":[{"dia":"martes","horario":"8-12"},{"dia":"viernes","horario":"8-12"}]},{"Id":1939,"diasyhorarios":[{"dia":"lunes","horario":"19-23"},{"dia":"miercoles","horario":"19-23"}]}]'),

(2620, 'INFORMATICA GENERAL', 4.0, '[{"Id":1300,"diasyhorarios":[{"dia":"lunes","horario":"8-12"}]},{"Id":3900,"diasyhorarios":[{"dia":"miercoles","horario":"19-23"}]}]'),

(2621, 'MATEMATICA GENERAL', 8.0, '[{"Id":4363,"diasyhorarios":[{"dia":"jueves","horario":"8-12"},{"dia":"sabado","horario":"8-12"}]},{"Id":1966,"diasyhorarios":[{"dia":"lunes","horario":"19-23"},{"dia":"sabado","horario":"14-18"}]}]'),

(2622, 'INGLES TECNICO I', 4.0, '[{"Id":3300,"diasyhorarios":[{"dia":"miercoles","horario":"8-12"}]},{"Id":5900,"diasyhorarios":[{"dia":"viernes","horario":"19-23"}]}]'),

(2623, 'PROGRAMACION BASICA II', 4.0, '[{"Id":3300,"diasyhorarios":[{"dia":"miercoles","horario":"8-12"}]},{"Id":2900,"diasyhorarios":[{"dia":"martes","horario":"19-23"}]}]'),

(2624, 'PROGRAMACION WEB I', 4.0, '[{"Id":5300,"diasyhorarios":[{"dia":"viernes","horario":"8-12"}]},{"Id":3900,"diasyhorarios":[{"dia":"miercoles","horario":"19-23"}]}]'),

(2625, 'BASE DATOS I', 8.0, '[{"Id":2363,"diasyhorarios":[{"dia":"martes","horario":"8-12"},{"dia":"sabado","horario":"8-12"}]},{"Id":4966,"diasyhorarios":[{"dia":"jueves","horario":"19-23"},{"dia":"sabado","horario":"14-18"}]}]'),

(2626, 'INTRODUCCION AL DISENIO GRAFICO EN LA WEB', 4.0, '[{"Id":4300,"diasyhorarios":[{"dia":"jueves","horario":"8-12"}]},{"Id":5900,"diasyhorarios":[{"dia":"viernes","horario":"19-23"}]}]'),

(2627, 'INGLES TECNICO II', 4.0, '[{"Id":1300,"diasyhorarios":[{"dia":"lunes","horario":"8-12"}]},{"Id":1900,"diasyhorarios":[{"dia":"martes","horario":"19-23"}]}]'),

(2628, 'PROGRAMACION WEB II', 8.0, '[{"Id":1929,"diasyhorarios":[{"dia":"lunes","horario":"19-23"},{"dia":"martes","horario":"19-23"}]}]'),

(2629, 'DISENIO DE APLICACIONES WEB', 4.0, '[{"Id":3966,"diasyhorarios":[{"dia":"miercoles","horario":"19-23"},{"dia":"sabado","horario":"14-18"}]}]'),

(2630, 'VISUALIZACION E INTERFACES', 4.0, '[{"Id":2300,"diasyhorarios":[{"dia":"martes","horario":"8-12"}]},{"Id":5900,"diasyhorarios":[{"dia":"viernes","horario":"19-23"}]}]'),

(2631, 'TALLER WEB I', 4.0, '[{"Id":4300,"diasyhorarios":[{"dia":"jueves","horario":"8-12"}]},{"Id":4900,"diasyhorarios":[{"dia":"jueves","horario":"19-23"}]}]'),

(2632, 'BASE DE DATOS II', 4.0, '[{"Id":4900,"diasyhorarios":[{"dia":"jueves","horario":"19-23"}]}]'),

(2633, 'PROGRAMACION WEB III', 8.0, '[{"Id":2939,"diasyhorarios":[{"dia":"martes","horario":"19-23"},{"dia":"miercoles","horario":"19-23"}]}]'),

(2634, 'TECNOLOGIA DE REDES', 4.0, '[{"Id":6300,"diasyhorarios":[{"dia":"sabado","horario":"8-12"}]},{"Id":5900,"diasyhorarios":[{"dia":"viernes","horario":"19-23"}]}]'),

(2635, 'TALLER WEB II', 4.0, '[{"Id":1300,"diasyhorarios":[{"dia":"sabado","horario":"14-18"}]}]'),

(2636, 'SEGURIDAD Y CALIDAD EN APLICACION WEB', 4.0, '[{"Id":1900,"diasyhorarios":[{"dia":"lunes","horario":"19-23"}]}]'),

(2637, 'INTRODUCCION A LA ADMINISTRACION DE PROYECTOS', 4.0, '[{"Id":2900,"diasyhorarios":[{"dia":"martes","horario":"19-23"}]}]'),

(2638, 'TALLER PRACTICO INTEGRADOR', 8.0, '[{"Id":3966,"diasyhorarios":[{"dia":"miercoles","horario":"19-23"},{"dia":"sabado","horario":"14-18"}]}]');

SET IDENTITY_INSERT dbo.Materias OFF;




