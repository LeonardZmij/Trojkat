using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trojkat
{
    public class Trojkat
    {
        private double bokA;
        private double bokB;
        private double bokC;

        public double BokA
        {
            get { return bokA; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Długość boku musi być większa od 0.");
                bokA = value;
            }
        }

        public double BokB
        {
            get { return bokB; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Długość boku musi być większa od 0.");
                bokB = value;
            }
        }

        public double BokC
        {
            get { return bokC; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Długość boku musi być większa od 0.");
                bokC = value;
            }
        }

        public bool CzyMoznaZbudowacTrojkat()
        {
            return bokA + bokB > bokC && bokA + bokC > bokB && bokB + bokC > bokA;
        }

        public double ObliczPole()
        {
            double p = ObliczObwod() / 2;
            return Math.Sqrt(p * (p - bokA) * (p - bokB) * (p - bokC));
        }

        public double ObliczObwod()
        {
            return bokA + bokB + bokC;
        }

        public string SprawdzTypTrojkata()
        {
            double a2 = bokA * bokA;
            double b2 = bokB * bokB;
            double c2 = bokC * bokC;

            if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
            {
                return "Prostokątny";
            }
            else if (a2 + b2 > c2 && a2 + c2 > b2 && b2 + c2 > a2)
            {
                return "Ostrokatny";
            }
            else
            {
                return "Rozwartokątny";
            }
        }
    }

}