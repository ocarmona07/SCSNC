USE ModulOTEC
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Acciones')
                    AND o.name = 'FK_ACCIONES_REFERENCE_ANALISIS' )
    ALTER TABLE Acciones
    DROP CONSTRAINT FK_ACCIONES_REFERENCE_ANALISIS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Acciones')
                    AND o.name = 'FK_ACCIONES_REFERENCE_ESTADOSA' )
    ALTER TABLE Acciones
    DROP CONSTRAINT FK_ACCIONES_REFERENCE_ESTADOSA
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('AnalisisCausa')
                    AND o.name = 'FK_ANALISIS_REFERENCE_TRATAMIE' )
    ALTER TABLE AnalisisCausa
    DROP CONSTRAINT FK_ANALISIS_REFERENCE_TRATAMIE
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('AnalisisCausa')
                    AND o.name = 'FK_ANALISIS_REFERENCE_INCIDENC' )
    ALTER TABLE AnalisisCausa
    DROP CONSTRAINT FK_ANALISIS_REFERENCE_INCIDENC
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Comunas')
                    AND o.name = 'FK_COMUNAS_REFERENCE_PROVINCI' )
    ALTER TABLE Comunas
    DROP CONSTRAINT FK_COMUNAS_REFERENCE_PROVINCI
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Documentos')
                    AND o.name = 'FK_DOCUMENT_REFERENCE_ANALISIS' )
    ALTER TABLE Documentos
    DROP CONSTRAINT FK_DOCUMENT_REFERENCE_ANALISIS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('EvaluacionCumplimiento')
                    AND o.name = 'FK_EVALUACI_REFERENCE_ANALISIS' )
    ALTER TABLE EvaluacionCumplimiento
    DROP CONSTRAINT FK_EVALUACI_REFERENCE_ANALISIS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Incidencias')
                    AND o.name = 'FK_INCIDENC_REF_INCID_ESTADOSI' )
    ALTER TABLE Incidencias
    DROP CONSTRAINT FK_INCIDENC_REF_INCID_ESTADOSI
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Incidencias')
                    AND o.name = 'FK_INCIDENC_REF_INCID_MODOSDET' )
    ALTER TABLE Incidencias
    DROP CONSTRAINT FK_INCIDENC_REF_INCID_MODOSDET
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Incidencias')
                    AND o.name = 'FK_INCIDENC_REF_INCID_TIPOSINC' )
    ALTER TABLE Incidencias
    DROP CONSTRAINT FK_INCIDENC_REF_INCID_TIPOSINC
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Incidencias')
                    AND o.name = 'FK_INCIDENC_REF_INCID_USUARIOS' )
    ALTER TABLE Incidencias
    DROP CONSTRAINT FK_INCIDENC_REF_INCID_USUARIOS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Organizacion')
                    AND o.name = 'FK_ORGANIZA_REFERENCE_COMUNAS' )
    ALTER TABLE Organizacion
    DROP CONSTRAINT FK_ORGANIZA_REFERENCE_COMUNAS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Provincias')
                    AND o.name = 'FK_PROVINCI_REFERENCE_REGIONES' )
    ALTER TABLE Provincias
    DROP CONSTRAINT FK_PROVINCI_REFERENCE_REGIONES
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('RolAcceso')
                    AND o.name = 'FK_ROLACCES_REFERENCE_ROLES' )
    ALTER TABLE RolAcceso
    DROP CONSTRAINT FK_ROLACCES_REFERENCE_ROLES
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('RolAcceso')
                    AND o.name = 'FK_ROLACCES_REFERENCE_ACCESOS' )
    ALTER TABLE RolAcceso
    DROP CONSTRAINT FK_ROLACCES_REFERENCE_ACCESOS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Usuarios')
                    AND o.name = 'FK_USUARIOS_REFERENCE_COMUNAS' )
    ALTER TABLE Usuarios
    DROP CONSTRAINT FK_USUARIOS_REFERENCE_COMUNAS
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Usuarios')
                    AND o.name = 'FK_USUARIOS_REF_USUAR_ORGANIZA' )
    ALTER TABLE Usuarios
    DROP CONSTRAINT FK_USUARIOS_REF_USUAR_ORGANIZA
