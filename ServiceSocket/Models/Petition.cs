using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSocket.Models
{
    class Petition
    {
        public DateTime datePetition { get; set; }
        public string message { get; set; }
        public int totalCaracteres { get; set; }
        public string secondCharter { get; set; }
        public int countUpper { get; set; }
        public int countNumbers { get; set; }
        public Boolean haveUpper { get; set; }
        public Boolean haveNumbers { get; set; }
        public List<int> numberList { get; set; }
    }
}
