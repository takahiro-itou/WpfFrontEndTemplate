
Namespace Global.ViewVb.Models

Public Class SampleModel


Private m_resultText As String

Public Property ResultText() As String
   Get
       Return  Me.m_resultText
   End Get
   Set(ByVal value As Strign)
       Me.m_resultText = value
   End Set
End Property


Public Overridable Function runTask(
        ByVal progress As IProgress(Of Integer) ) As Integer
''--------------------------------------------------------------------
''    モデルのタスクを実行する。
''--------------------------------------------------------------------
    executeCommand()
    runTask = 0
End Function


Protected Overridable Sub executeCommand()
''--------------------------------------------------------------------
''    指定したコマンドを実行する
''--------------------------------------------------------------------
    Me.ResultText = "Hello, World"
    System.Threading.Thread.Sleep(5000);
End Sub


End Class

End Namespace
