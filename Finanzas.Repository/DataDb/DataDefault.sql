--      Crear una migracion
--      cd .\Finanzas.Repository\ 
--      dotnet ef --startup-project ../Finanzas.Api migrations add NuevoNombreDeLaVersion

--      Ejecutar la migracion
--      dotnet ef --startup-project ../Finanzas.Api database update

-- Tabla Departamento
INSERT INTO Departamento (Nombre) VALUES ('Lima')

-- Tabla Provincia
INSERT INTO Provincia (Nombre, DepartamentoId) VALUES ('Lima', 1)

-- Tabla Distrito
INSERT INTO Distrito (Nombre, ProvinciaId) VALUES ('Lima', 1)