'60:Ingresar 25 valores. 
'Imprimir al final la suma de los 12 primeros, el más chicos de los 6 siguientes,
'la suma y el promedio de los últimos y la suma total de todos los números ingresados. 
'Imprimir también el valor del mayor de todos los números.
Module Module1
    Sub Main()
        Dim num, i, sum12, chico, mayor, sumtot, sumult As Integer
        Dim pro As Double
        'ASIGNO EL MAYOR VALOR POSIBLE A LA VARIABLE chico
        chico = Integer.MaxValue
        'ASIGNO EL MENOR VALOR POSIBLE A LA VARIABLE mayor
        mayor = Integer.MinValue
        For i = 1 To 25
            Console.Write("Ingrese el {0}º número: ", i)
            num = CInt(Console.ReadLine())
            sumtot += num
            If num > mayor Then
                mayor = num
            End If
            If i <= 12 Then
                sum12 += num
            ElseIf i < 19 Then
                If num < chico Then
                    chico = num
                End If
            Else
                sumult += num
            End If
        Next
        pro = sumult / 7
        Console.WriteLine()
        Console.WriteLine("RESULTADOS")
        Console.WriteLine()
        Console.WriteLine("La suma de los 12 primeros es: " & sum12)
        Console.WriteLine("El más chico de los 6 siguientes es: " & chico)
        Console.WriteLine("La suma de los últimos es: " & sumult)
        Console.WriteLine("El promedio de los últimos es: " & System.Math.Round(pro, 2))
        Console.WriteLine("La suma de todos los números ingresados es: " & sumtot)
        Console.ReadLine()
    End Sub
End Module