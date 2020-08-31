'86: Cargar Un vector de 15 elementos con números enteros. Emitir:
'a) El mínimo valor dentro del vector. 
'b) El máximo valor dentro del vector. 
'c) Cantidad de elementos cuyos índices sean mayores que el del índice del mínimo valor dentro del vector.
'd) La suma de los elementos cuyos índices sean menores que el del índice del máximo valor dentro del vector. 
'NOTA: En caso de que el máximo se repita tomar el que tenga el índice menor, y en caso de que el mínimo valor
'dentro del vector se repita, tomar el de índice mayor.

Module Module1

    Sub Main()
        Dim VEC(15) As Integer
        Dim Menor As Integer = Integer.MaxValue
        Dim Mayor As Integer = Integer.MinValue
        Dim IndiceMenorValor As Integer
        Dim IndiceMayorValor As Integer
        Dim Contador As Integer = 0
        Dim Suma As Integer = 0

        For I As Integer = 0 To 15
            Console.Write("Ingrese un número a posición {0}: ", I)
            VEC(I) = CInt(Console.ReadLine())
        Next
        For I As Integer = 0 To 15
            If VEC(I) <= Menor Then
                Menor = VEC(I)
                IndiceMenorValor = I
            End If
        Next
        For I As Integer = 0 To 15
            If VEC(I) > Mayor Then
                Mayor = VEC(I)
                IndiceMayorValor = I
            End If
        Next
        For I As Integer = IndiceMenorValor + 1 To 15
            Contador += 1
        Next
        For I As Integer = 0 To IndiceMayorValor - 1
            Suma += VEC(I)
        Next

        Console.WriteLine("El menor valor es: " & Menor)
        Console.WriteLine("El mayor valor es: " & Mayor)
        Console.WriteLine("La cuenta es: " & Contador)
        Console.WriteLine("La suma es: " & Suma)

        Console.ReadLine()
    End Sub

End Module
