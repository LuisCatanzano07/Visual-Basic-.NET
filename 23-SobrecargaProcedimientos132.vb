'El uso de parámetros opcionales, como acabamos de constatar, resulta engorroso, ya que nos obliga a comprobar
'qué valor ha sido pasado y mostrar los datos correspondientes en consecuencia. Tenemos además, un
'inconveniente añadido, y es que podemos pasar los dos parámetros a la vez, con lo que se mostrarían todos los
'datos, cuando lo que queremos es visualizar un grupo u otro en cada llamada.
'Una aproximación diferente al problema sería escribir dos procedimientos distintos, y llamar a uno u otro según
'los datos que necesitemos. Ver Código fuente 132.
Module Module1
    Sub Main()
        ' mostrar datos del empleado según nombre
        VerEmpleNombre("Pedro")
        ' mostrar datos del empleado según edad
        VerEmpleNum(28)
        Console.ReadLine()
    End Sub
    Public Sub VerEmpleNombre(ByVal Nombre As String)
        Console.WriteLine("Datos empleado por nombre")
        Console.WriteLine("Nombre del empleado: {0}", Nombre)
        Console.WriteLine("Domicilio: La Rioja 1450")
        Console.WriteLine("Localidad: Córdoba")
        Console.WriteLine()
    End Sub
    Public Sub VerEmpleNum(ByVal Edad As Integer)
        Console.WriteLine("Datos empleado por edad")
        Console.WriteLine("Edad del empleado: {0}", Edad)
        Console.WriteLine("DNI:21555666")
        Console.WriteLine("Fecha de alta en la empresa: 10/4/1997")
        Console.WriteLine()
    End Sub
End Module