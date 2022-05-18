USE Prueba;
GO
CREATE PROC MostrarCiudades
AS BEGIN
SELECT * FROM Ciudades
END
Go

CREATE PROC MostrarAerolineas
AS BEGIN
SELECT * FROM Aerolineas
END
Go

CREATE PROC MostrarCiudad
@ID INT
AS BEGIN
SELECT * FROM Ciudades WHERE Id=@ID
END
GO

CREATE PROC MostrarAerolinea
@ID INT
AS BEGIN
SELECT * FROM Aerolineas WHERE Id=@ID
END
GO

CREATE PROC InsertarAerolinea
@Nombre NVARCHAR(50)
AS BEGIN
INSERT INTO Aerolineas VALUES (@Nombre)
END
GO

CREATE PROC InsertarCiudad
@Nombre NVARCHAR(50)
AS BEGIN
INSERT INTO Ciudades VALUES (@Nombre)
END
GO

CREATE PROC EliminarCiudad
@ID INT
AS BEGIN
DELETE FROM Ciudades WHERE Id=@ID
END
GO

CREATE PROC EliminarAerolinea
@ID INT
AS BEGIN
DELETE FROM Aerolineas WHERE Id=@ID
END
GO

create proc ActualizarAerolinea
@ID int,
@Nombre varchar(50)
as begin
update Aerolineas set Nombre=@Nombre where Id=@ID
end
go

create proc ActualizarCiudad
@ID int,
@Nombre varchar(50)
as begin
update Ciudades set Nombre=@Nombre where Id=@ID
end
go

CREATE PROC InsertarVuelo
@NumeroV int,
@Fecha Date,
@Salida Time,
@Llegada Time,
@COrigen int,
@CDestino int,
@Aerolinea int,
@Estado bit
AS BEGIN
INSERT INTO Vuelos Values(@NumeroV,@Fecha,@Salida,@Llegada,@COrigen,@CDestino,@Aerolinea,@Estado)
END
GO


CREATE PROC CambiarEstadoVuelo
@ID int,
@Estado bit
AS BEGIN
UPDATE Vuelos SET Estado=@Estado WHERE Id=@ID
END
GO

CREATE PROC EliminarVueloXCiudad
@IdCiudad int
AS BEGIN
DELETE from Vuelos WHERE Origen=@IdCiudad or Destino=@IdCiudad
END
GO

CREATE PROC EliminarVueloXAerolinea
@IdAerolinea int
AS BEGIN
DELETE FROM Vuelos WHERE Aerolinea=@IdAerolinea
END
GO

CREATE PROC ValidarAdmin
@Cedula INT,
@Contrasena nvarchar(20)
AS BEGIN
SELECT * FROM ADMINISTRADORES where Cedula=@Cedula and Pass=@Contrasena
END
GO

CREATE PROC MostrarVuelos
AS BEGIN
SELECT * FROM Vuelos
END
GO

CREATE PROC MostrarVuelo
@ID INT
AS BEGIN
SELECT * FROM Vuelos where Id=@ID
END
GO
