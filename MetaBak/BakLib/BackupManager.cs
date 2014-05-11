using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public class BackupManager : ICollection<IBackupDriver>, IStalked<BackupManager>
    {

        private List<IBackupDriver> _drivers = new List<IBackupDriver>();

        public void Hold(IBackupDriver driver)
        {
            driver.Stop();
        }

        public void Start(IBackupDriver driver)
        {
            if(_drivers.Contains(driver))
                driver.Start();
        }

        public void Add(IBackupDriver item)
        {
            _drivers.Add(item);
            item.Activate();
            Update();
        }


        public void Clear()
        {
            _drivers.Clear();
        }

        public bool Contains(IBackupDriver item)
        {
            return _drivers.Contains(item);
        }

        public void CopyTo(IBackupDriver[] array, int arrayIndex)
        {
            _drivers.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _drivers.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(IBackupDriver item)
        {
            item.Stop();
            _drivers.Remove(item);
            return true;
        }

        public IEnumerator<IBackupDriver> GetEnumerator()
        {
            return _drivers.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _drivers.GetEnumerator();
        }

        public void Activate()
        {
            foreach (BackupDriverBase backup in this)
            {
                backup.Activate();
            }
        }

        public void Start()
        {
            foreach (BackupDriverBase backup in this)
            {
                backup.Start();
            }
        }

        List<IStalker<BackupManager>> stalkers = new List<IStalker<BackupManager>>();

        public void Subscribe(IStalker<BackupManager> element)
        {
            stalkers.Add(element);
        }

        public void Unsubscribe(IStalker<BackupManager> element)
        {
            stalkers.Remove(element);
        }

        private void Update()
        {
            foreach (IStalker<BackupManager> stalker in stalkers)
            {
                stalker.Update(this);
            }
        }
    }
}
