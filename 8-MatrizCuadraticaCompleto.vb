'1) Cargar una matriz de 4 x 4 elementos con número enteros e imprimir en este orden los siguientes elementos.
'a) Los elementos que se encuentran en la diagonal principal.
'b) Los elementos que se encuentran por encima de la diagonal principal.
'c) Los elementos que se encuentran por debajo de la diagonal principal.
'd) Los elementos que se encuentran en la diagonal secundaria (contradiagonal).
'e) Los elementos que se encuentran por encima de la diagonal secundaria (contradiagonal).
'f) Los elementos que se encuentran por debajo de la diagonal secundaria (contradiagonal)

Module MatrizCuadraticaCompleto

    Sub Main()
        Dim mat(3, 3) As Integer
        Dim I, j As Integer
        For I = 0 To 3
            For j = 0 To 3
                Console.WriteLine("INGRESE UN NRO fila {0} columna {1}: ", I, j)
                mat(I, j) = CInt(Console.ReadLine())
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Elementos de la diagonal principal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I = j Then
                    Console.WriteLine(mat(I, I))
                End If
            Next

        Next
        Console.WriteLine()
        Console.WriteLine("Elementos encima de la diagonal principal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I < j Then
                    Console.WriteLine(mat(I, j))
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Elementos debajo de la diagonal principal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I > j Then
                    Console.WriteLine(mat(I, j))
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Elementos de la contradiagonal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I + j = mat.GetLength(0) Then
                    Console.WriteLine(mat(I, j))
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Elementos encima de la contradiagonal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I + j < mat.GetLength(0) Then
                    Console.WriteLine(mat(I, j))
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Elementos debajo de la contradiagonal")
        Console.WriteLine()
        For I = 0 To 3
            For j = 0 To 3
                If I + j > mat.GetLength(0) Then
                    Console.WriteLine(mat(I, j))
                End If
            Next
        Next
        Console.WriteLine("prueba")
        For I = 0 To 3
            For j = 0 To 3

                Console.WriteLine(I + j)

            Next
        Next
        Console.ReadLine()
    End Sub

End Module
