using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distribution
{
    class Range
    {
        private int grid_nums, i;
        private double l, w, h, theta, u;
        private double[] X, Y, Z, x_shift, y_shift;

        public Range(double x, double y, double z, double dx, double dy, double dz, double intheta, double inu)
        {
            theta = (intheta * Math.PI) / 180;
            u = inu;
            l = (x / dx) + 1;
            w = (y / dy) + 1;
            h = (z / dz) + 1;
            grid_nums = (int)l * (int)w * (int)h;
            X = new double[grid_nums];
            Y = new double[grid_nums];
            Z = new double[grid_nums];
            int i, j, k, n;
            for (k = 0; k < h; k++) // build the grids, from the bottom to top
            {
                for (j = 0; j < w; j++)
                {
                    for (i = 0; i < l; i++)
                    {
                        n = i + (int)l * j + ((int)w * (int)w) * k;
                        X[n] = i * dx;
                        Y[n] = j * dy;
                        Z[n] = k * dz;
                    }
                }
            }
            // MessageBox.Show("range build finish" + u);
        }
        public void shift(double cx,double cy)
        {
            x_shift = new double[grid_nums];
            y_shift = new double[grid_nums];
            for (i = 0; i < grid_nums; i++) //平移旋轉座標軸
            {
                x_shift[i] = Math.Cos(theta) * (X[i] - cx) + Math.Sin(theta) * (Y[i] - cy);
                y_shift[i] = -Math.Sin(theta) * (X[i] - cx) + Math.Cos(theta) * (Y[i] - cy);
            }
        }
        public double[] getX()
        {
            return X;
        }
        public double[] getY()
        {
            return Y;
        }
        public double[] getZ()
        {
            return Z;
        }
        public double[] get_shiftX()
        {
            return x_shift;
        }
        public double[] get_shiftY()
        {
            return y_shift;
        }
        public double get_wind_direction()
        {
            return theta;
        }
        public double get_wind_speed()
        {
            return u;
        }
        public int get_grid_nums()
        {
            return grid_nums;
        }
        public int get_ground()
        {
            return (int)l * (int)w;
        }
    }
}
