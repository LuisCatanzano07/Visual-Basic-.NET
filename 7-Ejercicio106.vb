'106) ?Cargar un matriz de M x N elementos con números y realizar:
'106.1) Generar un vector con la sumatoria de cada fila.
'106.2) Generar un vector con la sumatoria de cada columna.
'106.3) Generar un vector con las posiciones de los mayores de cada fila.
'106.4) Generar un vector con las posiciones de los menores de cada columna.
'106.5) Generar un vector con el promedio de cada fila.
'106.6) Generar un vector con el promedio de cada columna.
'106.7) Generar un vector con los elementos de la fila k (siendo esta ingresada al comenzar).
'106.8) Generar un vector con todos los elementos que superen en valor absoluto al. promedio general de la matriz.
'106.9) Generar una matriz dinámica con las posiciones (fila y columna) de todos los elemen-tos que su valor absoluto 
'sea inferior al promedio de todos los elementos de la matriz.
Module Module1
    Sub Main()
        '106) ?Cargar un matriz de M x N elementos con números y realizar:
        '106.1) Generar un vector con la sumatoria de cada fila.
        '106.2) Generar un vector con la sumatoria de cada columna.
        '106.3) Generar un vector con las posiciones de los mayores de cada fila.
        '106.4) Generar un vector con las posiciones de los menores de cada columna.
        '106.5) Generar un vector con el promedio de cada fila.
        '106.6) Generar un vector con el promedio de cada columna.
        '106.7) Generar un vector con los elementos de la fila k (siendo esta ingresada al comenzar).
        '106.8) Generar un vector con todos los elementos que superen en valor absoluto al. promedio general de la matriz.
        '106.9) Generar una matriz dinámica con las posiciones (fila y columna) de todos los elemen-tos que su valor absoluto 
        'sea inferior al promedio de todos los elementos de la matriz.
        Console.WriteLine("         Ejercicio 106       ")
        Dim MAT106(0, 0), Vec106SuColu(0), Vec106SuFila(0), Vec106PosMayFil(0), Vec106PosMenCol(0), Vec106FilK(0), Vec106SupVAbsGrl(0), Vec106InfVAbsGrl(1, 0), L, M, I, J, K, A, B As Integer
        Dim Vec106ProFil(0), Vec106ProCol(0), PromGrl, PromGrl1, PromGrl2 As Double
        PromGrl = 0
        Do
            Console.WriteLine("ingrese la cantidad de filas de la matriz")
            L = CInt(Console.ReadLine())
        Loop Until L > 0
        Do
            Console.WriteLine("ingrese la cantidad de columnas de la matriz")
            M = CInt(Console.ReadLine())
        Loop Until M > 0
        Do
            Console.WriteLine("ingrese que fila que se genera")
            K = CInt(Console.ReadLine())
            If K > L Then
                Console.WriteLine("Element valor es mayor que la cantidad de filas o es un numero negativo vuelva a intentar")
            End If
        Loop Until K <= L And K > 0
        ReDim MAT106(L - 1, M - 1)
        For I = 0 To MAT106.GetUpperBound(0)
            For J = 0 To MAT106.GetUpperBound(1)
                Console.WriteLine("ingrese el valor para la pocicion {0} , {1} de la matriz ", (I + 1), (J + 1))
                MAT106(I, J) = CInt(Console.ReadLine())
            Next
        Next

        ReDim Vec106SuFila(MAT106.GetUpperBound(0))
        ReDim Vec106SuColu(MAT106.GetUpperBound(1))
        For I = 0 To MAT106.GetUpperBound(0)
            Vec106SuFila(I) = 0
            For J = 0 To MAT106.GetUpperBound(1)
                Vec106SuFila(I) = Vec106SuFila(I) + MAT106(I, J)
            Next
        Next
        For J = 0 To MAT106.GetUpperBound(1)
            Vec106SuColu(J) = 0
            For I = 0 To MAT106.GetUpperBound(0)
                Vec106SuColu(J) = Vec106SuColu(J) + MAT106(I, J)
            Next
        Next
        ReDim Vec106PosMayFil(MAT106.GetUpperBound(0))
        For I = 0 To MAT106.GetUpperBound(0)
            Vec106PosMayFil(I) = 0
            For J = 0 To MAT106.GetUpperBound(1)
                If MAT106(I, Vec106PosMayFil(I)) < MAT106(I, J) Then
                    Vec106PosMayFil(I) = J
                End If
            Next
            Vec106PosMayFil(I) = Vec106PosMayFil(I) + 1
        Next
        ReDim Vec106PosMenCol(MAT106.GetUpperBound(1))
        For J = 0 To MAT106.GetUpperBound(1)
            Vec106PosMenCol(J) = 0
            For I = 0 To MAT106.GetUpperBound(0)
                If (MAT106(Vec106PosMenCol(J), J) >= MAT106(I, J)) Then
                    Vec106PosMenCol(J) = I
                End If
            Next
            Vec106PosMenCol(J) = Vec106PosMenCol(J) + 1
        Next
        ReDim Vec106ProFil(MAT106.GetUpperBound(0))
        For I = 0 To MAT106.GetUpperBound(0)
            Vec106ProFil(I) = 0
            For J = 0 To MAT106.GetUpperBound(1)
                Vec106ProFil(I) = Vec106ProFil(I) + MAT106(I, J)
            Next
            Vec106ProFil(I) = (Vec106ProFil(I) / (J))
        Next

        ReDim Vec106ProCol(MAT106.GetUpperBound(1))
        For J = 0 To MAT106.GetUpperBound(1)
            Vec106ProCol(J) = 0
            For I = 0 To MAT106.GetUpperBound(0)
                Vec106ProCol(J) = Vec106ProCol(J) + MAT106(I, J)
            Next
            Vec106ProCol(J) = (Vec106ProCol(J) / (I))
        Next
        ReDim Vec106FilK(MAT106.GetUpperBound(1))
        For J = 0 To MAT106.GetUpperBound(1)
            Vec106FilK(J) = MAT106(K - 1, J)
        Next

        For I = 0 To MAT106.GetUpperBound(0)
            For J = 0 To MAT106.GetUpperBound(1)
                PromGrl = PromGrl + MAT106(I, J)
            Next
        Next
        PromGrl = (PromGrl / ((MAT106.GetUpperBound(1) + 1) * (MAT106.GetUpperBound(0) + 1)))
        For I = 0 To Vec106ProCol.GetUpperBound(0)
            PromGrl1 = PromGrl1 + Vec106ProCol(I)
        Next
        PromGrl1 = PromGrl1 / (Vec106ProCol.GetUpperBound(0) + 1)
        For I = 0 To Vec106ProFil.GetUpperBound(0)
            PromGrl2 = PromGrl2 + Vec106ProFil(I)
        Next
        PromGrl2 = PromGrl2 / (Vec106ProFil.GetUpperBound(0) + 1)
        B = 0
        For I = 0 To MAT106.GetUpperBound(0)
            For J = 0 To MAT106.GetUpperBound(1)
                A = MAT106(I, J)
                If A < 0 Then
                    A = A * (-1)
                End If
                If A > PromGrl Then
                    ReDim Preserve Vec106SupVAbsGrl(B)
                    Vec106SupVAbsGrl(B) = A
                    B = B + 1
                End If
            Next
        Next
        B = 0
        For I = 0 To MAT106.GetUpperBound(0)
            For J = 0 To MAT106.GetUpperBound(1)
                A = MAT106(I, J)
                If A < 0 Then
                    A = -A
                End If
                If A < PromGrl Then
                    ReDim Preserve Vec106InfVAbsGrl(1, B)
                    Vec106InfVAbsGrl(0, B) = I
                    Vec106InfVAbsGrl(1, B) = J
                    B = B + 1
                End If
            Next
        Next
        Console.WriteLine("la sumatoria de cada Fila son:")
        For I = 0 To Vec106SuFila.GetUpperBound(0)
            Console.WriteLine(Vec106SuFila(I))
        Next
        Console.WriteLine("la sumatoria de cada Columna son:")
        For I = 0 To Vec106SuColu.GetUpperBound(0)
            Console.WriteLine(Vec106SuColu(I))
        Next

        Console.WriteLine("las posiciones de los mayore de cada fila son ")
        For I = 0 To Vec106PosMayFil.GetUpperBound(0)
            Console.WriteLine(Vec106PosMayFil(I))
        Next
        Console.WriteLine("las posiciones de los menores de cada columna son ")
        For I = 0 To Vec106PosMenCol.GetUpperBound(0)
            Console.WriteLine(Vec106PosMenCol(I))
        Next
        Console.WriteLine("los valores promedios por fila son:")
        For I = 0 To Vec106ProFil.GetUpperBound(0)
            Console.WriteLine(Vec106ProFil(I))
        Next
        Console.WriteLine("los valores promedios por columna son:")
        For I = 0 To Vec106ProCol.GetUpperBound(0)
            Console.WriteLine(Vec106ProCol(I))
        Next
        Console.WriteLine("los valores de la fila {0} son: ", K)
        For I = 0 To Vec106FilK.GetUpperBound(0)
            Console.WriteLine(Vec106FilK(I))
        Next
        Console.WriteLine("el promedio general de la matriz es : {0}", PromGrl)
        Console.WriteLine("el promedio general de la matriz calculado por el promedio de las columnas es : {0}", PromGrl1)
        Console.WriteLine("el promedio general de la matriz calculado por el promedio de las filas es : {0}", PromGrl2)
        Console.WriteLine("los valores absolutos superiores al promedio general de la matriz son: ")
        For I = 0 To Vec106SupVAbsGrl.GetUpperBound(0)
            Console.WriteLine(Vec106SupVAbsGrl(I))
        Next
        Console.WriteLine("las pociciones con los valores absolutos menores al promedio general de la matriz son : ")
        For I = 0 To Vec106InfVAbsGrl.GetUpperBound(1)
            Console.WriteLine("Fila {0}, Columna {1} ", Vec106InfVAbsGrl(0, I) + 1, Vec106InfVAbsGrl(1, I) + 1)
        Next
        Console.ReadLine()
    End Sub
End Module

