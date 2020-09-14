'Luis Torres
'RCET0265
'spring 2020
'Accumulate Messages Function
'https://github.com/LuisTorres0419/AccumulateMessagesFunction.git

Option Strict On
Option Explicit On
Option Compare Text

Module AccumulateMessagesFunction

    Sub Main()
        Dim userInput As String
        Dim message As String
        Dim clearData As Boolean

        Console.WriteLine($"enter messages and they enter summon to store  or delet to delet messege")

        Do
            userInput = Console.ReadLine()
            If userInput = "summon" Then
                MsgBox(message)
            ElseIf userInput = "delet" Then
                clearData = True
            End If

            message = AccumulateMessage(userInput, clearData)

            clearData = False

        Loop
    End Sub

    Function AccumulateMessage(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static userMessage As String
        If clear = True Then
            userMessage = ""
        ElseIf newMessage = "summon" Then
        Else
            userMessage &= newMessage & vbNewLine
        End If

        Return userMessage

    End Function

End Module
