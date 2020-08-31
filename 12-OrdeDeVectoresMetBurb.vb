'Cargar un vector con 10 números enteros y luego ordenarlo de menor a mayor.
'Imprimir el vector ordenado.
Module Module1
    Sub Main()
        Dim vec(9), aux As Integer
        Console.WriteLine("Carga del Vector")
        Console.WriteLine()
        For i = 0 To UBound(vec)
            Console.Write("Ingrese en elemento {0} un nro: ", i)
            vec(i) = CInt(Console.ReadLine)
        Next
        'ordenando utilizando el método de la burbuja
        For i = 0 To 8
            For j = 0 To 8 - i
                If vec(j) > vec(j + 1) Then
                    aux = vec(j)
                    vec(j) = vec(j + 1)
                    vec(j + 1) = aux
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("mostrando Vector")
        Console.WriteLine()
        For i = 0 To 9
            Console.WriteLine("Elemento {0} valor: {1}", i, vec(i))
        Next
        Console.ReadLine()
    End Sub
End Module