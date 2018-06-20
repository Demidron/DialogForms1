using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Assessment
    {
        public DateTime Date = new DateTime();
        public Assessment()
        {

        }
        public Assessment(DateTime date, int assessment)
        {
            Date = date;
            this.assessment = assessment;
        }

        public int assessment { get; set; }
    }
}
