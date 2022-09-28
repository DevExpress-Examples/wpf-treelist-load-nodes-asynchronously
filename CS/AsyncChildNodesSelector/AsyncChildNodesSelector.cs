using DevExpress.Xpf.Grid;
using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncChildNodesSelector {
    public class CustomChildrenSelector : IAsyncChildNodesSelector {
        public Task<bool> HasChildNode(object item, CancellationToken token) {
            return Task.Run(async () => {
                for (int i = 0; i < 10; i++) {
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(25);
                }
                return !(item is StageTask);
            });
        }

        public IEnumerable SelectChildren(object item) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable> SelectChildrenAsync(object item, CancellationToken token) {
            return Task.Run(async () => {
                for (int i = 0; i < 10; i++) {
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(100);
                }
                return SelectChildNodes(item);
            });
        }

        public IEnumerable SelectChildNodes(object item) {
            if (item is ProjectStage)
                return (item as ProjectStage).Tasks;
            else if (item is ProjectObject)
                return (item as ProjectObject).Stages;
            return null;
        }
    }
}
