Resumen del Proyecto

El proyecto consiste en una aplicación desarrollada en Windows Forms (WinForms) utilizando C#. Su propósito es gestionar los pedidos de una cafetería, permitiendo a los usuarios agregar, visualizar y procesar pedidos en tiempo real. Esta aplicación emplea listas genéricas (List<T>) para almacenar y manejar los datos de los pedidos, así como controles de interfaz de usuario para la interacción con los usuarios.

Características Principales

Agregar Pedidos:

Los usuarios pueden ingresar el nombre del cliente, el producto y la cantidad solicitada.

Los datos ingresados se validan para asegurar que no estén vacíos o mal formateados.

Los pedidos se almacenan en una lista de objetos de la clase Cafeteria.

Procesar Pedidos:

Permite procesar el primer pedido en la lista (FIFO: First In, First Out).

El pedido procesado se elimina de la lista y se notifica al usuario.

Visualizar Pedidos:

Los pedidos pendientes se muestran en un control DataGridView, actualizado dinámicamente al agregar o procesar un pedido.

Componentes Principales

Clases

Clase Cafeteria:
Representa un pedido individual con las siguientes propiedades:

Cliente: Nombre del cliente que realizó el pedido.

Producto: Producto solicitado por el cliente.

Cantidad: Cantidad del producto solicitado.

Constructor:

Inicializa un pedido con los datos proporcionados.

Clase ListaPedidos:
Maneja la colección de pedidos mediante una lista genérica:

Método AgregarPedido: Agrega un nuevo pedido a la lista.

Método ProcesarPedido: Procesa y elimina el primer pedido en la lista.

Método ObtenerPedidos: Devuelve una copia de la lista de pedidos.

Formulario Principal (Form1)

Campos:

List<Cafeteria> pedidos: Lista que almacena los pedidos pendientes.

Métodos y Eventos:

btnAgregarPedido_Click:

Captura los datos ingresados por el usuario y valida que sean válidos.

Crea un nuevo objeto Cafeteria y lo agrega a la lista.

Actualiza el control DataGridView para reflejar los nuevos pedidos.

btnProcesarPedido_Click:

Procesa el primer pedido en la lista y lo elimina.

Notifica al usuario sobre el pedido procesado.

Actualiza el DataGridView.

ActualizarListaPedidos:

Refresca el contenido del DataGridView.

LimpiarCampos:

Limpia los campos de texto para facilitar la entrada de nuevos pedidos.

Tecnologías Utilizadas

C# y .NET Framework:

Manejo de listas genéricas.

Programación orientada a eventos.

Windows Forms (WinForms):

Controles como DataGridView, TextBox, y Button.

Eventos de clic para interacción del usuario.

Uso de GitHub

El proyecto puede beneficiarse de GitHub para:

Control de versiones: Permite realizar seguimiento de cambios en el código.

Colaboración: Facilita el trabajo en equipo y la revisión de código.

Documentación: Utilizar el archivo README.md para describir el proyecto y su uso.
