# AeroHub
Una aplicación de gestión de vuelos, aviones y pasajeros destinada a aerolineas.

## Descripcion
AeroHub es una aplicación de gestión para aerolineas. Proporciona una solución completa para administrar pasajeros, vuelos, aviones y equipaje. La aplicación está desarrollada en C# utilizando Windows Forms como interfaz gráfica y utiliza serialización JSON y XML para almacenar los datos. Permite llevar un registro de los vuelos programados, asignar aviones a cada vuelo, gestionar la lista de pasajeros y administrar la disponibilidad de asientos.

La aplicación cuenta con una interfaz intuitiva y fácil de usar, que permite a los usuarios realizar operaciones como agregar nuevos vuelos, asignar aviones, registrar pasajeros y realizar consultas de vuelos y aviones, ademas de vender nuevos vuelos a los clientes.

## Caracteristicas
- Registro de pasajeros: Permite registrar los datos personales de los pasajeros, como nombre, apellido, número de dni, fecha de nacimiento, entre otros.
- Reserva de vuelos: Permite buscar y reservar vuelos disponibles, seleccionando el origen, destino, fecha de salida y número de pasajeros. 
- Gestión de aviones: Permite administrar la flota de aviones de la aerolinea, incluyendo información como la matrícula, capacidad de pasajeros y capacidad de carga. 
- Generación de informes: Ofrece la capacidad de generar informes detallados sobre vuelos, pasajeros, ingresos, ocupación de aviones y otros aspectos clave de la operación de la aerolinea.
- Venta de vuelos: Permite ofrecer a un cliente los vuelos disponibles brindando informacion como precios, capacidad restante, fechas y destinos.

## Principales funciones
Las principales funciones son 6, 2 aparecen en el perfil de Administador, y las otras 4 en el de Vendedor y Supervisor.

_Menú de Administrador:_
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/ccabd7a9-7caf-40e7-b18c-06c70facd946)

_Menú de Vendedor:_
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/fe66f388-f371-4ad7-95d6-f88e8d805600)

Aviones
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/b5febc2e-d1a7-4093-9460-980fa4dd4a53)

Agregar avion
Viajes
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/43ce6094-8f26-4b0d-b5ec-f5e643c31733)
Agregar viaje
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/2bfd0460-e638-4dd6-87ee-323a58386992)


## Diagrama de clases
![image](https://github.com/SantiSTC/Iannello.Santiago.PrimerParcial/assets/89161674/1b0bb9b7-9027-46c2-9f51-2b6206263bdc)

## Justificacion técnica
Dentro del programa se aplican todos los temas vistos en clase hasta la fecha de entrega del mismo, ademas de algunos otros vistos posteriormente.
Se utiliza en muchas ocasiones la herencia de clases, tanto en las entidades como en los formularios (herencia grafica).
Aplico tambien polimorfismo en casi todas las entidades, la sobrecarga de constructores y operadores, ademas de la sobrescritura de metodos como el ToString() y el Equals().
Tambien se puede encontrar la abstracción en la clase "Persona", de la cual heredan "Pasajero" y "Usuario".
Otro tema que se encuentra presente es el encapsulamiento, sobre todo en la clase "Estadistica".
Todos los atributos de cada entidad posee su respectiva propiedad.
Por otra parte se utilizan diversos controles de Windows Forms para lograr un mejor desempeño y apariencia de la aplicacion.

## Sobre mí 
>Mi nombre es Santiago, tengo 20 años y estoy orgulloso de presentarles mi programa. Estoy muy conforme con como quedó, es muy intuitivo y organizado, ademas de que tiene una interfaz con un diseño simple y agradable. Aprendí mucho en el proceso sobre la utilizacion real de los temas vistos en clase, logrando comprenderlos totalmente.

## Propuesta de valor agregado para promocion
Se implementan en el programa funcionalidades como el uso de `manejo de excepciones` mediante `try/catch`, que a su vez esta incluido en una `clase generica` llamada "Serializacion", que recibe datos de tipo "Usuario", "Aeronave", "Viaje" y "Pasajero" a lo largo del programa, utilizada para serializar y deserializar en formato JSON y XML.

## Aclaraciones
No sera necesario la implementacion de ningun archivo de extension .json o .xml ya que el programa los contiene dentro de sus propios directorios.
