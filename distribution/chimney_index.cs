using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distribution
{
    class Chimney_index
    {
        protected double cx, cy, ch, Q;
        public Chimney_index()
        { }
        public Chimney_index(double incx, double incy, double inch, double inQ) //data from the input file
        {
            cx = incx;
            cy = incy;
            ch = inch;
            Q = inQ;
        }
        public Chimney_index(Chimney_index i)  //宣告複製建構值
        {
            cx = i.cx;
            cy = i.cy; 
            ch = i.ch; 
            Q = i.Q; 
        }
        public void set_value(double incx, double incy, double inch, double inQ)
        {
            cx = incx;
            cy = incy;
            ch = inch;
            Q = inQ;
        }

        public double get_x()
        {
            return cx;
        }
        public double get_y()
        {
            return cy;
        }
        public double get_z()
        {
            return ch;
        }
        public double get_Q()
        {
            return Q;
        }
    }
}
