using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakLib
{
    public class BackupManager : ICollection<IBackupDriver>, IStalked<BackupManager>
    {

        //private List<IBackupDriver> _drivers = new List<IBackupDriver>();

        private Dictionary<IBackupDriver, List<SyncSetting>> _settings = new Dictionary<IBackupDriver, List<SyncSetting>>();

        public List<SyncSetting> GetSettings(IBackupDriver driver)
        {
            return _settings[driver];
        }

        public void Hold(IBackupDriver driver)
        {
            driver.Stop();
        }

        public void Start(IBackupDriver driver)
        {
            if(_settings.Keys.Contains(driver))
                driver.Start();
        }

        public void Add(IBackupDriver item)
        {
            _settings.Add(item, new List<SyncSetting>());
            item.Activate();
            Update();
        }


        public void Clear()
        {
            _settings.Clear();
        }

        public bool Contains(IBackupDriver item)
        {
            return _settings.Keys.Contains(item);
        }

        public void CopyTo(IBackupDriver[] array, int arrayIndex)
        {
            _settings.Keys.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _settings.Keys.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(IBackupDriver item)
        {
            item.Stop();
            _settings.Remove(item);
            return true;
        }

        public IEnumerator<IBackupDriver> GetEnumerator()
        {
            return _settings.Keys.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _settings.Keys.GetEnumerator();
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
        public void AddSyncPath(IBackupDriver driver,  SyncSetting sync)
        {
            _settings[driver].Add(sync);
        }
    }
}

