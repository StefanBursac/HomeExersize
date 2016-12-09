using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeBindingDataHomeExersize
{
   public class Ime
    {
        public string firstName{get; set;}
        public string lastName { get; set; }


        public string GetSetIme()
        {

            firstName = "Stefan";
            lastName = "Bursac";

            string name = firstName + lastName;
            return name;
        }
        

        }   


    }

