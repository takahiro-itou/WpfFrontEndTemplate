
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Imports ViewVb.Commands
Imports ViewVb.Models


Namespace Global.ViewVb.ViewModels

Public Class SampleViewModel
        Implements INotifyPropertyChanged

Private ReadOnly m_trgModel As SampleModel

Public Sub New(ByVal model As SampleModel)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    Me.m_trgModel = model
    Me.m_runTaskCommand = New SimpleCommand(
        Sub(ByVal parameter As Object)
            Me.runModelTaskAsync
        End Sub,
        Function(ByVal parameter As Object) As Boolean
            Return  Me.m_canRunTask()
        End Function
    )
End Sub


Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

Protected Sub raisePropertyChanged(
        <CallerMemberName> Optional propertyName As String = Nothing)
    RaiseEvent  PropertyChanged(
            Me, New PropertyChangedEventArgs(propertyName)
    )
End Sub


Public Function canRunTask() As Boolean
    Return True
End Function


Public Async Sub runModelTaskAsync

End Sub


End Class

End Namespace
