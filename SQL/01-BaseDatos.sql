USE master
GO

IF ( EXISTS ( SELECT    name
              FROM      master.dbo.sysdatabases
              WHERE     ( '[' + name + ']' = 'ModulOTEC'
                          OR name = 'ModulOTEC'
                        ) ) )
    BEGIN
        EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'ModulOTEC'
        ALTER DATABASE ModulOTEC
        SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
        DROP DATABASE ModulOTEC                      	
    END
GO

CREATE DATABASE ModulOTEC
GO

USE ModulOTEC
GO


/*==============================================================*/
/* Table: AnalisisCausa                                         */
/*==============================================================*/
CREATE TABLE AnalisisCausa
    (
      IdAnalisisCausa INT IDENTITY ,
      IdIncidencia INT NULL ,
      AccionesInmediatas VARCHAR(MAX) NOT NULL ,
      EfectosDeseados VARCHAR(MAX) NOT NULL ,
      CausasPotenciales VARCHAR(MAX) NOT NULL ,
      IdTratamiento INT NULL ,
      FechaLimite DATE NOT NULL ,
      CONSTRAINT PK_ANALISISCAUSA PRIMARY KEY ( IdAnalisisCausa )
    )
GO

/*==============================================================*/
/* Table: Ciudades                                              */
/*==============================================================*/
CREATE TABLE Ciudades
    (
      IdCiudad INT NOT NULL ,
      IdRegion INT NOT NULL ,
      Ciudad VARCHAR(15) NOT NULL ,
      CONSTRAINT PK_CIUDADES PRIMARY KEY ( IdCiudad )
    )
GO

/*==============================================================*/
/* Table: Documentos                                            */
/*==============================================================*/
CREATE TABLE Documentos
    (
      IdDocumento INT NOT NULL ,
      IdAnalisisCausa INT NULL ,
      UrlDocumento VARCHAR(MAX) NOT NULL ,
      CONSTRAINT PK_DOCUMENTOS PRIMARY KEY ( IdDocumento )
    )
GO

/*==============================================================*/
/* Table: EstadosIncidencia                                     */
/*==============================================================*/
CREATE TABLE EstadosIncidencia
    (
      IdEstadoIncidencia INT IDENTITY ,
      Descripcion VARCHAR(50) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ESTADOSINCIDENCIA PRIMARY KEY ( IdEstadoIncidencia )
    )
GO

/*==============================================================*/
/* Table: Incidencias                                           */
/*==============================================================*/
CREATE TABLE Incidencias
    (
      IdIncidencia INT IDENTITY ,
      RutCreador INT NOT NULL ,
      IdTipoIncidencia INT NOT NULL ,
      IdModoDeteccion INT NOT NULL ,
      FechaIdentificacion DATE NOT NULL ,
      AreaAfectada VARCHAR(150) NOT NULL ,
      Descripcion VARCHAR(MAX) NOT NULL ,
      IdEstadoIncidencia INT NOT NULL ,
      CONSTRAINT PK_INCIDENCIAS PRIMARY KEY ( IdIncidencia )
    )
GO

/*==============================================================*/
/* Table: ModosDeteccion                                        */
/*==============================================================*/
CREATE TABLE ModosDeteccion
    (
      IdModoDeteccion INT IDENTITY ,
      Descripcion VARCHAR(50) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_MODOSDETECCION PRIMARY KEY ( IdModoDeteccion )
    )
GO

/*==============================================================*/
/* Table: Organizacion                                          */
/*==============================================================*/
CREATE TABLE Organizacion
    (
      IdOrganizacion INT IDENTITY ,
      RUN INT NOT NULL ,
      DV CHAR(1) NOT NULL ,
      RazonSocial VARCHAR(150) NOT NULL ,
      Direccion VARCHAR(100) NOT NULL ,
      Telefono INT NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ORGANIZACION PRIMARY KEY ( IdOrganizacion )
    )
GO

/*==============================================================*/
/* Table: Regiones                                              */
/*==============================================================*/
CREATE TABLE Regiones
    (
      IdRegion INT NOT NULL ,
      Region VARCHAR(20) NOT NULL ,
      CONSTRAINT PK_REGIONES PRIMARY KEY ( IdRegion )
    )
