
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Treateding.Tasks
Imports System.Windows.Input

Imports ViewVb.Commands
Imports ViewVb.Models


Namespace Global.ViewVb.ViewModels

Public Class SampleViewModel
        Implements INotifyPropertyChanged


Public Sub New(ByVal model As SampleModel)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------

    Me.m_progress = New System.Progress(Of Integer)(AddressOf updateProgress)
    Me.m_trgModel = model

    Me.m_runTaskCommand = New SimpleCommand(
        Sub(ByVal parameter As Object)
            Me.runModelTaskAsync
        End Sub,
        Function(ByVal parameter As Object) As Boolean
            Return  Me.canRunTask()
        End Function
    )
    Me.m_returnCode = 0
End Sub


''======================================================================
''
''    Properties.
''

Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged


Public Property ResultText() As String
    Get
        Return  Me.m_trgModel.ResultText
    End Get
    Set(ByVal value As String)
        Me.m_trgModel.ResultText = value
    End Set
End Property


Public Property ReturnCode() As Integer
    Get
        Return  Me.m_returnCode
    End Get
    Private Set(ByVal value As Integer)
        Me.m_returnCode = value
    End Set
End Property


''======================================================================
''
''    Public Member Functions.
''

Public Function canRunTask() As Boolean
    Return  True
End Function


Public Async Sub runModelTaskAsync
''--------------------------------------------------------------------
''    モデルのタスクを非同期で実行する。
''--------------------------------------------------------------------
Dim result As Integer
Dim myTask As Task(Of Integer)

    mytask = Task.Run(Of Integer)(
        Function() As Integer
            Return  Me.m_trgModel.runTask(Me.m_progress)
        End Function
    )
    result  = await mytask
    Me.ReturnCode = result
    Me.ResultText = Me.m_trgModel.ResultText
End Sub


''======================================================================
''
''    Protected Member Functions.
''

Protected Overridable Sub raisePropertyChanged(
        <CallerMemberName> Optional propertyName As String = Nothing)
    RaiseEvent  PropertyChanged(
            Me, New PropertyChangedEventArgs(propertyName)
    )
End Sub


Protected Overridable Sub updateProgress(
        ByVal progressValue As Integer)

End Sub


''========================================================================
''
''    Member Variables.
''

Private ReadOnly m_progress As System.IProgress(Of Integer)
Private ReadOnly m_trgModel As SampleModel

Private ReadOnly m_runTaskCommand As SimpleCommand

Private m_returnCode As Integer


End Class

End Namespace
