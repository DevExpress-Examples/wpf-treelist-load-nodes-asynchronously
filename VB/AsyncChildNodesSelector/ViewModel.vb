Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel

Namespace AsyncChildNodesSelector

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property DataItems As ObservableCollection(Of ProjectObject)

        Public Sub New()
            DataItems = InitData()
        End Sub

        Private Function InitData() As ObservableCollection(Of ProjectObject)
            Dim projects As ObservableCollection(Of ProjectObject) = New ObservableCollection(Of ProjectObject)()
            Dim betaronProject As ProjectObject = New ProjectObject() With {.Name = "Project: Betaron", .Stages = New ObservableCollection(Of ProjectStage)()}
            Dim stantoneProject As ProjectObject = New ProjectObject() With {.Name = "Project: Stanton", .Stages = New ObservableCollection(Of ProjectStage)()}
            InitBetaronProjectData(betaronProject)
            InitStantoneProjectData(stantoneProject)
            projects.Add(betaronProject)
            projects.Add(stantoneProject)
            Return projects
        End Function

        Private Sub InitBetaronProjectData(ByVal betaronProject As ProjectObject)
            betaronProject.Executor = "Mcfadyen Ball"
            Dim stage21 As ProjectStage = New ProjectStage() With {.Name = "Information Gathering", .Executor = "Kaiden Savastano", .Tasks = New ObservableCollection(Of StageTask)()}
            stage21.Tasks.Add(New StageTask() With {.Name = "Market research", .Executor = "Carmine Then", .StartDate = New DateTime(2011, 10, 1), .EndDate = New DateTime(2011, 10, 5), .State = "Completed"})
            stage21.Tasks.Add(New StageTask() With {.Name = "Making specification", .Executor = "Seto Kober", .StartDate = New DateTime(2011, 10, 5), .EndDate = New DateTime(2011, 10, 10), .State = "In progress"})
            Dim stage22 As ProjectStage = New ProjectStage() With {.Name = "Planning", .Executor = "Manley Difrancesco", .Tasks = New ObservableCollection(Of StageTask)()}
            stage22.Tasks.Add(New StageTask() With {.Name = "Documentation", .Executor = "Martez Gollin", .StartDate = New DateTime(2011, 10, 15), .EndDate = New DateTime(2011, 10, 16), .State = "Not started"})
            Dim stage23 As ProjectStage = New ProjectStage() With {.Name = "Design", .Executor = "Clint Mary", .Tasks = New ObservableCollection(Of StageTask)()}
            stage23.Tasks.Add(New StageTask() With {.Name = "Design of a web pages", .Executor = "Gasper Hartsell", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            stage23.Tasks.Add(New StageTask() With {.Name = "Pages layout", .Executor = "Shirish Huminski", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            Dim stage24 As ProjectStage = New ProjectStage() With {.Name = "Development", .Executor = "Edwin Thone", .Tasks = New ObservableCollection(Of StageTask)()}
            stage24.Tasks.Add(New StageTask() With {.Name = "Design", .Executor = "Zarko Knill", .StartDate = New DateTime(2011, 10, 27), .EndDate = New DateTime(2011, 10, 28), .State = "Not started"})
            stage24.Tasks.Add(New StageTask() With {.Name = "Coding", .Executor = "Harley Kirckof", .StartDate = New DateTime(2011, 10, 29), .EndDate = New DateTime(2011, 10, 30), .State = "Not started"})
            Dim stage25 As ProjectStage = New ProjectStage() With {.Name = "Testing and Delivery", .Executor = "Boucher Hislop", .Tasks = New ObservableCollection(Of StageTask)()}
            stage25.Tasks.Add(New StageTask() With {.Name = "Testing", .Executor = "Sarah Ragas", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            stage25.Tasks.Add(New StageTask() With {.Name = "Content", .Executor = "Rashid Terinoni", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            betaronProject.Stages.Add(stage21)
            betaronProject.Stages.Add(stage22)
            betaronProject.Stages.Add(stage23)
            betaronProject.Stages.Add(stage24)
            betaronProject.Stages.Add(stage25)
        End Sub

        Private Sub InitStantoneProjectData(ByVal stantoneProject As ProjectObject)
            stantoneProject.Executor = "Ruben Ackerman"
            Dim stage11 As ProjectStage = New ProjectStage() With {.Name = "Information Gathering", .Executor = "Huyen Trinklein", .Tasks = New ObservableCollection(Of StageTask)()}
            stage11.Tasks.Add(New StageTask() With {.Name = "Market research", .Executor = "Tanner Crittendon", .StartDate = New DateTime(2011, 10, 1), .EndDate = New DateTime(2011, 10, 5), .State = "Completed"})
            stage11.Tasks.Add(New StageTask() With {.Name = "Making specification", .Executor = "Carmine Then", .StartDate = New DateTime(2011, 10, 5), .EndDate = New DateTime(2011, 10, 10), .State = "Completed"})
            Dim stage12 As ProjectStage = New ProjectStage() With {.Name = "Planning", .Executor = "Alfredo Sookoo", .Tasks = New ObservableCollection(Of StageTask)()}
            stage12.Tasks.Add(New StageTask() With {.Name = "Documentation", .Executor = "Gorf Wobbe", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Completed"})
            Dim stage13 As ProjectStage = New ProjectStage() With {.Name = "Design", .Executor = "Saphire Plump", .Tasks = New ObservableCollection(Of StageTask)()}
            stage13.Tasks.Add(New StageTask() With {.Name = "Design of a web pages", .Executor = "Dominic Minden", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "In progress"})
            stage13.Tasks.Add(New StageTask() With {.Name = "Pages layout", .Executor = "Pinkerton Trezise", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "In progress"})
            Dim stage14 As ProjectStage = New ProjectStage() With {.Name = "Development", .Executor = "Lauren Partain", .Tasks = New ObservableCollection(Of StageTask)()}
            stage14.Tasks.Add(New StageTask() With {.Name = "Design", .Executor = "Delilah Beamer", .StartDate = New DateTime(2011, 10, 23), .EndDate = New DateTime(2011, 10, 24), .State = "In progress"})
            stage14.Tasks.Add(New StageTask() With {.Name = "Coding", .Executor = "Dunaway Dupriest", .StartDate = New DateTime(2011, 10, 25), .EndDate = New DateTime(2011, 10, 26), .State = "Not started"})
            Dim stage15 As ProjectStage = New ProjectStage() With {.Name = "Testing and Delivery", .Executor = "Christos Arrant", .Tasks = New ObservableCollection(Of StageTask)()}
            stage15.Tasks.Add(New StageTask() With {.Name = "Testing", .Executor = "Grice Ohora", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            stage15.Tasks.Add(New StageTask() With {.Name = "Content", .Executor = "Christos Arrant", .StartDate = New DateTime(2011, 10, 13), .EndDate = New DateTime(2011, 10, 14), .State = "Not started"})
            stantoneProject.Stages.Add(stage11)
            stantoneProject.Stages.Add(stage12)
            stantoneProject.Stages.Add(stage13)
            stantoneProject.Stages.Add(stage14)
            stantoneProject.Stages.Add(stage15)
        End Sub
    End Class
End Namespace
