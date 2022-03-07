using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlTest
{
    public class Yol
    {

        private int nereden;
        private int nereye;
        private double mesafe;


        public int from
        {
            get { return nereden; }
            set { nereden = value; }
        }
        public int to
        {
            get { return nereye; }
            set { nereye = value; }
        }
        public double distance
        {
            get { return mesafe; }
            set { mesafe = value; }
        }
    }
}
