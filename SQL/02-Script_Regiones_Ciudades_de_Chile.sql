/****************************************************************************************
Procedimiento			: Script_Regiones y Ciudades de Chile.sql
Objetivo Descripcion	: Insertar las Regiones y Ciudades al sistema.
Sistema					: ModulOTEC
Base de Datos			: ModulOTEC
Tablas usadas			: Regiones, Ciudades
Autor					: Omar Carmona
Fecha creaci�n			: 28/11/2015
****************************************************************************************/

USE ModulOTEC
GO

INSERT INTO dbo.Regiones (Region)
VALUES	('Arica y Parinacota')
	  , ('Tarapac�')
	  , ('Antofagasta')
	  , ('Atacama')
	  , ('Coquimbo')
	  , ('Valpara�so')
	  , ('O''Higgins')
	  , ('Maule')
	  , ('Biob�o')
	  , ('La Araucan�a')
	  , ('Los Lagos')
	  , ('Ays�n')
	  , ('Magallanes')
	  , ('Metropolitana de Santiago')
	  , ('Los Rios')
GO

INSERT INTO dbo.Ciudades (IdRegion, Ciudad)
VALUES ( 1 ,'Arica')
	 , ( 1 ,'Camarones')
	 , ( 1 ,'Putre')
	 , ( 1 ,'General Lagos')
	 , ( 2 ,'Iquique')
	 , ( 2 ,'Alto Hospicio')
	 , ( 2 ,'Pozo Almonte')
	 , ( 2 ,'Cami�a')
	 , ( 2 ,'Colchane')
	 , ( 2 ,'Huara')
	 , ( 2 ,'Pica')
	 , ( 3 ,'Antofagasta')
	 , ( 3 ,'Mejillones')
	 , ( 3 ,'Sierra Gorda')
	 , ( 3 ,'Taltal')
	 , ( 3 ,'Calama')
	 , ( 3 ,'Ollag�e')
	 , ( 3 ,'San Pedro de Atacama')
	 , ( 3 ,'Tocopilla')
	 , ( 3 ,'Mar�a Elena')
	 , ( 4 ,'Copiap�')
	 , ( 4 ,'Caldera')
	 , ( 4 ,'Tierra Amarilla')
	 , ( 4 ,'Cha�aral')
	 , ( 4 ,'Diego de Almagro')
	 , ( 4 ,'Vallenar')
	 , ( 4 ,'Alto del Carmen')
	 , ( 4 ,'Freirina')
	 , ( 4 ,'Huasco')
	 , ( 5 ,'La Serena')
	 , ( 5 ,'Coquimbo')
	 , ( 5 ,'Andacollo')
	 , ( 5 ,'La Higuera')
	 , ( 5 ,'Paiguano')
	 , ( 5 ,'Vicu�a')
	 , ( 5 ,'Illapel')
	 , ( 5 ,'Canela')
	 , ( 5 ,'Los Vilos')
	 , ( 5 ,'Salamanca')
	 , ( 5 ,'Ovalle')
	 , ( 5 ,'Combarbal�')
	 , ( 5 ,'Monte Patria')
	 , ( 5 ,'Punitaqui')
	 , ( 5 ,'R�o Hurtado')
	 , ( 6 ,'Valpara�so')
	 , ( 6 ,'Casablanca')
	 , ( 6 ,'Conc�n')
	 , ( 6 ,'Juan Fern�ndez')
	 , ( 6 ,'Puchuncav�')
	 , ( 6 ,'Quintero')
	 , ( 6 ,'Vi�a del Mar')
	 , ( 6 ,'Isla de Pascua')
	 , ( 6 ,'Los Andes')
	 , ( 6 ,'Calle Larga')
	 , ( 6 ,'Rinconada')
	 , ( 6 ,'San Esteban')
	 , ( 6 ,'La Ligua')
	 , ( 6 ,'Cabildo')
	 , ( 6 ,'Papudo')
	 , ( 6 ,'Petorca')
	 , ( 6 ,'Zapallar')
	 , ( 6 ,'Quillota')
	 , ( 6 ,'Calera')
	 , ( 6 ,'Hijuelas')
	 , ( 6 ,'La Cruz')
	 , ( 6 ,'Nogales')
	 , ( 6 ,'San Antonio')
	 , ( 6 ,'Algarrobo')
	 , ( 6 ,'Cartagena')
	 , ( 6 ,'El Quisco')
	 , ( 6 ,'El Tabo')
	 , ( 6 ,'Santo Domingo')
	 , ( 6 ,'San Felipe')
	 , ( 6 ,'Catemu')
	 , ( 6 ,'Llaillay')
	 , ( 6 ,'Panquehue')
	 , ( 6 ,'Putaendo')
	 , ( 6 ,'Santa Mar�a')
	 , ( 6 ,'Quilpu�')
	 , ( 6 ,'Limache')
	 , ( 6 ,'Olmu�')
	 , ( 6 ,'Villa Alemana')
	 , ( 7 ,'Rancagua')
	 , ( 7 ,'Codegua')
	 , ( 7 ,'Coinco')
	 , ( 7 ,'Coltauco')
	 , ( 7 ,'Do�ihue')
	 , ( 7 ,'Graneros')
	 , ( 7 ,'Las Cabras')
	 , ( 7 ,'Machal�')
	 , ( 7 ,'Malloa')
	 , ( 7 ,'Mostazal')
	 , ( 7 ,'Olivar')
	 , ( 7 ,'Peumo')
	 , ( 7 ,'Pichidegua')
	 , ( 7 ,'Quinta de Tilcoco')
	 , ( 7 ,'Rengo')
	 , ( 7 ,'Requ�noa')
	 , ( 7 ,'San Vicente')
	 , ( 7 ,'Pichilemu')
	 , ( 7 ,'La Estrella')
	 , ( 7 ,'Litueche')
	 , ( 7 ,'Marchihue')
	 , ( 7 ,'Navidad')
	 , ( 7 ,'Paredones')
	 , ( 7 ,'San Fernando')
	 , ( 7 ,'Ch�pica')
	 , ( 7 ,'Chimbarongo')
	 , ( 7 ,'Lolol')
	 , ( 7 ,'Nancagua')
	 , ( 7 ,'Palmilla')
	 , ( 7 ,'Peralillo')
	 , ( 7 ,'Placilla')
	 , ( 7 ,'Pumanque')
	 , ( 7 ,'Santa Cruz')
	 , ( 8 ,'Talca')
	 , ( 8 ,'Constituci�n')
	 , ( 8 ,'Curepto')
	 , ( 8 ,'Empedrado')
	 , ( 8 ,'Maule')
	 , ( 8 ,'Pelarco')
	 , ( 8 ,'Pencahue')
	 , ( 8 ,'R�o Claro')
	 , ( 8 ,'San Clemente')
	 , ( 8 ,'San Rafael')
	 , ( 8 ,'Cauquenes')
	 , ( 8 ,'Chanco')
	 , ( 8 ,'Pelluhue')
	 , ( 8 ,'Curic�')
	 , ( 8 ,'Huala��')
	 , ( 8 ,'Licant�n')
	 , ( 8 ,'Molina')
	 , ( 8 ,'Rauco')
	 , ( 8 ,'Romeral')
	 , ( 8 ,'Sagrada Familia')
	 , ( 8 ,'Teno')
	 , ( 8 ,'Vichuqu�n')
	 , ( 8 ,'Linares')
	 , ( 8 ,'Colb�n')
	 , ( 8 ,'Longav�')
	 , ( 8 ,'Parral')
	 , ( 8 ,'Retiro')
	 , ( 8 ,'San Javier')
	 , ( 8 ,'Villa Alegre')
	 , ( 8 ,'Yerbas Buenas')
	 , ( 9 ,'Concepci�n')
	 , ( 9 ,'Coronel')
	 , ( 9 ,'Chiguayante')
	 , ( 9 ,'Florida')
	 , ( 9 ,'Hualqui')
	 , ( 9 ,'Lota')
	 , ( 9 ,'Penco')
	 , ( 9 ,'San Pedro de la Paz')
	 , ( 9 ,'Santa Juana')
	 , ( 9 ,'Talcahuano')
	 , ( 9 ,'Tom�')
	 , ( 9 ,'Hualp�n')
	 , ( 9 ,'Lebu')
	 , ( 9 ,'Arauco')
	 , ( 9 ,'Ca�ete')
	 , ( 9 ,'Contulmo')
	 , ( 9 ,'Curanilahue')
	 , ( 9 ,'Los �lamos')
	 , ( 9 ,'Tir�a')
	 , ( 9 ,'Los �ngeles')
	 , ( 9 ,'Antuco')
	 , ( 9 ,'Cabrero')
	 , ( 9 ,'Laja')
	 , ( 9 ,'Mulch�n')
	 , ( 9 ,'Nacimiento')
	 , ( 9 ,'Negrete')
	 , ( 9 ,'Quilaco')
	 , ( 9 ,'Quilleco')
	 , ( 9 ,'San Rosendo')
	 , ( 9 ,'Santa B�rbara')
	 , ( 9 ,'Tucapel')
	 , ( 9 ,'Yumbel')
	 , ( 9 ,'Alto Biob�o')
	 , ( 9 ,'Chill�n')
	 , ( 9 ,'Bulnes')
	 , ( 9 ,'Cobquecura')
	 , ( 9 ,'Coelemu')
	 , ( 9 ,'Coihueco')
	 , ( 9 ,'Chill�n Viejo')
	 , ( 9 ,'El Carmen')
	 , ( 9 ,'Ninhue')
	 , ( 9 ,'�iqu�n')
	 , ( 9 ,'Pemuco')
	 , ( 9 ,'Pinto')
	 , ( 9 ,'Portezuelo')
	 , ( 9 ,'Quill�n')
	 , ( 9 ,'Quirihue')
	 , ( 9 ,'R�nquil')
	 , ( 9 ,'San Carlos')
	 , ( 9 ,'San Fabi�n')
	 , ( 9 ,'San Ignacio')
	 , ( 9 ,'San Nicol�s')
	 , ( 9 ,'Treguaco')
	 , ( 9 ,'Yungay')
	 , ( 10 ,'Temuco')
	 , ( 10 ,'Carahue')
	 , ( 10 ,'Cunco')
	 , ( 10 ,'Curarrehue')
	 , ( 10 ,'Freire')
	 , ( 10 ,'Galvarino')
	 , ( 10 ,'Gorbea')
	 , ( 10 ,'Lautaro')
	 , ( 10 ,'Loncoche')
	 , ( 10 ,'Melipeuco')
	 , ( 10 ,'Nueva Imperial')
	 , ( 10 ,'Padre las Casas')
	 , ( 10 ,'Perquenco')
	 , ( 10 ,'Pitrufqu�n')
	 , ( 10 ,'Puc�n')
	 , ( 10 ,'Saavedra')
	 , ( 10 ,'Teodoro Schmidt')
	 , ( 10 ,'Tolt�n')
	 , ( 10 ,'Vilc�n')
	 , ( 10 ,'Villarrica')
	 , ( 10 ,'Cholchol')
	 , ( 10 ,'Angol')
	 , ( 10 ,'Collipulli')
	 , ( 10 ,'Curacaut�n')
	 , ( 10 ,'Ercilla')
	 , ( 10 ,'Lonquimay')
	 , ( 10 ,'Los Sauces')
	 , ( 10 ,'Lumaco')
	 , ( 10 ,'Pur�n')
	 , ( 10 ,'Renaico')
	 , ( 10 ,'Traigu�n')
	 , ( 10 ,'Victoria')
	 , ( 11 ,'Puerto Montt')
	 , ( 11 ,'Calbuco')
	 , ( 11 ,'Cocham�')
	 , ( 11 ,'Fresia')
	 , ( 11 ,'Frutillar')
	 , ( 11 ,'Los Muermos')
	 , ( 11 ,'Llanquihue')
	 , ( 11 ,'Maull�n')
	 , ( 11 ,'Puerto Varas')
	 , ( 11 ,'Castro')
	 , ( 11 ,'Ancud')
	 , ( 11 ,'Chonchi')
	 , ( 11 ,'Curaco de V�lez')
	 , ( 11 ,'Dalcahue')
	 , ( 11 ,'Puqueld�n')
	 , ( 11 ,'Queil�n')
	 , ( 11 ,'Quell�n')
	 , ( 11 ,'Quemchi')
	 , ( 11 ,'Quinchao')
	 , ( 11 ,'Osorno')
	 , ( 11 ,'Puerto Octay')
	 , ( 11 ,'Purranque')
	 , ( 11 ,'Puyehue')
	 , ( 11 ,'R�o Negro')
	 , ( 11 ,'San Juan de la Costa')
	 , ( 11 ,'San Pablo')
	 , ( 11 ,'Chait�n')
	 , ( 11 ,'Futaleuf�')
	 , ( 11 ,'Hualaihu�')
	 , ( 11 ,'Palena')
	 , ( 12 ,'Coihaique')
	 , ( 12 ,'Lago Verde')
	 , ( 12 ,'Ais�n')
	 , ( 12 ,'Cisnes')
	 , ( 12 ,'Guaitecas')
	 , ( 12 ,'Cochrane')
	 , ( 12 ,'O''Higgins')
	 , ( 12 ,'Tortel')
	 , ( 12 ,'Chile Chico')
	 , ( 12 ,'R�o Ib��ez')
	 , ( 13 ,'Punta Arenas')
	 , ( 13 ,'Laguna Blanca')
	 , ( 13 ,'R�o Verde')
	 , ( 13 ,'San Gregorio')
	 , ( 13 ,'Cabo de Hornos')
	 , ( 13 ,'Ant�rtica')
	 , ( 13 ,'Porvenir')
	 , ( 13 ,'Primavera')
	 , ( 13 ,'Timaukel')
	 , ( 13 ,'Natales')
	 , ( 13 ,'Torres del Paine')
	 , ( 14 ,'Santiago')
	 , ( 14 ,'Cerrillos')
	 , ( 14 ,'Cerro Navia')
	 , ( 14 ,'Conchal�')
	 , ( 14 ,'El Bosque')
	 , ( 14 ,'Estaci�n Central')
	 , ( 14 ,'Huechuraba')
	 , ( 14 ,'Independencia')
	 , ( 14 ,'La Cisterna')
	 , ( 14 ,'La Florida')
	 , ( 14 ,'La Granja')
	 , ( 14 ,'La Pintana')
	 , ( 14 ,'La Reina')
	 , ( 14 ,'Las Condes')
	 , ( 14 ,'Lo Barnechea')
	 , ( 14 ,'Lo Espejo')
	 , ( 14 ,'Lo Prado')
	 , ( 14 ,'Macul')
	 , ( 14 ,'Maip�')
	 , ( 14 ,'�u�oa')
	 , ( 14 ,'Pedro Aguirre Cerda')
	 , ( 14 ,'Pe�alol�n')
	 , ( 14 ,'Providencia')
	 , ( 14 ,'Pudahuel')
	 , ( 14 ,'Quilicura')
	 , ( 14 ,'Quinta Normal')
	 , ( 14 ,'Recoleta')
	 , ( 14 ,'Renca')
	 , ( 14 ,'San Joaqu�n')
	 , ( 14 ,'San Miguel')
	 , ( 14 ,'San Ram�n')
	 , ( 14 ,'Vitacura')
	 , ( 14 ,'Puente Alto')
	 , ( 14 ,'Pirque')
	 , ( 14 ,'San Jos� de Maipo')
	 , ( 14 ,'Colina')
	 , ( 14 ,'Lampa')
	 , ( 14 ,'Tiltil')
	 , ( 14 ,'San Bernardo')
	 , ( 14 ,'Buin')
	 , ( 14 ,'Calera de Tango')
	 , ( 14 ,'Paine')
	 , ( 14 ,'Melipilla')
	 , ( 14 ,'Alhu�')
	 , ( 14 ,'Curacav�')
	 , ( 14 ,'Mar�a Pinto')
	 , ( 14 ,'San Pedro')
	 , ( 14 ,'Talagante')
	 , ( 14 ,'El Monte')
	 , ( 14 ,'Isla de Maipo')
	 , ( 14 ,'Padre Hurtado')
	 , ( 14 ,'Pe�aflor')
	 , ( 15 ,'Valdivia')
	 , ( 15 ,'Corral')
	 , ( 15 ,'Lanco')
	 , ( 15 ,'Los Lagos')
	 , ( 15 ,'M�fil')
	 , ( 15 ,'Mariquina')
	 , ( 15 ,'Paillaco')
	 , ( 15 ,'Panguipulli')
	 , ( 15 ,'La Uni�n')
	 , ( 15 ,'Futrono')
	 , ( 15 ,'Lago Ranco')
	 , ( 15 ,'R�o Bueno')
GO