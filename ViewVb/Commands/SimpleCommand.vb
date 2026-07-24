
Imports System.Windows.Input


Namespace Global.ViewVb.Commands

Public Class SimpleCommand
        Implements ICommand

Private ReadOnly   m_execute As Action(Of Object)
Private ReadOnly   m_canExecute As Predicate(Of Object)


Public Sub New(
        execute As Action(Of Object),
        Optional canExecute As Predicate(Of Object) = Nothing)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    Me.m_execute    = execute
    Me.m_canExecute = canExecute
End Sub


End Class

End Namespace
