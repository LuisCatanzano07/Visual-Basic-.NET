
'77:Cargar un vector de 15 elementos con números. Imprimir el lugar que ocupa el mínimo valor.
'Tener en cuenta que este puede aparecer repetido. En ese caso imprimir todos los lugares
'donde aparece ese valor. 
Module Module1
    Sub Main()
        Dim vec(15), k, vecmen() As Integer
        Dim MEN As Integer = Integer.MaxValue
        k = 0
        ReDim vecmen(0)
        vecmen(0) = 1
        For i As Integer = 0 To vec.GetUpperBound(0)
            Console.Write("Ingrese un número a la posición {0} del vector: ", i)
            vec(i) = CInt(Console.ReadLine())
        Next
        For i As Integer = 0 To vec.GetUpperBound(0)
            If vec(i) < MEN Then
                MEN = vec(i)
                ReDim vecmen(0)
                vecmen(0) = i
            Else
                If vec(i) = MEN Then
                    k += 1
                    ReDim Preserve vecmen(k)
                    vecmen(k) = i
                End If
            End If
        Next
        Console.WriteLine()
        Console.WriteLine("El menor es: " & MEN)
        Console.WriteLine("Aparece en la/s posición/es")
        For Each x As Integer In vecmen
            Console.WriteLine(x)
        Next
        Console.ReadLine()
    End Sub
End Module