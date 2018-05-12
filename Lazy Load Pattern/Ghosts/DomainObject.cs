using System.Collections;

namespace Lazy_Load_Pattern.Ghosts
{
    public enum LoadStatus
    {
        Ghost,
        Loading,
        Loaded
    }

    public abstract class DomainObject
    {
        public int Id { get; set; }
        private LoadStatus Status;

        public DomainObject(int id)
        {
            Id = id;
        }

        public bool IsGhost
        {
            get { return Status == LoadStatus.Ghost;  }
        }

        public bool IsLoaded
        {
            get { return Status == LoadStatus.Loaded;  }
        }

        public void MarkLoading()
        {
            Status = LoadStatus.Loading;
        }

        public void MarkLoaded()
        {
            Status = LoadStatus.Loaded;
        }

        public virtual void Load()
        {
            if (!IsGhost) return;

            var dataRow = GetDataRow();
            LoadLine(dataRow);
        }

        // Template Method Pattern
        public void LoadLine(ArrayList dataRow)
        {
            if (!IsGhost) return;

            MarkLoading();
            DoLoadLine(dataRow);
            MarkLoaded();
        }

        protected abstract void DoLoadLine(ArrayList dataRow);
        protected abstract ArrayList GetDataRow();
    }
}
