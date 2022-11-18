Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections
Imports System.Threading
Imports System.Threading.Tasks

Namespace AsyncChildNodesSelector

    Public Class CustomChildrenSelector
        Implements IAsyncChildNodesSelector

        Public Function HasChildNode(ByVal item As Object, ByVal token As CancellationToken) As Task(Of Boolean) Implements IAsyncChildNodesSelector.HasChildNode
            Return Task.Run(Async Function()
                For i As Integer = 0 To 10 - 1
                    token.ThrowIfCancellationRequested()
                    Await Task.Delay(25)
                Next

                Return Not(TypeOf item Is StageTask)
            End Function)
        End Function

        Public Function SelectChildren(ByVal item As Object) As IEnumerable Implements IChildNodesSelector.SelectChildren
            Throw New NotImplementedException()
        End Function

        Public Function SelectChildrenAsync(ByVal item As Object, ByVal token As CancellationToken) As Task(Of IEnumerable) Implements IAsyncChildNodesSelector.SelectChildrenAsync
            Return Task.Run(Async Function()
                For i As Integer = 0 To 10 - 1
                    token.ThrowIfCancellationRequested()
                    Await Task.Delay(100)
                Next

                Return SelectChildNodes(item)
            End Function)
        End Function

        Public Function SelectChildNodes(ByVal item As Object) As IEnumerable
            If TypeOf item Is ProjectStage Then
                Return TryCast(item, ProjectStage).Tasks
            ElseIf TypeOf item Is ProjectObject Then
                Return TryCast(item, ProjectObject).Stages
            End If

            Return Nothing
        End Function
    End Class
End Namespace
