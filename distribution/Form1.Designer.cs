namespace distribution
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.range_X = new System.Windows.Forms.TextBox();
            this.dx = new System.Windows.Forms.TextBox();
            this.range_Z = new System.Windows.Forms.TextBox();
            this.range_Y = new System.Windows.Forms.TextBox();
            this.dz = new System.Windows.Forms.TextBox();
            this.dy = new System.Windows.Forms.TextBox();
            this.wind_speed = new System.Windows.Forms.TextBox();
            this.wind_direction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.build_grid = new System.Windows.Forms.Button();
            this.chimney_y = new System.Windows.Forms.TextBox();
            this.chimney_z = new System.Windows.Forms.TextBox();
            this.chimney_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emission = new System.Windows.Forms.TextBox();
            this.build_chimney = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chimney_info = new System.Windows.Forms.TextBox();
            this.Max_concentration = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // range_X
            // 
            this.range_X.Location = new System.Drawing.Point(161, 35);
            this.range_X.Margin = new System.Windows.Forms.Padding(2);
            this.range_X.Name = "range_X";
            this.range_X.Size = new System.Drawing.Size(46, 22);
            this.range_X.TabIndex = 0;
            this.range_X.TextChanged += new System.EventHandler(this.range_X_TextChanged);
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(161, 83);
            this.dx.Margin = new System.Windows.Forms.Padding(2);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(46, 22);
            this.dx.TabIndex = 3;
            this.dx.TextChanged += new System.EventHandler(this.dx_TextChanged);
            // 
            // range_Z
            // 
            this.range_Z.Location = new System.Drawing.Point(366, 33);
            this.range_Z.Margin = new System.Windows.Forms.Padding(2);
            this.range_Z.Name = "range_Z";
            this.range_Z.Size = new System.Drawing.Size(46, 22);
            this.range_Z.TabIndex = 2;
            this.range_Z.TextChanged += new System.EventHandler(this.range_Z_TextChanged);
            // 
            // range_Y
            // 
            this.range_Y.Location = new System.Drawing.Point(261, 35);
            this.range_Y.Margin = new System.Windows.Forms.Padding(2);
            this.range_Y.Name = "range_Y";
            this.range_Y.Size = new System.Drawing.Size(46, 22);
            this.range_Y.TabIndex = 1;
            this.range_Y.TextChanged += new System.EventHandler(this.range_Y_TextChanged);
            // 
            // dz
            // 
            this.dz.Location = new System.Drawing.Point(366, 85);
            this.dz.Margin = new System.Windows.Forms.Padding(2);
            this.dz.Name = "dz";
            this.dz.Size = new System.Drawing.Size(46, 22);
            this.dz.TabIndex = 5;
            this.dz.TextChanged += new System.EventHandler(this.dz_TextChanged);
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(261, 85);
            this.dy.Margin = new System.Windows.Forms.Padding(2);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(46, 22);
            this.dy.TabIndex = 4;
            this.dy.TextChanged += new System.EventHandler(this.dy_TextChanged);
            // 
            // wind_speed
            // 
            this.wind_speed.Location = new System.Drawing.Point(119, 130);
            this.wind_speed.Margin = new System.Windows.Forms.Padding(2);
            this.wind_speed.Name = "wind_speed";
            this.wind_speed.Size = new System.Drawing.Size(46, 22);
            this.wind_speed.TabIndex = 6;
            this.wind_speed.TextChanged += new System.EventHandler(this.wind_speed_TextChanged);
            // 
            // wind_direction
            // 
            this.wind_direction.Location = new System.Drawing.Point(278, 129);
            this.wind_direction.Margin = new System.Windows.Forms.Padding(2);
            this.wind_direction.Name = "wind_direction";
            this.wind_direction.Size = new System.Drawing.Size(46, 22);
            this.wind_direction.TabIndex = 7;
            this.wind_direction.TextChanged += new System.EventHandler(this.wind_direction_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "網格範圍(m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "網格大小(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "風速(m/s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(194, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "風向( °)";
            // 
            // build_grid
            // 
            this.build_grid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.build_grid.Location = new System.Drawing.Point(471, 62);
            this.build_grid.Margin = new System.Windows.Forms.Padding(2);
            this.build_grid.Name = "build_grid";
            this.build_grid.Size = new System.Drawing.Size(99, 56);
            this.build_grid.TabIndex = 8;
            this.build_grid.Text = "建立網格";
            this.build_grid.UseVisualStyleBackColor = true;
            this.build_grid.Click += new System.EventHandler(this.build_grid_Click);
            // 
            // chimney_y
            // 
            this.chimney_y.Location = new System.Drawing.Point(261, 181);
            this.chimney_y.Margin = new System.Windows.Forms.Padding(2);
            this.chimney_y.Name = "chimney_y";
            this.chimney_y.ReadOnly = true;
            this.chimney_y.Size = new System.Drawing.Size(46, 22);
            this.chimney_y.TabIndex = 10;
            // 
            // chimney_z
            // 
            this.chimney_z.Location = new System.Drawing.Point(366, 180);
            this.chimney_z.Margin = new System.Windows.Forms.Padding(2);
            this.chimney_z.Name = "chimney_z";
            this.chimney_z.ReadOnly = true;
            this.chimney_z.Size = new System.Drawing.Size(46, 22);
            this.chimney_z.TabIndex = 11;
            // 
            // chimney_x
            // 
            this.chimney_x.Location = new System.Drawing.Point(161, 180);
            this.chimney_x.Margin = new System.Windows.Forms.Padding(2);
            this.chimney_x.Name = "chimney_x";
            this.chimney_x.ReadOnly = true;
            this.chimney_x.Size = new System.Drawing.Size(46, 22);
            this.chimney_x.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "煙囪位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "污染物排放率(g/s)";
            // 
            // emission
            // 
            this.emission.Location = new System.Drawing.Point(161, 218);
            this.emission.Margin = new System.Windows.Forms.Padding(2);
            this.emission.Name = "emission";
            this.emission.ReadOnly = true;
            this.emission.Size = new System.Drawing.Size(46, 22);
            this.emission.TabIndex = 12;
            // 
            // build_chimney
            // 
            this.build_chimney.Enabled = false;
            this.build_chimney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.build_chimney.Location = new System.Drawing.Point(471, 180);
            this.build_chimney.Margin = new System.Windows.Forms.Padding(2);
            this.build_chimney.Name = "build_chimney";
            this.build_chimney.Size = new System.Drawing.Size(99, 58);
            this.build_chimney.TabIndex = 13;
            this.build_chimney.Text = "建立煙囪";
            this.build_chimney.UseVisualStyleBackColor = true;
            this.build_chimney.Click += new System.EventHandler(this.build_chimney_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(8, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = " ";
            // 
            // chimney_info
            // 
            this.chimney_info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chimney_info.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chimney_info.Location = new System.Drawing.Point(15, 320);
            this.chimney_info.Margin = new System.Windows.Forms.Padding(2);
            this.chimney_info.Multiline = true;
            this.chimney_info.Name = "chimney_info";
            this.chimney_info.ReadOnly = true;
            this.chimney_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chimney_info.Size = new System.Drawing.Size(557, 203);
            this.chimney_info.TabIndex = 22;
            // 
            // Max_concentration
            // 
            this.Max_concentration.Enabled = false;
            this.Max_concentration.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Max_concentration.Location = new System.Drawing.Point(342, 263);
            this.Max_concentration.Margin = new System.Windows.Forms.Padding(2);
            this.Max_concentration.Name = "Max_concentration";
            this.Max_concentration.Size = new System.Drawing.Size(228, 39);
            this.Max_concentration.TabIndex = 23;
            this.Max_concentration.Text = "計算地面最大濃度位置";
            this.Max_concentration.UseVisualStyleBackColor = true;
            this.Max_concentration.Click += new System.EventHandler(this.Max_concentration_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(134, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "X :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(234, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Y :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(339, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Z :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(128, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "dx :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(227, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "dy :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(333, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "dz :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(128, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "X :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(234, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Y :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(339, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Z :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 536);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Max_concentration);
            this.Controls.Add(this.chimney_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.build_chimney);
            this.Controls.Add(this.emission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chimney_y);
            this.Controls.Add(this.chimney_z);
            this.Controls.Add(this.chimney_x);
            this.Controls.Add(this.build_grid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wind_direction);
            this.Controls.Add(this.wind_speed);
            this.Controls.Add(this.dy);
            this.Controls.Add(this.dz);
            this.Controls.Add(this.range_Y);
            this.Controls.Add(this.range_Z);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.range_X);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox range_X;
        private System.Windows.Forms.TextBox dx;
        private System.Windows.Forms.TextBox range_Z;
        private System.Windows.Forms.TextBox range_Y;
        private System.Windows.Forms.TextBox dz;
        private System.Windows.Forms.TextBox dy;
        private System.Windows.Forms.TextBox wind_speed;
        private System.Windows.Forms.TextBox wind_direction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button build_grid;
        private System.Windows.Forms.TextBox chimney_y;
        private System.Windows.Forms.TextBox chimney_z;
        private System.Windows.Forms.TextBox chimney_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emission;
        private System.Windows.Forms.Button build_chimney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chimney_info;
        private System.Windows.Forms.Button Max_concentration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

