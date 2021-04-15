using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Chkhitunidze_MidTerm
{
    class Student
    {
        public string firsName { get; set; }
        public string lastName { get; set; }
        public string PN { get; set; }
        public string address { get; set; }
        public int groupID { get; set; }
        public string mob { get; set; }
        public DateTime registerDate = DateTime.Now;
        public List<string> cars = new List<string>();
        public BanckAcounts banckAcounts = new BanckAcounts();


    }

    partial class BanckAcounts
    {
        public bool liberti { get; set; }
        public bool tbc { get; set; }
        public bool bog { get; set; }
        public bool VTB { get; set; }

    }
}
