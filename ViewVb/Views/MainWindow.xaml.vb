''  -*-  coding: utf-8-with-signature-unix     -*-  ''
''************************************************************************
''                                                                      ''
''                    ---  WPF Template Project  ---                    ''
''                                                                      ''
''          Copyright (C), 2025-2026, Takahiro Itou                     ''
''          All Rights Reserved.                                        ''
''                                                                      ''
''          License: (See COPYING or LICENSE files)                     ''
''          GNU Affero General Public License (AGPL) version 3,         ''
''          or (at your option) any later version.                      ''
''                                                                      ''
''************************************************************************

Namespace Global.ViewVb.Views

''========================================================================
''
''    MainWindow  class
''

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


Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    System.Windows.Application.Current.Shutdown()
End Sub

Private Sub MainWindow_Loaded(ByVal sender As Object, e As RoutedEventArgs) _
    Handles Me.Loaded
''--------------------------------------------------------------------
''    ウィンドウのロードイベント
''--------------------------------------------------------------------
Dim customIcon As String

    customIcon  = System.IO.Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "Resources", "MainWindow.ico")

    If System.IO.File.Exists(customIcon) Then
        Try
            Me.Icon = New BitmapImage(New Uri(customIcon, UriKind.Absolute))
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(
                $"Failed custom icon: {ex.Message}")
        End Try
    End If

End Sub


End Class

End Namespace
