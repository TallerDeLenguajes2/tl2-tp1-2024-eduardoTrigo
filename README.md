### Respuestas
## Punto 2
# Relaciones
-La relacion  entre `Pedidos` `Clientes` se realiza por composicion ya que el pedido no existiria sin la existencia del cliente ***el pedido es parte del cliente***

-la relacion entre `Pedidos` `Cadete` se realiza por agregacion porque el pedido no depende de la existencia del cadete . ***el cadete tiene pedidos***

-la relacion entre `Cadete` `Cadeteria` se realiza por composicion porque el cadete esta contenido dentro de cadeteria ***el cadete es parte de la cadeteria***

# Metodos
-metodos que deberia tener la clase cadeteria pueden ser:
    `agregarCadete` que permite agregar cadetes a la listaCadetes.
    `mostrarCadetes` muestra el listado de cadetes.
    `eliminarCadete` elimina de la lista un cadete.

--metodos que deberia tener un clase cadete:
    `asignarPedido` Agrega pedidos a la ListadoPedidos 
    `quitarPedido` saca de la lista un pedido.
    `crearCadete` donde se cargan los datos a la clase cadete ( Nombre , Direccion, Telefono).
    `calcularJornal` calcula el jornalACobrar.
    `mostrarDatos`