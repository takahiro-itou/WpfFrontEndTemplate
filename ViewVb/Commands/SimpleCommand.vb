
Imports System.Windows.Input


Namespace Global.ViewVb.Commands

Public Class SimpleCommand
        Implements ICommand

Private ReadOnly   m_execute As Action(Of Object)
Private ReadOnly   m_canExecute As Predicate(Of Object)


End Class

End Namespace
