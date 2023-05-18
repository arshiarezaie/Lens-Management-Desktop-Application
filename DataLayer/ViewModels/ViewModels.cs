
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class LensViewModel
    {
        public int ID { get; set; }
        public int SectionID { get; set; }
        public string SectionTitle { get; set; }
        public string SPH { get; set; }
        public string CYL { get; set; }
        public string AXE { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }

}
