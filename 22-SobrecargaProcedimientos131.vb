'Si bien el uso de parámetros opcionales es un medio para ahorrar al programador el paso de los mismos en
'situaciones en las que no son necesarios, resulta una solución un tanto artificiosa, ya que lo que realmente hace es
'complicar más que facilitar la escritura de código.
'VB.NET aporta al lenguaje una nueva técnica que permite obviar el uso de parámetros opcionales por una
'solución más elegante y flexible: los procedimientos sobrecargados.
'Antes de explicar en qué consiste un procedimiento sobrecargado, situémonos en el siguiente escenario:
'Necesitamos mostrar los datos de un empleado de dos formas, en función del modo de consulta. Por un lado
'visualizaríamos su nombre, domicilio y localidad; y por otra parte su edad, DNI y fecha de alta en la empresa.
'Con lo que sabemos hasta el momento, podríamos resolver este problema escribiendo un procedimiento con
'parámetros opcionales, y según pasáramos un valor u otro, mostrar la información correspondiente.
'El Código fuente 131 muestra este modo de resolver el problema.
Module Module1
    Sub Main()
        ' mostrar datos del empleado
        ' en función del nombre
        VerDatosEmpleado("Pedro")
        ' mostrar datos del empleado
        ' en función de la edad
        VerDatosEmpleado(, 28)
        Console.ReadLine()
    End Sub
    Sub VerDatosEmpleado(Optional ByVal Nombre As String = "X", Optional ByVal Edad As Integer = 999)
        If Nombre <> "X" Then
            Console.WriteLine("Nombre del empleado: {0}", Nombre)
            Console.WriteLine("Domicilio: La Rioja 1450")
            Console.WriteLine("Localidad: Córdoba")
        End If
        If Edad <> 999 Then
            Console.WriteLine("Edad del empleado: {0}", Edad)
            Console.WriteLine("DNI:21555666")
            Console.WriteLine("Fecha de alta en la empresa: 10/4/1997")
        End If
        Console.WriteLine()
    End Sub
End Module