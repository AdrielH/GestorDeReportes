/*segurdad*/
INSERT INTO TBL_MODULO VALUES (1, 'COMPRAS', NULL, 1);
INSERT INTO TBL_MODULO VALUES (2, 'CTA. POR PAGAR', NULL, 1);
INSERT INTO TBL_APLICACION VALUES (1, 1, 'PEDIDO', NULL, 1);
INSERT INTO TBL_APLICACION VALUES (2, 1, 'COMPRA', NULL, 1);
INSERT INTO TBL_APLICACION VALUES (3, 2, 'CREDITO', NULL, 1);
INSERT INTO TBL_APLICACION VALUES (4, 2, 'PROVEEDORES', NULL, 1);
/*reportes*/
INSERT INTO TBL_CONFIGURACION_RPT VALUES (0, 'DMZ', 'usuarioftp', 'ftp', '22', 'compartido\\', 1);
INSERT INTO TBL_CONFIGURACION_RPT VALUES (1, 'Local', 'na', 'na', 'na', 'D:\\\\tmp\\\\', 1);

INSERT INTO TBL_REPORTE VALUES (0, 1, 'Prueba', 1, 'Prueba.rpt');