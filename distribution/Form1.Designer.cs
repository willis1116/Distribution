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
            this.SuspendLayout();
            // 
            // range_X
            // 
            this.range_X.Location = new System.Drawing.Point(126, 43);
            this.range_X.Name = "range_X";
            this.range_X.Size = new System.Drawing.Size(60, 25);
            this.range_X.TabIndex = 0;
            this.range_X.TextChanged += new System.EventHandler(this.range_X_TextChanged);
            // 
            // dx
            // 
            this.dx.Location = new System.Drawing.Point(126, 105);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(60, 25);
            this.dx.TabIndex = 3;
            this.dx.TextChanged += new System.EventHandler(this.dx_TextChanged);
            // 
            // range_Z
            // 
            this.range_Z.Location = new System.Drawing.Point(355, 43);
            this.range_Z.Name = "range_Z";
            this.range_Z.Size = new System.Drawing.Size(60, 25);
            this.range_Z.TabIndex = 2;
            this.range_Z.TextChanged += new System.EventHandler(this.range_Z_TextChanged);
            // 
            // range_Y
            // 
            this.range_Y.Location = new System.Drawing.Point(238, 43);
            this.range_Y.Name = "range_Y";
            this.range_Y.Size = new System.Drawing.Size(60, 25);
            this.range_Y.TabIndex = 1;
            this.range_Y.TextChanged += new System.EventHandler(this.range_Y_TextChanged);
            // 
            // dz
            // 
            this.dz.Location = new System.Drawing.Point(355, 105);
            this.dz.Name = "dz";
            this.dz.Size = new System.Drawing.Size(60, 25);
            this.dz.TabIndex = 5;
            this.dz.TextChanged += new System.EventHandler(this.dz_TextChanged);
            // 
            // dy
            // 
            this.dy.Location = new System.Drawing.Point(238, 105);
            this.dy.Name = "dy";
            this.dy.Size = new System.Drawing.Size(60, 25);
            this.dy.TabIndex = 4;
            this.dy.TextChanged += new System.EventHandler(this.dy_TextChanged);
            // 
            // wind_speed
            // 
            this.wind_speed.Location = new System.Drawing.Point(126, 174);
            this.wind_speed.Name = "wind_speed";
            this.wind_speed.Size = new System.Drawing.Size(60, 25);
            this.wind_speed.TabIndex = 6;
            this.wind_speed.TextChanged += new System.EventHandler(this.wind_speed_TextChanged);
            // 
            // wind_direction
            // 
            this.wind_direction.Location = new System.Drawing.Point(355, 174);
            this.wind_direction.Name = "wind_direction";
            this.wind_direction.Size = new System.Drawing.Size(60, 25);
            this.wind_direction.TabIndex = 7;
            this.wind_direction.TextChanged += new System.EventHandler(this.wind_direction_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "網格範圍(m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "網格大小(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "風速(m/s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(235, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "風向( °)";
            // 
            // build_grid
            // 
            this.build_grid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.build_grid.Location = new System.Drawing.Point(535, 89);
            this.build_grid.Name = "build_grid";
            this.build_grid.Size = new System.Drawing.Size(132, 70);
            this.build_grid.TabIndex = 8;
            this.build_grid.Text = "建立網格";
            this.build_grid.UseVisualStyleBackColor = true;
            this.build_grid.Click += new System.EventHandler(this.build_grid_Click);
            // 
            // chimney_y
            // 
            this.chimney_y.Location = new System.Drawing.Point(213, 260);
            this.chimney_y.Name = "chimney_y";
            this.chimney_y.ReadOnly = true;
            this.chimney_y.Size = new System.Drawing.Size(60, 25);
            this.chimney_y.TabIndex = 10;
            // 
            // chimney_z
            // 
            this.chimney_z.Location = new System.Drawing.Point(330, 260);
            this.chimney_z.Name = "chimney_z";
            this.chimney_z.ReadOnly = true;
            this.chimney_z.Size = new System.Drawing.Size(60, 25);
            this.chimney_z.TabIndex = 11;
            // 
            // chimney_x
            // 
            this.chimney_x.Location = new System.Drawing.Point(101, 260);
            this.chimney_x.Name = "chimney_x";
            this.chimney_x.ReadOnly = true;
            this.chimney_x.Size = new System.Drawing.Size(60, 25);
            this.chimney_x.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "煙囪位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(405, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "污染物排放率(g/s)";
            // 
            // emission
            // 
            this.emission.Location = new System.Drawing.Point(535, 260);
            this.emission.Name = "emission";
            this.emission.ReadOnly = true;
            this.emission.Size = new System.Drawing.Size(60, 25);
            this.emission.TabIndex = 12;
            // 
            // build_chimney
            // 
            this.build_chimney.Enabled = false;
            this.build_chimney.Location = new System.Drawing.Point(628, 256);
            this.build_chimney.Name = "build_chimney";
            this.build_chimney.Size = new System.Drawing.Size(93, 35);
            this.build_chimney.TabIndex = 13;
            this.build_chimney.Text = "建立煙囪";
            this.build_chimney.UseVisualStyleBackColor = true;
            this.build_chimney.Click += new System.EventHandler(this.build_chimney_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = " ";
            // 
            // chimney_info
            // 
            this.chimney_info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chimney_info.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chimney_info.Location = new System.Drawing.Point(38, 357);
            this.chimney_info.Multiline = true;
            this.chimney_info.Name = "chimney_info";
            this.chimney_info.ReadOnly = true;
            this.chimney_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chimney_info.Size = new System.Drawing.Size(644, 210);
            this.chimney_info.TabIndex = 22;
            // 
            // Max_concentration
            // 
            this.Max_concentration.Enabled = false;
            this.Max_concentration.Location = new System.Drawing.Point(212, 306);
            this.Max_concentration.Name = "Max_concentration";
            this.Max_concentration.Size = new System.Drawing.Size(305, 35);
            this.Max_concentration.TabIndex = 23;
            this.Max_concentration.Text = "計算最大濃度位置";
            this.Max_concentration.UseVisualStyleBackColor = true;
            this.Max_concentration.Click += new System.EventHandler(this.Max_concentration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 596);
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
    }
}

