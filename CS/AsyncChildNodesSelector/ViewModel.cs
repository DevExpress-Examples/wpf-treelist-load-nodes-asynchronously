using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace AsyncChildNodesSelector {
    public class ViewModel : ViewModelBase {
        public ObservableCollection<ProjectObject> DataItems { get; set; }

        public ViewModel() {
            DataItems = InitData();
        }

        private ObservableCollection<ProjectObject> InitData() {
            ObservableCollection<ProjectObject> projects = new ObservableCollection<ProjectObject>();
            ProjectObject betaronProject = new ProjectObject() { Name = "Project: Betaron", Stages = new ObservableCollection<ProjectStage>() };
            ProjectObject stantoneProject = new ProjectObject() { Name = "Project: Stanton", Stages = new ObservableCollection<ProjectStage>() };

            InitBetaronProjectData(betaronProject);
            InitStantoneProjectData(stantoneProject);

            projects.Add(betaronProject);
            projects.Add(stantoneProject);

            return projects;
        }

        void InitBetaronProjectData(ProjectObject betaronProject) {
            betaronProject.Executor = "Mcfadyen Ball";
            ProjectStage stage21 = new ProjectStage() { Name = "Information Gathering", Executor = "Kaiden Savastano", Tasks = new ObservableCollection<StageTask>() };

            stage21.Tasks.Add(new StageTask() { Name = "Market research", Executor = "Carmine Then", StartDate = new DateTime(2011, 10, 1), EndDate = new DateTime(2011, 10, 5), State = "Completed" });
            stage21.Tasks.Add(new StageTask() { Name = "Making specification", Executor = "Seto Kober", StartDate = new DateTime(2011, 10, 5), EndDate = new DateTime(2011, 10, 10), State = "In progress" });
            ProjectStage stage22 = new ProjectStage() { Name = "Planning", Executor = "Manley Difrancesco", Tasks = new ObservableCollection<StageTask>() };

            stage22.Tasks.Add(new StageTask() { Name = "Documentation", Executor = "Martez Gollin", StartDate = new DateTime(2011, 10, 15), EndDate = new DateTime(2011, 10, 16), State = "Not started" });
            ProjectStage stage23 = new ProjectStage() { Name = "Design", Executor = "Clint Mary", Tasks = new ObservableCollection<StageTask>() };

            stage23.Tasks.Add(new StageTask() { Name = "Design of a web pages", Executor = "Gasper Hartsell", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });
            stage23.Tasks.Add(new StageTask() { Name = "Pages layout", Executor = "Shirish Huminski", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });
            ProjectStage stage24 = new ProjectStage() { Name = "Development", Executor = "Edwin Thone", Tasks = new ObservableCollection<StageTask>() };

            stage24.Tasks.Add(new StageTask() { Name = "Design", Executor = "Zarko Knill", StartDate = new DateTime(2011, 10, 27), EndDate = new DateTime(2011, 10, 28), State = "Not started" });
            stage24.Tasks.Add(new StageTask() { Name = "Coding", Executor = "Harley Kirckof", StartDate = new DateTime(2011, 10, 29), EndDate = new DateTime(2011, 10, 30), State = "Not started" });
            ProjectStage stage25 = new ProjectStage() { Name = "Testing and Delivery", Executor = "Boucher Hislop", Tasks = new ObservableCollection<StageTask>() };

            stage25.Tasks.Add(new StageTask() { Name = "Testing", Executor = "Sarah Ragas", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });
            stage25.Tasks.Add(new StageTask() { Name = "Content", Executor = "Rashid Terinoni", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });

            betaronProject.Stages.Add(stage21);
            betaronProject.Stages.Add(stage22);
            betaronProject.Stages.Add(stage23);
            betaronProject.Stages.Add(stage24);
            betaronProject.Stages.Add(stage25);
        }

        void InitStantoneProjectData(ProjectObject stantoneProject) {
            stantoneProject.Executor = "Ruben Ackerman";
            ProjectStage stage11 = new ProjectStage() { Name = "Information Gathering", Executor = "Huyen Trinklein", Tasks = new ObservableCollection<StageTask>() };

            stage11.Tasks.Add(new StageTask() { Name = "Market research", Executor = "Tanner Crittendon", StartDate = new DateTime(2011, 10, 1), EndDate = new DateTime(2011, 10, 5), State = "Completed" });
            stage11.Tasks.Add(new StageTask() { Name = "Making specification", Executor = "Carmine Then", StartDate = new DateTime(2011, 10, 5), EndDate = new DateTime(2011, 10, 10), State = "Completed" });
            ProjectStage stage12 = new ProjectStage() { Name = "Planning", Executor = "Alfredo Sookoo", Tasks = new ObservableCollection<StageTask>() };

            stage12.Tasks.Add(new StageTask() { Name = "Documentation", Executor = "Gorf Wobbe", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Completed" });

            ProjectStage stage13 = new ProjectStage() { Name = "Design", Executor = "Saphire Plump", Tasks = new ObservableCollection<StageTask>() };

            stage13.Tasks.Add(new StageTask() { Name = "Design of a web pages", Executor = "Dominic Minden", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "In progress" });
            stage13.Tasks.Add(new StageTask() { Name = "Pages layout", Executor = "Pinkerton Trezise", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "In progress" });
            ProjectStage stage14 = new ProjectStage() { Name = "Development", Executor = "Lauren Partain", Tasks = new ObservableCollection<StageTask>() };

            stage14.Tasks.Add(new StageTask() { Name = "Design", Executor = "Delilah Beamer", StartDate = new DateTime(2011, 10, 23), EndDate = new DateTime(2011, 10, 24), State = "In progress" });
            stage14.Tasks.Add(new StageTask() { Name = "Coding", Executor = "Dunaway Dupriest", StartDate = new DateTime(2011, 10, 25), EndDate = new DateTime(2011, 10, 26), State = "Not started" });
            ProjectStage stage15 = new ProjectStage() { Name = "Testing and Delivery", Executor = "Christos Arrant", Tasks = new ObservableCollection<StageTask>() };

            stage15.Tasks.Add(new StageTask() { Name = "Testing", Executor = "Grice Ohora", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });
            stage15.Tasks.Add(new StageTask() { Name = "Content", Executor = "Christos Arrant", StartDate = new DateTime(2011, 10, 13), EndDate = new DateTime(2011, 10, 14), State = "Not started" });

            stantoneProject.Stages.Add(stage11);
            stantoneProject.Stages.Add(stage12);
            stantoneProject.Stages.Add(stage13);
            stantoneProject.Stages.Add(stage14);
            stantoneProject.Stages.Add(stage15);
        }
    }
}
