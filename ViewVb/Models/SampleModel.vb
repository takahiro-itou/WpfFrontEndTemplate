
Imports System


Namespace Global.ViewVb.Models

Public Class SampleModel


Private m_resultText As String

Public Property ResultText() As String
   Get
       Return  Me.m_resultText
   End Get
   Set(ByVal value As String)
       Me.m_resultText = value
   End Set
End Property


Public Overridable Function executeCommand(
        ByVal progress As IProgress(Of Integer) ) As Integer
''--------------------------------------------------------------------
''    モデルのタスクを実行する。
''--------------------------------------------------------------------
Dim i As Integer
Dim output As String

    output = "Hello, World"

    For i = 1 To Len(output)
        Me.ResultText = Me.ResultText & Mid(output, i, 1)
        progress.Report(0)
        System.Threading.Thread.Sleep(1000)
    Next i

    progress.Report(100)
    runTask = 0
End Function


End Class

End Namespace
