using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    public class Projekcija
    {
        public DateTime datumVrijeme;
        public string Datum {
            get {
                return datumVrijeme.Date.ToShortDateString();
            }
        }
        public string Vrijeme {
            get {
                return datumVrijeme.TimeOfDay.ToString();
            }
        }
        public string Sala { get; set; }
            //get
            //{
            //    return Sala;
            //}
            //set
            //{
            //    Sala = value;
            //}
            //}
        public string Cijena { get; set; }
        //    get
        //    {
        //        return Cijena;
        //    }
        //    set
        //    {
        //        Cijena = value;
        //    }
        //}
    }
}
