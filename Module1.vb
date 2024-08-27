Imports System.Data.Odbc

Module Module1

    Sub Main()
        Dim pilih As String
        Dim ganjil As Integer

        Dim genap As Integer = 52

        Console.Write("Silahkan pilih (for/while/dowhile): ")
        pilih = Console.ReadLine

        'ganjil ascend
        If pilih = "for" Or pilih = "f" Then
            For ganjil = 1 To 50 Step 2
                Console.WriteLine("Angka ke: " & ganjil)
            Next ganjil

            'genap descend
        ElseIf pilih = "do" Or pilih = "dowhile" Then
            Do While genap > 2
                genap -= 2
                Console.WriteLine("Angka yang muncul: " & genap)
            Loop

            'bintang
        ElseIf pilih = "while" Or pilih = "w" Then
            Dim jml As Integer = 1
            While jml <= 10
                Dim bint As Integer = 1
                While bint <= jml
                    Console.Write("*")
                    bint += 1
                End While
                Console.WriteLine()
                jml += 1
            End While
        End If

        Console.ReadKey()
    End Sub

End Module
