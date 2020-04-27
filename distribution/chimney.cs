using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace distribution
{
    class Chimney :  Chimney_index 
    {
        private double[] C; //宣告濃度指標陣列C>>存放所有濃度值
        private int grid_nums;

        public Chimney() 
        { }
        
        public Chimney (int t)
        {
            grid_nums = t;
            C = new double [grid_nums];
        }
        public Chimney(double incx, double incy, double inch, double inQ,int nums) //data from the input file
        {
            cx = incx;
            cy = incy;
            ch = inch;
            Q = inQ;
            grid_nums = nums;
            C = new double[grid_nums];

        }
        public Chimney (Chimney i)  //宣告複製建構值
        {
            cx=i.cx;
            cy=i.cy;
            ch=i.ch;
            Q=i.Q;
            grid_nums=i.grid_nums;
            C=new double[grid_nums];
            for(int o=0; o<grid_nums; o++)
                C[o]=i.C[o];
        }

        public void init(double incx, double incy, double inch, double inQ, int t)
        {
            cx = incx;
            cy = incy;
            ch = inch;
            Q = inQ;
            grid_nums = t;
            C = new double[grid_nums];
        }

    public static Chimney operator +(Chimney Chim, Chimney Chim2) //宣告加號重載運算值
    {
        for (int i = 0; i < Chim.grid_nums; i++)
        {
            Chim.C[i] =Chim.C[i] +Chim2.C[i]  ;
        }
        //Chim.grid_nums = Chim2.grid_nums;
        return Chim;  //回傳calC物件
    }

    public void cal(Range range)
    {
        int i;
        double sigma_y, sigma_z, a, b, c, d,speed;
        double[] x_shift, y_shift, Z;
        
            x_shift = range.get_shiftX();
            y_shift = range.get_shiftY();
            Z = range.getZ();
            speed = range.get_wind_speed();
        for (i = 0; i < grid_nums; i++) //Steady–State Gussian Plume Model
        {
            if (x_shift[i] > 0) //confirm the position is positive
            {
                sigma_y = (0.22 * x_shift[i] / Math.Sqrt(1 + 0.0001 * x_shift[i]));
                sigma_z = 0.001 * x_shift[i];
                a = (Q / (2 * Math.PI * speed * sigma_y * sigma_z));
                b = (-y_shift[i] * y_shift[i] / (2 * sigma_z * sigma_z));
                c = (-(Z[i] - ch) * (Z[i] - ch) / (2 * sigma_z * sigma_z));
                d = (-(Z[i] + ch) * (Z[i] + ch) / (2 * sigma_z * sigma_z));
                C[i] = C[i] + a * Math.Exp(b) * (Math.Exp(c) + Math.Exp(d));
            }
        }
    }
    public int max_point(int ground)
    {
            int max_point=0, i;
            double maxC=0;
            for (i=0;i<ground;i++) 
            { 
                if(C[i]>maxC)
                {
                    max_point = i;
                    maxC = C[i];
                }
                
            }
            return max_point;
    }
    public double maxC(int i)
        {
            return C[i];
        }
    }
}
