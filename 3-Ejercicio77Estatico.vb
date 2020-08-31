
'77:Cargar un vector de 15 elementos con números. Imprimir el lugar que ocupa el mínimo valor.
'Tener en cuenta que este puede aparecer repetido. En ese caso imprimir todos los lugares
'donde aparece ese valor. 
Module Module1
    Sub Main()
        Dim vec(15) As Integer
        Dim MEN As Integer = Integer.MaxValue
        For i As Integer = 0 To vec.GetUpperBound(0)
            Console.Write("Ingrese un número a la posición {0} del vector: ", i)
            vec(i) = CInt(Console.ReadLine())
        Next
        For Each k As Integer In vec
            If k < MEN Then
                MEN = k
            End If
        Next
        Console.WriteLine()
        Console.WriteLine("El menor es: " & MEN)
        Console.WriteLine("Aparece en la/s posición/es")
        For i As Integer = 0 To vec.GetUpperBound(0)
            If MEN = vec(i) Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadLine()
    End Sub
End Module