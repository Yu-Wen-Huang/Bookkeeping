using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookkeepingHW.Models.ViewModels
{
    public class ListViewModel
    {
        public string Category { get; set; }
        public DateTime? Date { get; set; }
        public int Amount { get; set; }
        public string Memo { get; set; }
    }
}