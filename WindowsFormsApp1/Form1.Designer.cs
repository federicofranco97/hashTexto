﻿namespace WindowsFormsApp1
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
            this.btnHashear = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outPutText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numdb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHashear
            // 
            this.btnHashear.Location = new System.Drawing.Point(258, 260);
            this.btnHashear.Name = "btnHashear";
            this.btnHashear.Size = new System.Drawing.Size(149, 48);
            this.btnHashear.TabIndex = 0;
            this.btnHashear.Text = "Hashear Texto";
            this.btnHashear.UseVisualStyleBackColor = true;
            this.btnHashear.Click += new System.EventHandler(this.btnHashear_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(76, 111);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(302, 114);
            this.inputText.TabIndex = 1;
            // 
            // outPutText
            // 
            this.outPutText.Location = new System.Drawing.Point(499, 111);
            this.outPutText.Multiline = true;
            this.outPutText.Name = "outPutText";
            this.outPutText.Size = new System.Drawing.Size(302, 114);
            this.outPutText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto Output";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Unhash Texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar db";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // numdb
            // 
            this.numdb.Location = new System.Drawing.Point(598, 265);
            this.numdb.Multiline = true;
            this.numdb.Name = "numdb";
            this.numdb.Size = new System.Drawing.Size(131, 43);
            this.numdb.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 420);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numdb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outPutText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.btnHashear);
            this.Name = "Form1";
            this.Text = "Hash Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHashear;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outPutText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numdb;
        private System.Windows.Forms.Button button3;
    }
}

