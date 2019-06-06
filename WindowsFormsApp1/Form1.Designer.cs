namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // btnHashear
            // 
            this.btnHashear.Location = new System.Drawing.Point(363, 253);
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
            this.button1.Location = new System.Drawing.Point(363, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Unhash Texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 420);
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
    }
}

