using System;
using System.Collections.ObjectModel;

namespace AsyncChildNodesSelector {
    public class BaseObject {
        public string Name { get; set; }
        public string Executor { get; set; }
        public string State { get; set; }
    }

    public class ProjectObject : BaseObject {
        public ObservableCollection<ProjectStage> Stages { get; set; }
    }

    public class ProjectStage : BaseObject {
        public ObservableCollection<StageTask> Tasks { get; set; }
    }

    public class StageTask : BaseObject {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
