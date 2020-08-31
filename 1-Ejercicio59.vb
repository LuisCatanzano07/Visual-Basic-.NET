'59:Ingresar pares de valores enteros, si el primer número es negativo, se debe sumar el segundo a un acumulador.
'Si el primer número es múltiplo de 5, se debe acumular en otro lado el cuadrado del segundo número y
'si el primer número es primo, se debe acumular la raíz cuadrada del cubo del segundo número.
'Imprimir resultados. 
Module Module1
    Sub Main()
        Dim primero, segundo, sumneg, mult, sumcuad, sen, i, mitad As Integer
        Dim sumraiz As Double
        Dim sino As String
        Do
            Console.Write("Ingrese el primer número: ")
            primero = CInt(Console.ReadLine())
            Console.Write("Ingrese el segundo número: ")
            segundo = CInt(Console.ReadLine())
            If primero < 0 Then
                sumneg += segundo
            Else
                mult = primero Mod 5
                If mult = 0 Then
                    sumcuad = sumcuad + CInt(segundo ^ 2)
                Else
                    i = 2
                    sen = 0
                    mitad = primero \ 2
                    While i < mitad
                        mult = primero Mod i
                        If mult = 0 Then
                            sen = 1
                            Exit While
                        End If
                        i += 1
                    End While
                    If sen = 0 Then
                        sumraiz = sumraiz + System.Math.Sqrt(segundo ^ 3)
                    End If
                End If
            End If
            Console.WriteLine()
            Console.Write("Continua S/N: ")
            sino = Console.ReadLine
            Console.WriteLine()
        Loop Until sino.ToUpper = "N"
        Console.WriteLine()
        Console.WriteLine("Suma si el primero es negativo: " & sumneg)
        Console.WriteLine("Suma si el primero es multiplo de 5: " & sumcuad)
        Console.WriteLine("Suma si el primero es primo: " & sumraiz)
        Console.ReadLine()
    End Sub
End Module