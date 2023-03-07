namespace Project
{
    partial class Form2
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            textBox1 = new System.Windows.Forms.TextBox();
            DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            Saturday = new System.Windows.Forms.Label();
            Friday = new System.Windows.Forms.Label();
            Thursday = new System.Windows.Forms.Label();
            Wednesday = new System.Windows.Forms.Label();
            Tuesday = new System.Windows.Forms.Label();
            Monday = new System.Windows.Forms.Label();
            Sunday = new System.Windows.Forms.Label();
            Next = new System.Windows.Forms.Button();
            Prev = new System.Windows.Forms.Button();
            Monthly_Acc = new System.Windows.Forms.ListBox();
            Monthly_listBox1 = new System.Windows.Forms.ListBox();
            Delete_btn = new System.Windows.Forms.Button();
            Add_btn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(DayContainer);
            splitContainer1.Panel1.Controls.Add(Saturday);
            splitContainer1.Panel1.Controls.Add(Friday);
            splitContainer1.Panel1.Controls.Add(Thursday);
            splitContainer1.Panel1.Controls.Add(Wednesday);
            splitContainer1.Panel1.Controls.Add(Tuesday);
            splitContainer1.Panel1.Controls.Add(Monday);
            splitContainer1.Panel1.Controls.Add(Sunday);
            splitContainer1.Panel1.Controls.Add(Next);
            splitContainer1.Panel1.Controls.Add(Prev);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Monthly_Acc);
            splitContainer1.Panel2.Controls.Add(Monthly_listBox1);
            splitContainer1.Panel2.Controls.Add(Delete_btn);
            splitContainer1.Panel2.Controls.Add(Add_btn);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new System.Drawing.Size(984, 651);
            splitContainer1.SplitterDistance = 640;
            splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(273, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(91, 40);
            textBox1.TabIndex = 6;
            textBox1.Text = "1";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DayContainer
            // 
            DayContainer.Location = new System.Drawing.Point(0, 100);
            DayContainer.Name = "DayContainer";
            DayContainer.Size = new System.Drawing.Size(640, 540);
            DayContainer.TabIndex = 16;
            // 
            // Saturday
            // 
            Saturday.AutoSize = true;
            Saturday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Saturday.ForeColor = System.Drawing.Color.RoyalBlue;
            Saturday.Location = new System.Drawing.Point(557, 54);
            Saturday.Name = "Saturday";
            Saturday.Size = new System.Drawing.Size(69, 43);
            Saturday.TabIndex = 15;
            Saturday.Text = "SAT";
            // 
            // Friday
            // 
            Friday.AutoSize = true;
            Friday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Friday.Location = new System.Drawing.Point(479, 54);
            Friday.Name = "Friday";
            Friday.Size = new System.Drawing.Size(58, 43);
            Friday.TabIndex = 14;
            Friday.Text = "FRI";
            // 
            // Thursday
            // 
            Thursday.AutoSize = true;
            Thursday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Thursday.Location = new System.Drawing.Point(387, 54);
            Thursday.Name = "Thursday";
            Thursday.Size = new System.Drawing.Size(71, 43);
            Thursday.TabIndex = 13;
            Thursday.Text = "THR";
            // 
            // Wednesday
            // 
            Wednesday.AutoSize = true;
            Wednesday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Wednesday.Location = new System.Drawing.Point(286, 53);
            Wednesday.Name = "Wednesday";
            Wednesday.Size = new System.Drawing.Size(78, 43);
            Wednesday.TabIndex = 12;
            Wednesday.Text = "WED";
            // 
            // Tuesday
            // 
            Tuesday.AutoSize = true;
            Tuesday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Tuesday.Location = new System.Drawing.Point(197, 54);
            Tuesday.Name = "Tuesday";
            Tuesday.Size = new System.Drawing.Size(70, 43);
            Tuesday.TabIndex = 11;
            Tuesday.Text = "TUE";
            // 
            // Monday
            // 
            Monday.AutoSize = true;
            Monday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Monday.Location = new System.Drawing.Point(100, 53);
            Monday.Name = "Monday";
            Monday.Size = new System.Drawing.Size(80, 43);
            Monday.TabIndex = 10;
            Monday.Text = "MON";
            // 
            // Sunday
            // 
            Sunday.AutoSize = true;
            Sunday.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Sunday.ForeColor = System.Drawing.Color.Red;
            Sunday.Location = new System.Drawing.Point(12, 54);
            Sunday.Name = "Sunday";
            Sunday.Size = new System.Drawing.Size(72, 43);
            Sunday.TabIndex = 9;
            Sunday.Text = "SUN";
            // 
            // Next
            // 
            Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Next.Location = new System.Drawing.Point(370, 7);
            Next.Name = "Next";
            Next.Size = new System.Drawing.Size(46, 43);
            Next.TabIndex = 8;
            Next.Text = "▶";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Prev
            // 
            Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Prev.Location = new System.Drawing.Point(221, 7);
            Prev.Name = "Prev";
            Prev.Size = new System.Drawing.Size(46, 43);
            Prev.TabIndex = 7;
            Prev.Text = "◀";
            Prev.UseVisualStyleBackColor = true;
            Prev.Click += Prev_Click;
            // 
            // Monthly_Acc
            // 
            Monthly_Acc.FormattingEnabled = true;
            Monthly_Acc.ItemHeight = 16;
            Monthly_Acc.Location = new System.Drawing.Point(12, 353);
            Monthly_Acc.Name = "Monthly_Acc";
            Monthly_Acc.Size = new System.Drawing.Size(316, 212);
            Monthly_Acc.TabIndex = 4;
            // 
            // Monthly_listBox1
            // 
            Monthly_listBox1.FormattingEnabled = true;
            Monthly_listBox1.ItemHeight = 16;
            Monthly_listBox1.Location = new System.Drawing.Point(12, 70);
            Monthly_listBox1.Name = "Monthly_listBox1";
            Monthly_listBox1.Size = new System.Drawing.Size(316, 228);
            Monthly_listBox1.TabIndex = 4;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = System.Drawing.Color.White;
            Delete_btn.FlatAppearance.BorderSize = 0;
            Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Delete_btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Delete_btn.Location = new System.Drawing.Point(189, 582);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new System.Drawing.Size(112, 42);
            Delete_btn.TabIndex = 3;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = System.Drawing.Color.White;
            Add_btn.FlatAppearance.BorderSize = 0;
            Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Add_btn.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Add_btn.Location = new System.Drawing.Point(37, 582);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new System.Drawing.Size(112, 42);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(77, 329);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 21);
            label2.TabIndex = 1;
            label2.Text = "Monthly Account Book";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(99, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 21);
            label1.TabIndex = 1;
            label1.Text = "Monthly Schedule";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 651);
            Controls.Add(splitContainer1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Form_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.ListBox Monthly_listBox1;
        private System.Windows.Forms.ListBox Monthly_Acc;
    }
}