Module Module1

    Sub Main()
        Dim continuar As String = "s"
        While continuar = "s"
            Console.WriteLine("::.. MENU ..::")
            Console.WriteLine("1. Calcular la Edad y determinar si es mayor o no de edad.")
            Console.WriteLine("2. Determinar si un numero es positivo o negativo.")
            Console.WriteLine("3. Calcular descuento de acuerdo al monto de compra.")
            Console.WriteLine("4. Calcular la suma de los números naturales desde 1 hasta n.")
            Console.WriteLine("5. Las tabla de multiplicar de los números.")
            Console.WriteLine("6. Salir.")
            Console.Write("Opcion: ")
            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()
            Select Case opcion
                Case 1
                    edad()
                Case 2
                    PosorNeg()
                Case 3
                    Desc()
                Case 4
                    Sumadenum()
                Case 5
                    tablaMultiplicar()
                Case Else
                    continuar = "n"
            End Select
        End While
    End Sub
    Sub edad()
        Console.WriteLine("Ingrese su edad:")
        Dim edad As Integer = Convert.ToInt32(Console.ReadLine())

        If edad >= 18 Then
            Console.WriteLine("Es mayor de edad.")
        Else
            Console.WriteLine("Es menor de edad.")
        End If

    End Sub
    Sub tablaMultiplicar()
        Console.Write("Tabla del: ")
        Dim i = 0, ntabla As Integer = Console.ReadLine()

        For i = 1 To 10 Step 1
            Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i)
        Next
    End Sub
    Sub PosorNeg()
        Console.WriteLine("Ingrese un número:")
        Dim numero As Double = Convert.ToDouble(Console.ReadLine())

        If numero > 0 Then
            Console.WriteLine("El número es positivo.")
        ElseIf numero < 0 Then
            Console.WriteLine("El número es negativo.")
        Else
            Console.WriteLine("El número es cero.")
        End If

    End Sub
    Sub Desc()
        Console.WriteLine("Ingrese el monto de la compra:")
        Dim montoCompra As Double = Convert.ToDouble(Console.ReadLine())
        Dim descuento As Double = 0

        If montoCompra >= 1000 Then
            descuento = 0.3 ' 30% de descuento
        ElseIf montoCompra >= 500 Then
            descuento = 0.2 ' 20% de descuento
        ElseIf montoCompra >= 250 Then
            descuento = 0.1 ' 10% de descuento
        Else
            descuento = 0.05 ' 5% de descuento para otras cantidades
        End If

        Dim montoDescuento As Double = montoCompra * descuento
        Dim totalPagar As Double = montoCompra - montoDescuento

        Console.WriteLine("Descuento aplicado: " & FormatPercent(descuento, 0))
        Console.WriteLine("Monto del descuento: " & FormatCurrency(montoDescuento))
        Console.WriteLine("Total a pagar: " & FormatCurrency(totalPagar))

    End Sub
    Sub Sumadenum()
        Console.WriteLine("Ingrese un número entero positivo (n):")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())

        Dim suma As Integer = 0

        For i As Integer = 1 To n
            suma += i
        Next

        Console.WriteLine("La suma de los números naturales desde 1 hasta " & n & " es: " & suma)
    End Sub
    Function determinarParImpar(ByVal num As Integer, ByVal i As Integer)
        Return num Mod i = 0
    End Function
End Module
