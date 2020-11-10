using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureID { get; set; }

        public string Canon { get; set; }

        public string Book { get; set; }

        public string Chapter { get; set; }

        public string Verses { get; set; }

        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
