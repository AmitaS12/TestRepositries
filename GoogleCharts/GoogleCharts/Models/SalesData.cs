using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoogleCharts.Models
{
    public class SalesData
    {
        [Key]
        public int SID { get; set; }

        public int Year { get; set; }
        public int Electronics { get; set; }

        public int BookAndMedia { get; set; }
        public int HomeAndKitchen { get; set; }

    }
}