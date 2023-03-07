using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    partial class Form3
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
            listBox3 = new System.Windows.Forms.ListBox();
            listBox2 = new System.Windows.Forms.ListBox();
            listBox1 = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new System.Drawing.Point(6, 496);
            listBox3.Name = "listBox3";
            listBox3.Size = new System.Drawing.Size(318, 109);
            listBox3.TabIndex = 12;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(6, 340);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(318, 109);
            listBox2.TabIndex = 13;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(6, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(318, 244);
            listBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(6, 468);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 25);
            label3.TabIndex = 9;
            label3.Text = "Account Book";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(6, 312);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 25);
            label2.TabIndex = 10;
            label2.Text = "Memo";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(6, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 25);
            label1.TabIndex = 11;
            label1.Text = "Schedule";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(332, 641);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}