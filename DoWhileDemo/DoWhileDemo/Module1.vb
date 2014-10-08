Option Strict On

Module Module1

    Sub Main()
        Dim num As Integer = 1

        Do While num <= 7
            'if we were to add num=10 here, it will still complete 1 loop and then end because num=11 which is >7 

            If num > 5 Then
                Exit Do
            End If
            'when num=5, it will exit the loop 
            'if num=num+1 was written before Console.WriteLine then num=6 will allow exit from loop
            Console.WriteLine(" " & num)
            num = num + 1
        Loop
        'if we write the Console.WriteLine here, then num would be 8 because the only way it could leave the loop 
        'would be if it was >7 
    End Sub

End Module
