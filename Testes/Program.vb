Imports System

Module Program

    Public raio As Decimal
    Public perime As Decimal
    Public area As Decimal
    Public Const pi As Decimal = 3.1415
    Dim ide As String



    Sub CalcArea()
        area = pi * raio ^ 2
    End Sub

    Sub CalcPeri()
        perime = 2 * pi * raio
    End Sub

    Sub CalcDiame()
        area = pi * raio ^ 2
    End Sub

    Sub Main()

        Console.WriteLine("Qual operação você gostaria de fazer?")
        Console.WriteLine($"1 - Área do Círculo{vbCrLf}" &
                          $"2 - Perímetro do Círculo{vbCrLf}" &
                          $"3 - Ambos")

        ide = Console.ReadLine()

        Do
            Try

                If ide = 1 Then
                    Console.WriteLine("Digite o raio do círculo")
                    raio = Console.ReadLine()
                    CalcArea()
                    Console.WriteLine($"Sua área é: {area}")

                    Console.WriteLine("Pressione qualquer tecla...")
                    Console.ReadKey()

                    End

                ElseIf ide = 2 Then
                    Console.WriteLine("Digite o raio do círculo")
                    raio = Console.ReadLine()
                    CalcPeri()
                    Console.WriteLine($"Seu perímetro é: {perime}")

                    Console.WriteLine("Pressione qualquer tecla...")
                    Console.ReadKey()

                    End

                ElseIf ide = 3 Then
                    Console.WriteLine("Digite o raio do círculo")
                    raio = Console.ReadLine()
                    CalcPeri()
                    CalcArea()
                    Console.WriteLine($"Seu perímetro é: {perime}{vbCrLf}Sua área é: {area}")

                    Console.WriteLine("Pressione qualquer tecla...")
                    Console.ReadKey()

                    End

                Else
                    Console.WriteLine("Entrada inválida")
                    ide = Console.ReadLine()
                End If

            Catch

                Console.WriteLine("Entrada inválida")
                ide = Console.ReadLine()

            End Try


        Loop


    End Sub





End Module
