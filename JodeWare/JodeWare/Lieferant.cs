using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace JodeWare
{
    public class Lieferant
    {
        [PrimaryKey, AutoIncrement]
        public int LieID
        {
            get;
            set;
        }

        public String Bezeichnung
        {
            get;
            set;
        }
    }
}
