using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMidterm.Models
{
    public class Status
    {
        //Course status table with progress status populated using a migration.

        public int Id { get; set; }

        public string ProgressStatus { get; set; }
    }
}