'Con los datos de una lista que contiene nombre, numero de legajo y sueldo de cada uno de los empleados de una empresa,
' realizar las siguientes operaciones. Esta firma contiene como máximo MIL empleados. 
'1) Cargar todos los datos de esta lista en los vectores NOM, LEG, SUE respectivamente. 
'2) Luego de cargarlos en los vectores, listar todos los nombres de los empleados con número de legajo impar. 
'3) Emitir un listado de todos aquellos empleados que perciban un sueldo inferior al sueldo promedio pagado por la firma.
'4) Indicar el número de orden en la lista (posición que ocupan en el vector) de todos aquellos empleados cuyo legajo, sea par.
'5) Imprimir un listado de todos aquellos empleados cuya posición en el vector sea impar (número de orden en la lectura). 

Module Module1

    Sub Main()
        Dim vecleg(), vecsue(), Leg, Sue, T, Sumasueldos, ContadosSueldos As Integer
        Dim vecnom(), Nom, Continua As String
        Dim Pares, Impares, PosicionesImpares, PromSueldos As Double
        ReDim vecnom(0)
        vecnom(0) = "null"
        ReDim vecleg(0)
        vecleg(0) = 1
        ReDim vecsue(0)
        vecsue(0) = 1
        T = 0
        Nom = "NULL"
        Sumasueldos = 0
        PromSueldos = 0
        ContadosSueldos = 0
        Do
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Do
                Console.Write("Ingrese un número de legajo para la posición " & T + 1 & " del la lista:  ", Leg)
                Leg = CInt(Console.ReadLine())
                If Leg > 0 Then
                    ReDim Preserve vecleg(T)
                    vecleg(T) = Leg

                Else Console.Write("Número de legajo incorrecto. ")
                End If
            Loop Until Leg > 0

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Do
                Console.Write("Ingrese un nombre:  ", Nom)
                Nom = Console.ReadLine()
                ReDim Preserve vecnom(T)
                vecnom(T) = Nom
            Loop Until Nom <> ""
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Do
                Console.Write("Ingrese un sueldo:  ", Sue)
                Sue = CInt(Console.ReadLine())
                If Sue > 0 Then
                    ReDim Preserve vecsue(T)
                    vecsue(T) = Sue
                    Sumasueldos += Sue
                    ContadosSueldos += 1
                Else Console.WriteLine("Sueldo incorrecto, ingrese un número valido:  ")
                End If
            Loop Until Sue > 0
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Console.Write("¿Desea ingresar información de un nuevo empleado? S/N: ")
            Continua = Console.ReadLine
            While Continua.ToUpper <> "S" And Continua.ToUpper <> "N"
                Console.Write("Ingrese una respuesta correcta: ")
                Continua = Console.ReadLine
            End While
            If Continua.ToUpper = "S" Then
                T += 1
            End If
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''")

        Loop Until Continua.ToUpper = "N" Or T > 1000
        Console.WriteLine("''''''''''HA INGRESADO EL NÚMERO MÁXIMO DE EMPLEADOS O HA DECIDIDO DEJAR DE INGRESAR DATOS''''''''''")
        Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''")
        Console.WriteLine("Los nombres de los legajos impares son: ")
        For i As Integer = 0 To vecleg.GetUpperBound(0)
            Impares = Math.Truncate((vecleg(i)) / 2)
            If Impares * 2 <> (vecleg(i)) Then
                Console.WriteLine(vecnom(i))
            End If
        Next
        PromSueldos = Sumasueldos / ContadosSueldos
        Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''")
        Console.WriteLine("Los empleados con un sueldo inferior al promedio $ " & PromSueldos & " son: ")
        For i As Integer = 0 To vecsue.GetUpperBound(0)
            If vecsue(i) < PromSueldos Then
                Console.WriteLine(vecnom(i))
            End If
        Next
        Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''")
        Console.WriteLine("Las posiciones de los empleados con legajo par son: ")
        For i As Integer = 0 To vecleg.GetUpperBound(0)
            Pares = Math.Truncate((vecleg(i)) / 2)
            If Pares * 2 = (vecleg(i)) Then
                Console.WriteLine(i + 1)
            End If
        Next
        Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''")
        Console.WriteLine("Los empleados con posición impar en la lista son : ")
        For i As Integer = 0 To vecleg.GetUpperBound(0)
            PosicionesImpares = Math.Truncate((i + 1) / 2)
            If PosicionesImpares * 2 <> (i + 1) Then
                Console.WriteLine(vecnom(i))
            End If
        Next
        Console.ReadLine()

    End Sub

End Module
