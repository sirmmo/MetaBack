using BakLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BakLib
{
    public class ConfigManager
    {
        private FileStream _file;

        private BackupManager _back;

        public ConfigManager()
        {
            _back = new BackupManager();
            _file = File.Open("settings.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void LoadConfiguration(){
            XmlDocument doc = new XmlDocument();
            doc.Load(_file);
            XmlNodeList ul = doc.GetElementsByTagName("Bak");
            foreach (XmlNode li in ul)
            {

            }
            
        }

        public void StoreConfiguration() {

            XmlDocument doc = new XmlDocument();
            doc.Load(_file);

            doc.CreateXmlDeclaration("1.0", "utf-8", "yes");

            XmlElement baks = doc.CreateElement("Baks");

            foreach (IBackupDriver driver in _back)
            {
                
            }

            doc.Save(_file);
        }

    }
}
