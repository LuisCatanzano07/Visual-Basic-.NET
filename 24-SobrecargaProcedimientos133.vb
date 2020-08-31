'Sin embargo, esta solución nos obliga a tener que saber varios nombres de procedimiento, con lo que tampoco
'ayuda mucho a simplificar el código.
'¿No sería ideal, disponer de un único nombre de procedimiento y que este fuera lo suficientemente inteligente
'para mostrar los datos adecuados en cada caso?, pues esta característica está implementada en VB.NET a través
'de la sobrecarga de procedimientos. La sobrecarga de procedimientos es una técnica que consiste en crear varias
'versiones de un mismo procedimiento, distinguiéndose entre sí por la lista de parámetros o protocolo de llamada
'del procedimiento.

Module Module1
    Sub Main()
        Dim Dias As Integer
        ' mostrar datos del empleado según nombre
        VerEmpleado("Pedro")
        ' mostrar datos del empleado según edad
        Dias = VerEmpleado(28)
        Console.WriteLine("Días libres del empleado: {0}", Dias)
        Console.WriteLine()
        ' mostrar salario pasando las horas trabajadas
        VerEmpleado(25, 80)
        Console.ReadLine()
    End Sub
    Sub VerEmpleado(ByVal Nombre As String)
        Console.WriteLine("Datos empleado por nombre")
        Console.WriteLine("Nombre del empleado: {0}", Nombre)
        Console.WriteLine("Domicilio: La Rioja 1450")
        Console.WriteLine("Localidad: Córdoba")
        Console.WriteLine()
    End Sub
    Function VerEmpleado(ByVal Edad As Integer) As Integer
        Dim DiasLibres As Integer
        Console.WriteLine("Datos empleado por edad")
        Console.WriteLine("Edad del empleado: {0}", Edad)
        Console.WriteLine("DNI:21555666")
        Console.WriteLine("Fecha de alta en la empresa: 10/4/1997")
        Console.WriteLine()
        DiasLibres = 5
        Return DiasLibres
    End Function
    Sub VerEmpleado(ByVal PrecioHora As Integer, ByVal HorasTrabajadas As Long)
        Dim Salario As Long
        Salario = PrecioHora * HorasTrabajadas
        Console.WriteLine("Salario según horas: {0}", Salario)
        Console.WriteLine()
    End Sub
End Module
'En este código hemos creado tres versiones sobrecargadas del procedimiento VerEmpleado( ). En una mostramos
'los datos del empleado según el nombre; en otra también mostramos otro conjunto de datos según la edad y
'además, al ser una función, devolvemos el número de días libres del empleado; trabajadas, que pasamos al
'protocolo de llamada. Desde Main( ) por lo tanto, siempre llamamos al procedimiento VerEmpleado( ).