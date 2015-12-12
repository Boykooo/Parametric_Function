namespace Parametric_Function
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.XInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.XTree = new System.Windows.Forms.Button();
            this.YTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // XInput
            // 
            this.XInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XInput.Location = new System.Drawing.Point(879, 12);
            this.XInput.Name = "XInput";
            this.XInput.Size = new System.Drawing.Size(131, 29);
            this.XInput.TabIndex = 0;
            this.XInput.Text = "cos(3*t+1)";
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
            this.YInput.Text = "sin(t)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(894, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Parsing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Parsing_Click);
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(12, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(834, 573);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YTree);
            this.Controls.Add(this.XTree);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YInput);
            this.Controls.Add(this.XInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
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
    }
}