GO

IF EXISTS ( SELECT  1
            FROM    sys.sysreferences r
                    JOIN sys.sysobjects o ON ( o.id = r.constid
                                               AND o.type = 'F'
                                             )
            WHERE   r.fkeyid = OBJECT_ID('Usuarios')
                    AND o.name = 'FK_USUARIOS_REF_USUAR_ROLES' )
    ALTER TABLE Usuarios
    DROP CONSTRAINT FK_USUARIOS_REF_USUAR_ROLES
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Accesos')
                    AND type = 'U' )
    DROP TABLE Accesos
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Acciones')
                    AND type = 'U' )
    DROP TABLE Acciones
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('AnalisisCausa')
                    AND type = 'U' )
    DROP TABLE AnalisisCausa
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Comunas')
                    AND type = 'U' )
    DROP TABLE Comunas
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Documentos')
                    AND type = 'U' )
    DROP TABLE Documentos
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('EstadosAccion')
                    AND type = 'U' )
    DROP TABLE EstadosAccion
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('EstadosIncidencia')
                    AND type = 'U' )
    DROP TABLE EstadosIncidencia
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('EvaluacionCumplimiento')
                    AND type = 'U' )
    DROP TABLE EvaluacionCumplimiento
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Incidencias')
                    AND type = 'U' )
    DROP TABLE Incidencias
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('ModosDeteccion')
                    AND type = 'U' )
    DROP TABLE ModosDeteccion
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Organizacion')
                    AND type = 'U' )
    DROP TABLE Organizacion
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Provincias')
                    AND type = 'U' )
    DROP TABLE Provincias
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Regiones')
                    AND type = 'U' )
    DROP TABLE Regiones
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('RolAcceso')
                    AND type = 'U' )
    DROP TABLE RolAcceso
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Roles')
                    AND type = 'U' )
    DROP TABLE Roles
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('TiposIncidencias')
                    AND type = 'U' )
    DROP TABLE TiposIncidencias
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Tratamientos')
                    AND type = 'U' )
    DROP TABLE Tratamientos
GO

IF EXISTS ( SELECT  1
            FROM    sysobjects
            WHERE   id = OBJECT_ID('Usuarios')
                    AND type = 'U' )
    DROP TABLE Usuarios
GO

/*==============================================================*/
/* Table: Accesos                                               */
/*==============================================================*/
CREATE TABLE Accesos
    (
      IdAcceso INT NOT NULL ,
      DetalleAcceso VARCHAR(100) NOT NULL ,
      UrlAcceso VARCHAR(200) NOT NULL ,
      CONSTRAINT PK_ACCESOS PRIMARY KEY ( IdAcceso )
    )
GO

/*==============================================================*/
/* Table: Acciones                                              */
/*==============================================================*/
CREATE TABLE Acciones
    (
      IdAccion INT IDENTITY ,
      IdAnalisisCausa INT NULL ,
      IdEstado INT NULL ,
      DescAccion VARCHAR(MAX) NOT NULL ,
      CONSTRAINT PK_ACCIONES PRIMARY KEY ( IdAccion )
    )
GO

/*==============================================================*/
/* Table: AnalisisCausa                                         */
/*==============================================================*/
CREATE TABLE AnalisisCausa
    (
      IdAnalisisCausa INT IDENTITY ,
      IdIncidencia INT NULL ,
      EfectosDeseados VARCHAR(MAX) NOT NULL ,
      CausasPotenciales VARCHAR(MAX) NOT NULL ,
      IdTratamiento INT NULL ,
      FechaLimite DATE NOT NULL ,
      CONSTRAINT PK_ANALISISCAUSA PRIMARY KEY ( IdAnalisisCausa )
    )