GO

/*==============================================================*/
/* Table: Roles                                                 */
/*==============================================================*/
CREATE TABLE Roles
    (
      IdRol INT IDENTITY ,
      Descripcion VARCHAR(50) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ROLES PRIMARY KEY ( IdRol )
    )
GO

/*==============================================================*/
/* Table: TiposIncidencias                                      */
/*==============================================================*/
CREATE TABLE TiposIncidencias
    (
      IdTipoIncidencia INT IDENTITY ,
      Descripcion VARCHAR(50) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_TIPOSINCIDENCIAS PRIMARY KEY ( IdTipoIncidencia )
    )
GO

/*==============================================================*/
/* Table: Tratamiento                                           */
/*==============================================================*/
CREATE TABLE Tratamiento
    (
      IdTratamiento INT IDENTITY ,
      Descripcion VARCHAR(50) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_TRATAMIENTO PRIMARY KEY ( IdTratamiento )
    )
GO

/*==============================================================*/
/* Table: Usuarios                                              */
/*==============================================================*/
CREATE TABLE Usuarios
    (
      RUT INT NOT NULL ,
      DV CHAR(1) NOT NULL ,
      Nombres VARCHAR(50) NOT NULL ,
      ApPaterno VARCHAR(50) NOT NULL ,
      ApMaterno VARCHAR(50) NULL ,
      Direccion VARCHAR(100) NULL ,
      IdCiudad INT NULL ,
      Telefono INT NULL ,
      Email VARCHAR(70) NOT NULL ,
      IdRol INT NULL ,
      EsRepresentante BIT NOT NULL ,
      IdOrganizacion INT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_USUARIOS PRIMARY KEY ( RUT )
    )
GO

ALTER TABLE AnalisisCausa
ADD CONSTRAINT FK_ANALISIS_REFERENCE_TRATAMIE FOREIGN KEY (IdTratamiento)
REFERENCES Tratamiento (IdTratamiento)
GO

ALTER TABLE AnalisisCausa
ADD CONSTRAINT FK_ANALISIS_REFERENCE_INCIDENC FOREIGN KEY (IdIncidencia)
REFERENCES Incidencias (IdIncidencia)
GO

ALTER TABLE Ciudades
ADD CONSTRAINT FK_CIUDADES_REF_CIUDA_REGIONES FOREIGN KEY (IdRegion)
REFERENCES Regiones (IdRegion)
GO

ALTER TABLE Documentos
ADD CONSTRAINT FK_DOCUMENT_REFERENCE_ANALISIS FOREIGN KEY (IdAnalisisCausa)
REFERENCES AnalisisCausa (IdAnalisisCausa)
GO

ALTER TABLE Incidencias
ADD CONSTRAINT FK_INCIDENC_REF_INCID_ESTADOSI FOREIGN KEY (IdEstadoIncidencia)
REFERENCES EstadosIncidencia (IdEstadoIncidencia)
GO

ALTER TABLE Incidencias
ADD CONSTRAINT FK_INCIDENC_REF_INCID_MODOSDET FOREIGN KEY (IdModoDeteccion)
REFERENCES ModosDeteccion (IdModoDeteccion)
GO

ALTER TABLE Incidencias
ADD CONSTRAINT FK_INCIDENC_REF_INCID_TIPOSINC FOREIGN KEY (IdTipoIncidencia)
REFERENCES TiposIncidencias (IdTipoIncidencia)
GO

ALTER TABLE Incidencias
ADD CONSTRAINT FK_INCIDENC_REF_INCID_USUARIOS FOREIGN KEY (RutCreador)
REFERENCES Usuarios (RUT)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REF_USUAR_CIUDADES FOREIGN KEY (IdCiudad)
REFERENCES Ciudades (IdCiudad)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REF_USUAR_ORGANIZA FOREIGN KEY (IdOrganizacion)
REFERENCES Organizacion (IdOrganizacion)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REF_USUAR_ROLES FOREIGN KEY (IdRol)
REFERENCES Roles (IdRol)
GO