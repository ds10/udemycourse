using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Universities.Classes
{
    class University
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name
        {
            get;
            set;
        }


        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string D { get; set; }
    }
}