GO

/*==============================================================*/
/* Table: Comunas                                               */
/*==============================================================*/
CREATE TABLE Comunas
    (
      IdComuna INT NOT NULL ,
      IdProvincia INT NOT NULL ,
      Comuna VARCHAR(50) NOT NULL ,
      CONSTRAINT PK_COMUNAS PRIMARY KEY ( IdComuna )
    )
GO

/*==============================================================*/
/* Table: Documentos                                            */
/*==============================================================*/
CREATE TABLE Documentos
    (
      IdDocumento INT IDENTITY ,
      IdAnalisisCausa INT NULL ,
      UrlDocumento VARCHAR(MAX) NOT NULL ,
      CONSTRAINT PK_DOCUMENTOS PRIMARY KEY ( IdDocumento )
    )
GO

/*==============================================================*/
/* Table: EstadosAccion                                         */
/*==============================================================*/
CREATE TABLE EstadosAccion
    (
      IdEstado INT NOT NULL ,
      Descripcion VARCHAR(35) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ESTADOSACCION PRIMARY KEY ( IdEstado )
    )
GO

/*==============================================================*/
/* Table: EstadosIncidencia                                     */
/*==============================================================*/
CREATE TABLE EstadosIncidencia
    (
      IdEstadoIncidencia INT NOT NULL ,
      Descripcion VARCHAR(150) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ESTADOSINCIDENCIA PRIMARY KEY ( IdEstadoIncidencia )
    )
GO

/*==============================================================*/
/* Table: EvaluacionCumplimiento                                */
/*==============================================================*/
CREATE TABLE EvaluacionCumplimiento
    (
      IdEvaluacion INT IDENTITY ,
      IdAnalisisCausa INT NULL ,
      Observacion VARCHAR(MAX) NULL ,
      FechaEv DATE NULL ,
      CONSTRAINT PK_EVALUACIONCUMPLIMIENTO PRIMARY KEY ( IdEvaluacion )
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
      ProcesoAfectado VARCHAR(150) NULL ,
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
      IdModoDeteccion INT NOT NULL ,
      Descripcion VARCHAR(150) NOT NULL ,
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
      Direccion VARCHAR(150) NOT NULL ,
      IdComuna INT NOT NULL ,
      Telefono INT NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_ORGANIZACION PRIMARY KEY ( IdOrganizacion )
    )
GO

/*==============================================================*/
/* Table: Provincias                                            */
/*==============================================================*/
CREATE TABLE Provincias
    (
      IdProvincia INT NOT NULL ,
      IdRegion INT NOT NULL ,
      Provincia VARCHAR(50) NULL ,
      CONSTRAINT PK_PROVINCIAS PRIMARY KEY ( IdProvincia )
    )
GO

/*==============================================================*/
/* Table: Regiones                                              */
/*==============================================================*/
CREATE TABLE Regiones
    (
      IdRegion INT NOT NULL ,
      Region VARCHAR(50) NOT NULL ,
      CONSTRAINT PK_REGIONES PRIMARY KEY ( IdRegion )
    )
GO

/*==============================================================*/
/* Table: RolAcceso                                             */
/*==============================================================*/
CREATE TABLE RolAcceso
    (
      IdRolAcceso INT IDENTITY ,
      IdRol INT NULL ,
      IdAcceso INT NULL ,
      CONSTRAINT PK_ROLACCESO PRIMARY KEY ( IdRolAcceso )
    )
GO

/*==============================================================*/
/* Table: Roles                                                 */
/*==============================================================*/
CREATE TABLE Roles
    (
      IdRol INT NOT NULL ,
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
      IdTipoIncidencia INT NOT NULL ,
      Descripcion VARCHAR(MAX) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_TIPOSINCIDENCIAS PRIMARY KEY ( IdTipoIncidencia )
    )
