using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Store.classes
{
    internal class backupRecoveryClass
    {
        private int backupId;
        private string name;
        private string date;
        private int userId;


        public backupRecoveryClass()
        {
            backupId = 0;
            name = "";
            date = "";
            userId = 0;
        }

        public backupRecoveryClass(int backupId, string name, string date, int userId)
        {
            this.backupId = backupId;
            this.name = name;
            this.date = date;
            this.userId = userId;
        }
        public int BackupId
        {
            get { return backupId; }
            set { backupId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int UserID
        {
            get { return userId; }
            set { userId = value; }
        }
    }

}
