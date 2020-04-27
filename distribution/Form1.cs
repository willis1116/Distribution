using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distribution
{
    public partial class Form1 : Form
    {
        Range grid;
        Chimney[] chimney = new Chimney[20];
        Chimney chim_sum;



        int count, grid_nums,ground,maxp;      

        public Form1()
        {
            InitializeComponent();
        }

        private void build_grid_Click(object sender, EventArgs e)
        {
            double X, Y, Z, dx, dy, dz, wind_direction, wind_speed;
            X = Double.Parse(range_X.Text);
            Y = Double.Parse(range_Y.Text);
            Z = Double.Parse(range_Z.Text);
            dx = Double.Parse(this.dx.Text);
            dy = Double.Parse(this.dy.Text);
            dz = Double.Parse(this.dz.Text); //"this" is Form1
            wind_direction = Double.Parse(this.wind_direction.Text);
            wind_speed = Double.Parse(this.wind_speed.Text);

            grid = new Range(X, Y, Z,dx,dy,dz,wind_direction,wind_speed);
            build_grid.Enabled = false;
            range_X.ReadOnly = true;
            range_Y.ReadOnly = true;
            range_Z.ReadOnly = true;
            this.dx.ReadOnly = true;
            this.dy.ReadOnly = true;
            this.dz.ReadOnly = true;
            this.wind_direction.ReadOnly = true;
            this.wind_speed.ReadOnly = true;
            build_chimney.Enabled = true;
            this.chimney_x.ReadOnly = false;
            this.chimney_y.ReadOnly = false;
            this.chimney_z.ReadOnly = false;
            this.emission.ReadOnly = false;
            grid_nums = grid.get_grid_nums();
            ground = grid.get_ground();
            chim_sum = new Chimney(grid_nums);
            chimney_info.Text += "網格建立完成\r\n";
            
        }

        private void Max_concentration_Click(object sender, EventArgs e)
        {
            double[] X, Y, Z;            
            X = grid.getX();
            Y = grid.getY();
            Z = grid.getZ();
            maxp= chim_sum.max_point(ground);
            chimney_info.Text += "地面最大濃度為: "+chim_sum.maxC(maxp)+"\r\n";
            chimney_info.Text += "地面最大濃度位置(X,Y,Z) : (" + X[maxp] + "," + Y[maxp] + "," + Z[maxp] + ")\r\n";
          
            //捲動到底部
            chimney_info.SelectionStart = chimney_info.Text.Length;
            chimney_info.ScrollToCaret();
            
        }


        private void build_chimney_Click(object sender, EventArgs e)  //
        {
            double X, Y, Z, Q;
            X = Double.Parse(this.chimney_x.Text);
            Y = Double.Parse(this.chimney_y.Text);
            Z = Double.Parse(this.chimney_z.Text);
            Q = Double.Parse(this.emission.Text);   
                       
            chimney[count] = new Chimney(X, Y, Z, Q,grid_nums);
            grid.shift(chimney[count].get_x(), chimney[count].get_y());
            chimney[count].cal(grid);
            chim_sum =  chim_sum+chimney[count]  ;
            count++;
            chimney_info.Text += count+"號煙囪位置(X,Y,Z) : ("+X+"," + Y + "," + Z + ")  汙染物排放濃度:"+ Q +"   \r\n";
            chimney_info.SelectionStart = chimney_info.Text.Length;
            chimney_info.ScrollToCaret();
            Max_concentration.Enabled = true;
            if (count == 20)
                build_chimney.Enabled = false;
        }
    }
}
