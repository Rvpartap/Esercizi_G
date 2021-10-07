Imports System

Module Program
    Dim raggio As Integer
    Dim area As Integer
    Dim perimetro As Integer
    Dim diametro As Integer
    Dim Pgreco As Integer = "3,14"
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Write("Inserisci il raggio del cerchio: ")
            raggio = Console.ReadLine
            Console.Clear()
            Call CalcolaCerchio()
            Console.WriteLine("Area: " & area)
            Console.WriteLine("Perimetro: " & perimetro)
            Console.WriteLine("Diametro: " & diametro)
            Console.ReadLine()
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
        End While
    End Sub
    Sub CalcolaCerchio()
        area = Pgreco * (raggio * raggio)
        perimetro = 2 * Pgreco * raggio
        diametro = 2 * raggio
    End Sub
End Module