GO

/*==============================================================*/
/* Table: Tratamientos                                          */
/*==============================================================*/
CREATE TABLE Tratamientos
    (
      IdTratamiento INT NOT NULL ,
      Descripcion VARCHAR(150) NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_TRATAMIENTOS PRIMARY KEY ( IdTratamiento )
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
      Direccion VARCHAR(150) NULL ,
      Telefono INT NULL ,
      Email VARCHAR(70) NOT NULL ,
      PassUsuario VARCHAR(15) NOT NULL ,
      IdRol INT NOT NULL ,
      EsRepresentante BIT NOT NULL ,
      IdOrganizacion INT NULL ,
      IdComuna INT NOT NULL ,
      Estado BIT NOT NULL ,
      CONSTRAINT PK_USUARIOS PRIMARY KEY ( RUT )
    )
GO

ALTER TABLE Acciones
ADD CONSTRAINT FK_ACCIONES_REFERENCE_ANALISIS FOREIGN KEY (IdAnalisisCausa)
REFERENCES AnalisisCausa (IdAnalisisCausa)
GO

ALTER TABLE Acciones
ADD CONSTRAINT FK_ACCIONES_REFERENCE_ESTADOSA FOREIGN KEY (IdEstado)
REFERENCES EstadosAccion (IdEstado)
GO

ALTER TABLE AnalisisCausa
ADD CONSTRAINT FK_ANALISIS_REFERENCE_TRATAMIE FOREIGN KEY (IdTratamiento)
REFERENCES Tratamientos (IdTratamiento)
GO

ALTER TABLE AnalisisCausa
ADD CONSTRAINT FK_ANALISIS_REFERENCE_INCIDENC FOREIGN KEY (IdIncidencia)
REFERENCES Incidencias (IdIncidencia)
GO

ALTER TABLE Comunas
ADD CONSTRAINT FK_COMUNAS_REFERENCE_PROVINCI FOREIGN KEY (IdProvincia)
REFERENCES Provincias (IdProvincia)
GO

ALTER TABLE Documentos
ADD CONSTRAINT FK_DOCUMENT_REFERENCE_ANALISIS FOREIGN KEY (IdAnalisisCausa)
REFERENCES AnalisisCausa (IdAnalisisCausa)
GO

ALTER TABLE EvaluacionCumplimiento
ADD CONSTRAINT FK_EVALUACI_REFERENCE_ANALISIS FOREIGN KEY (IdAnalisisCausa)
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

ALTER TABLE Organizacion
ADD CONSTRAINT FK_ORGANIZA_REFERENCE_COMUNAS FOREIGN KEY (IdComuna)
REFERENCES Comunas (IdComuna)
GO

ALTER TABLE Provincias
ADD CONSTRAINT FK_PROVINCI_REFERENCE_REGIONES FOREIGN KEY (IdRegion)
REFERENCES Regiones (IdRegion)
GO

ALTER TABLE RolAcceso
ADD CONSTRAINT FK_ROLACCES_REFERENCE_ROLES FOREIGN KEY (IdRol)
REFERENCES Roles (IdRol)
GO

ALTER TABLE RolAcceso
ADD CONSTRAINT FK_ROLACCES_REFERENCE_ACCESOS FOREIGN KEY (IdAcceso)
REFERENCES Accesos (IdAcceso)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REFERENCE_COMUNAS FOREIGN KEY (IdComuna)
REFERENCES Comunas (IdComuna)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REF_USUAR_ORGANIZA FOREIGN KEY (IdOrganizacion)
REFERENCES Organizacion (IdOrganizacion)
GO

ALTER TABLE Usuarios
ADD CONSTRAINT FK_USUARIOS_REF_USUAR_ROLES FOREIGN KEY (IdRol)
REFERENCES Roles (IdRol)
GO
