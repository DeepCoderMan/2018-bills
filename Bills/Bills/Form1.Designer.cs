namespace Bills
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.billsList = new Bills.billsList();
            this.glassButton1 = new CommonUI.Buttons.GlassButton();
            this.roundButton1 = new CommonUI.Buttons.RoundButton();
            this.Refresh = new CommonUI.Buttons.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundButton2 = new CommonUI.Buttons.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Version.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Version.Location = new System.Drawing.Point(3, 2);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(40, 16);
            this.Version.TabIndex = 0;
            this.Version.Text = "hahh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 20);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnMin
            // 
            this.btnMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Bills.Properties.Resources.Close_up_24px_1181430_easyicon_net;
            this.btnMin.Location = new System.Drawing.Point(945, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 19);
            this.btnMin.TabIndex = 2;
            this.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Bills.Properties.Resources.close_24px_1181428_easyicon_net;
            this.btnClose.Location = new System.Drawing.Point(977, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 19);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // billsList
            // 
            this.billsList.BackColor = System.Drawing.Color.RosyBrown;
            this.billsList.data = ((object)(resources.GetObject("billsList.data")));
            this.billsList.Location = new System.Drawing.Point(518, 116);
            this.billsList.Name = "billsList";
            this.billsList.Size = new System.Drawing.Size(491, 390);
            this.billsList.TabIndex = 4;
            // 
            // glassButton1
            // 
            this.glassButton1.Location = new System.Drawing.Point(12, 437);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(153, 41);
            this.glassButton1.TabIndex = 5;
            this.glassButton1.Text = "glassButton1";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundButton1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton1.Location = new System.Drawing.Point(100, 2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.RecessDepth = 0;
            this.roundButton1.Size = new System.Drawing.Size(72, 50);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "Setting";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Refresh.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refresh.Location = new System.Drawing.Point(363, 3);
            this.Refresh.Name = "Refresh";
            this.Refresh.RecessDepth = 0;
            this.Refresh.Size = new System.Drawing.Size(69, 50);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.roundButton2);
            this.panel2.Controls.Add(this.Refresh);
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 56);
            this.panel2.TabIndex = 8;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.OliveDrab;
            this.roundButton2.Location = new System.Drawing.Point(6, 2);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.RecessDepth = 0;
            this.roundButton2.Size = new System.Drawing.Size(72, 50);
            this.roundButton2.TabIndex = 8;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 506);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.billsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private billsList billsList;
        private CommonUI.Buttons.GlassButton glassButton1;
        private System.Windows.Forms.Label label1;
        private CommonUI.Buttons.RoundButton roundButton1;
        private CommonUI.Buttons.RoundButton Refresh;
        private System.Windows.Forms.Panel panel2;
        private CommonUI.Buttons.RoundButton roundButton2;
    }
}

