using System;

namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.NumericUpDown();
            this.txtNum2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(389, 57);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(345, 30);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(389, 149);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(345, 30);
            this.txtNum2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operation";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 22;
            this.listBox.Items.AddRange(new object[] {
            "Add",
            "Minus",
            "Multiply",
            "Divide"});
            this.listBox.Location = new System.Drawing.Point(620, 250);
            this.listBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(114, 26);
            this.listBox.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(300, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNum1;
        private System.Windows.Forms.NumericUpDown txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnSubmit;
    }
}

