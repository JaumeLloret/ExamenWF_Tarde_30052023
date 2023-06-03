# Examen Windows Forms Tarde
Crea una aplicación de gestión de jugadores de baloncesto con los siguientes requisitos:

1. Debes utilizar al menos tres formularios diferentes: uno para ingresar nuevos jugadores, otro para mostrar la lista de jugadores y un tercero para mostrar detalles específicos de un jugador seleccionado.
2. En el formulario de ingreso de jugadores, se deben solicitar los siguientes datos al usuario:
    -   Nombre completo del jugador (TextBox)
    -   Posición en el equipo (ComboBox)
    -   Altura del jugador (MaskedTextBox con validación numérica)
    -   Equipo al que pertenece (TextBox)
3. Debes implementar una clase abstracta llamada  `Jugador`  que contenga propiedades para el nombre completo, posición y altura del jugador. Además, esta clase debe tener una propiedad abstracta llamada  `Equipo`  de tipo  `string`.
4. Crea una clase concreta llamada  `JugadorEstrella`  que herede de la clase abstracta  `Jugador`. Esta clase debe tener una propiedad adicional llamada  `PuntosPorPartido`  de tipo  `double`, que representa los puntos promedio que el jugador anota por partido.
5. En el formulario de lista de jugadores, muestra la información básica de todos los jugadores ingresados (nombre, posición y altura). Utiliza un control **ListBox** o **ListView** para mostrar los datos en un formato legible. Al seleccionar un jugador de la lista, se debe abrir el formulario de detalles del jugador.
6.  En el formulario de detalles del jugador, muestra toda la información del jugador seleccionado, incluyendo su equipo y puntos por partido. Utiliza controles de etiqueta (**Label**), cuadro de texto (**TextBox**), lista desplegable (**ComboBox**) y un control **ListBox** o **ListView** para mostrar los datos del jugador.

Asegúrate de utilizar componentes de validación adecuados para los campos obligatorios y formatos de entrada correctos. Por ejemplo, el nombre del jugador no debe estar vacío, la altura debe ser un número válido, etc.

Evalúa la correcta implementación de la herencia utilizando una clase abstracta y una clase concreta.
    
Valora la utilización adecuada de los controles y componentes requeridos, como etiquetas, cuadros de te
