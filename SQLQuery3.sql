-- Tabla TipoUsuario
CREATE TABLE TipoUsuario (
    IDTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(50) NOT NULL UNIQUE
);

-- Tabla Users (Actualizada para referenciar TipoUsuario)
CREATE TABLE Users (
    IDUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL, -- Para almacenar contraseñas en formato hash
    Rol NVARCHAR(20) NOT NULL CHECK (Rol IN ('Admin', 'Regular')),
    IDTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IDTipoUsuario)
);

-- Tabla Registro
CREATE TABLE Registro (
    IDRegistro INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME DEFAULT GETDATE(),
    Datos NVARCHAR(MAX) NOT NULL,
    IDUsuario INT FOREIGN KEY REFERENCES Users(IDUsuario)
);

-- Tabla Respaldo
CREATE TABLE Respaldo (
    IDRespaldo INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME DEFAULT GETDATE(),
    RutaArchivo NVARCHAR(255) NOT NULL
);
