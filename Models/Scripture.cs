using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureID { get; set; }

        public string Canon { get; set; }

        public string Book { get; set; }

        public string Chapter { get; set; }

        public string Verses { get; set; }


        public DateTime CreatedDate { get; set; }
    }
}
