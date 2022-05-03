
namespace TestAd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickImage = new System.Windows.Forms.PictureBox();
            this.refreshClick = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxThreeInterval = new System.Windows.Forms.TextBox();
            this.textBoxTwoInterval = new System.Windows.Forms.TextBox();
            this.textBoxOneInterval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxThreeClick = new System.Windows.Forms.TextBox();
            this.textBoxTwoClick = new System.Windows.Forms.TextBox();
            this.textBoxOneClick = new System.Windows.Forms.TextBox();
            this.textBoxThreeOutput = new System.Windows.Forms.TextBox();
            this.textBoxTwoOutput = new System.Windows.Forms.TextBox();
            this.textBoxOneOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clickImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshClick)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickImage
            // 
            this.clickImage.Location = new System.Drawing.Point(14, 14);
            this.clickImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clickImage.Name = "clickImage";
            this.clickImage.Size = new System.Drawing.Size(355, 245);
            this.clickImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickImage.TabIndex = 0;
            this.clickImage.TabStop = false;
            this.clickImage.Click += new System.EventHandler(this.clickImage_Click);
            // 
            // refreshClick
            // 
            this.refreshClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshClick.Image = global::TestAd.Properties.Resources.refresh_icon_png_2;
            this.refreshClick.Location = new System.Drawing.Point(159, 263);
            this.refreshClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshClick.Name = "refreshClick";
            this.refreshClick.Size = new System.Drawing.Size(46, 75);
            this.refreshClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshClick.TabIndex = 1;
            this.refreshClick.TabStop = false;
            this.refreshClick.Click += new System.EventHandler(this.refreshClick_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clickImage);
            this.panel1.Controls.Add(this.refreshClick);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 346);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(398, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 346);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxThreeInterval);
            this.groupBox2.Controls.Add(this.textBoxTwoInterval);
            this.groupBox2.Controls.Add(this.textBoxOneInterval);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(2, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(370, 105);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Доверительный интервал";
            // 
            // textBoxThreeInterval
            // 
            this.textBoxThreeInterval.Location = new System.Drawing.Point(104, 78);
            this.textBoxThreeInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThreeInterval.Name = "textBoxThreeInterval";
            this.textBoxThreeInterval.ReadOnly = true;
            this.textBoxThreeInterval.Size = new System.Drawing.Size(76, 23);
            this.textBoxThreeInterval.TabIndex = 5;
            // 
            // textBoxTwoInterval
            // 
            this.textBoxTwoInterval.Location = new System.Drawing.Point(104, 52);
            this.textBoxTwoInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTwoInterval.Name = "textBoxTwoInterval";
            this.textBoxTwoInterval.ReadOnly = true;
            this.textBoxTwoInterval.Size = new System.Drawing.Size(76, 23);
            this.textBoxTwoInterval.TabIndex = 4;
            // 
            // textBoxOneInterval
            // 
            this.textBoxOneInterval.Location = new System.Drawing.Point(104, 24);
            this.textBoxOneInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOneInterval.Name = "textBoxOneInterval";
            this.textBoxOneInterval.ReadOnly = true;
            this.textBoxOneInterval.Size = new System.Drawing.Size(76, 23);
            this.textBoxOneInterval.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "3 баннер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "2 баннер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "1 баннер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxThreeClick);
            this.groupBox1.Controls.Add(this.textBoxTwoClick);
            this.groupBox1.Controls.Add(this.textBoxOneClick);
            this.groupBox1.Controls.Add(this.textBoxThreeOutput);
            this.groupBox1.Controls.Add(this.textBoxTwoOutput);
            this.groupBox1.Controls.Add(this.textBoxOneOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(2, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(370, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основная статистика";
            // 
            // textBoxThreeClick
            // 
            this.textBoxThreeClick.Location = new System.Drawing.Point(337, 83);
            this.textBoxThreeClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThreeClick.Name = "textBoxThreeClick";
            this.textBoxThreeClick.ReadOnly = true;
            this.textBoxThreeClick.Size = new System.Drawing.Size(33, 23);
            this.textBoxThreeClick.TabIndex = 11;
            // 
            // textBoxTwoClick
            // 
            this.textBoxTwoClick.Location = new System.Drawing.Point(337, 50);
            this.textBoxTwoClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTwoClick.Name = "textBoxTwoClick";
            this.textBoxTwoClick.ReadOnly = true;
            this.textBoxTwoClick.Size = new System.Drawing.Size(33, 23);
            this.textBoxTwoClick.TabIndex = 10;
            // 
            // textBoxOneClick
            // 
            this.textBoxOneClick.Location = new System.Drawing.Point(337, 18);
            this.textBoxOneClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOneClick.Name = "textBoxOneClick";
            this.textBoxOneClick.ReadOnly = true;
            this.textBoxOneClick.Size = new System.Drawing.Size(33, 23);
            this.textBoxOneClick.TabIndex = 9;
            // 
            // textBoxThreeOutput
            // 
            this.textBoxThreeOutput.Location = new System.Drawing.Point(161, 78);
            this.textBoxThreeOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThreeOutput.Name = "textBoxThreeOutput";
            this.textBoxThreeOutput.ReadOnly = true;
            this.textBoxThreeOutput.Size = new System.Drawing.Size(33, 23);
            this.textBoxThreeOutput.TabIndex = 8;
            // 
            // textBoxTwoOutput
            // 
            this.textBoxTwoOutput.Location = new System.Drawing.Point(161, 47);
            this.textBoxTwoOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTwoOutput.Name = "textBoxTwoOutput";
            this.textBoxTwoOutput.ReadOnly = true;
            this.textBoxTwoOutput.Size = new System.Drawing.Size(33, 23);
            this.textBoxTwoOutput.TabIndex = 7;
            // 
            // textBoxOneOutput
            // 
            this.textBoxOneOutput.Location = new System.Drawing.Point(161, 17);
            this.textBoxOneOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOneOutput.Name = "textBoxOneOutput";
            this.textBoxOneOutput.ReadOnly = true;
            this.textBoxOneOutput.Size = new System.Drawing.Size(33, 23);
            this.textBoxOneOutput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Появлений 2 баннера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кликов на 3 баннер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Появлений 1 баннера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кликов на 2 баннер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Появлений 3 баннера";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кликов на 1 баннер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Демонстрация стратегии на примере";
            ((System.ComponentModel.ISupportInitialize)(this.clickImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshClick)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox clickImage;
        private System.Windows.Forms.PictureBox refreshClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxThreeClick;
        private System.Windows.Forms.TextBox textBoxTwoClick;
        private System.Windows.Forms.TextBox textBoxOneClick;
        private System.Windows.Forms.TextBox textBoxThreeOutput;
        private System.Windows.Forms.TextBox textBoxTwoOutput;
        private System.Windows.Forms.TextBox textBoxOneOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxThreeInterval;
        private System.Windows.Forms.TextBox textBoxTwoInterval;
        private System.Windows.Forms.TextBox textBoxOneInterval;
    }
}

