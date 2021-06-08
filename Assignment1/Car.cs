using System;
using System.Collections.Generic;


namespace Assignment1
{
    public class Car: IComparable
    {
        public int km_h { get; set; }
        private double ps { get; set; }
        private double kw { get; set; }

        public double u_min { get; set; }
        public double ccm { get; set; }
        public double zero_hundred { get; set; }
        public int cylinder { get; set; }


        public Car(int km_h, double ps, double kw, double u_min, double ccm, double zero_hundred, int cylinder)
        {
            this.km_h = km_h;
            this.ps = ps;
            this.kw = kw;
            this.u_min = u_min;
            this.ccm = ccm;
            this.zero_hundred = zero_hundred;
            this.cylinder = cylinder;
        }


        public int CompareCars(Car car2)
        {
            double car = this.km_h + (this.ps / this.kw) + this.u_min + this.ccm + this.cylinder - this.zero_hundred;
            double carOther = car2.km_h + (car2.ps / car2.kw) + car2.u_min + car2.ccm + car2.cylinder - car2.zero_hundred;

            if (car > carOther)
            {
                return 1;
            }
            else if (carOther > car)
            {
                return -1;
            }
                else return 0;

        }


        public int CompareTo(object carObj)
        {
            Car car = carObj as Car;
            if (this.km_h > car.km_h)
            {
                return 1;
            }
            else if (this.km_h < car.km_h)
            {
                return -1;
            }
                else return 0;
        }
    }
}
