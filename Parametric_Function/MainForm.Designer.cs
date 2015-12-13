namespace Parametric_Function
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.XInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.XTree = new System.Windows.Forms.Button();
            this.YTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StepBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // XInput
            // 
            this.XInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XInput.Location = new System.Drawing.Point(879, 12);
            this.XInput.Name = "XInput";
            this.XInput.Size = new System.Drawing.Size(131, 29);
            this.XInput.TabIndex = 0;
            this.XInput.Text = "16*sin(t)^3";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(847, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y = ";
            // 
            // YInput
            // 
            this.YInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YInput.Location = new System.Drawing.Point(879, 51);
            this.YInput.Name = "YInput";
            this.YInput.Size = new System.Drawing.Size(131, 29);
            this.YInput.TabIndex = 2;
            this.YInput.Text = "13*cos(t)-5*cos(2*t)-2*cos(3*t)-cos(4*t)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(851, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Parsing_Click);
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(12, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(829, 573);
            this.PicBox.TabIndex = 6;
            this.PicBox.TabStop = false;
            // 
            // XTree
            // 
            this.XTree.Image = ((System.Drawing.Image)(resources.GetObject("XTree.Image")));
            this.XTree.Location = new System.Drawing.Point(1016, 12);
            this.XTree.Name = "XTree";
            this.XTree.Size = new System.Drawing.Size(41, 33);
            this.XTree.TabIndex = 8;
            this.XTree.UseVisualStyleBackColor = true;
            this.XTree.Click += new System.EventHandler(this.XTree_Click);
            // 
            // YTree
            // 
            this.YTree.Image = ((System.Drawing.Image)(resources.GetObject("YTree.Image")));
            this.YTree.Location = new System.Drawing.Point(1016, 51);
            this.YTree.Name = "YTree";
            this.YTree.Size = new System.Drawing.Size(41, 33);
            this.YTree.TabIndex = 9;
            this.YTree.UseVisualStyleBackColor = true;
            this.YTree.Click += new System.EventHandler(this.YTree_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(847, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "X = ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1012, 90);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 495);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(852, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "t = ";
            // 
            // StartBox
            // 
            this.StartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBox.Location = new System.Drawing.Point(875, 86);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(36, 29);
            this.StartBox.TabIndex = 12;
            this.StartBox.Text = "0";
            // 
            // EndBox
            // 
            this.EndBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndBox.Location = new System.Drawing.Point(917, 86);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(36, 29);
            this.EndBox.TabIndex = 14;
            this.EndBox.Text = "65";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(911, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = ";";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(852, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Шаг = ";
            // 
            // StepBox
            // 
            this.StepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepBox.Location = new System.Drawing.Point(917, 121);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(36, 29);
            this.StepBox.TabIndex = 17;
            this.StepBox.Text = "0,1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YTree);
            this.Controls.Add(this.XTree);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YInput);
            this.Controls.Add(this.XInput);
            this.Name = "Form1";
            this.Text = "График параметрической функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button XTree;
        private System.Windows.Forms.Button YTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StepBox;
    }
}

