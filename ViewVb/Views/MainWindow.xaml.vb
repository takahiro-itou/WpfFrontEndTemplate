
Namespace Global.ViewVb.Views

Public Class MainWindow

Private m_taskModel As Models.SampleModel
Private m_viewModel As ViewModels.SampleViewModel


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()

    Me.m_taskModel = New Models.SampleModel()
    Me.m_viewModel = New ViewModels.SampleViewModel(Me.m_taskModel)

    Me.DataContext = Me.m_viewModel
End Sub


Private Sub runCommand(ByVal command As String)
''--------------------------------------------------------------------
''    指定したコマンドを実行する。
''--------------------------------------------------------------------

    Using process As New System.Diagnostics.Process()
        process.StartInfo.FileName = "ipconfig.exe"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardInput = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = False
        process.Start()

        Dim Reader As System.IO.StreamReader = process.StandardOutput
        Dim output As String = Reader.ReadToEnd()

        txtOutput.Text = output
        process.WaitForExit()
        process.Close()
    End Using

End Sub


Private Sub btnRun_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    「実行」ボタンのクリックイベントハンドラ。
''
''    入力したコマンドを実行する。
''--------------------------------------------------------------------
    runCommand(txtCommand.Text)
End Sub


Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    System.Windows.Application.Current.Shutdown()
End Sub


Private Sub mnuRunCommand_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「実行」－「コマンドを実行」
''--------------------------------------------------------------------
    runCommand(txtCommand.Text)
End Sub


End Class

End Namespace
