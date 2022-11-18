Imports System.Collections.ObjectModel

Namespace AsyncChildNodesSelector

    Public Class BaseObject

        Public Property Name As String

        Public Property Executor As String

        Public Property State As String
    End Class

    Public Class ProjectObject
        Inherits BaseObject

        Public Property Stages As ObservableCollection(Of ProjectStage)
    End Class

    Public Class ProjectStage
        Inherits BaseObject

        Public Property Tasks As ObservableCollection(Of StageTask)
    End Class

    Public Class StageTask
        Inherits BaseObject

        Public Property StartDate As Date

        Public Property EndDate As Date
    End Class
End Namespace
