namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.empty = new System.Windows.Forms.Label();
            this.tplace = new System.Windows.Forms.Label();
            this.eplace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(30, 54);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(30, 92);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(30, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 229);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(451, 58);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(67, 15);
            this.total.TabIndex = 3;
            this.total.Text = "total places";
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.Location = new System.Drawing.Point(451, 100);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(77, 15);
            this.empty.TabIndex = 4;
            this.empty.Text = "empty places";
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // tplace
            // 
            this.tplace.AutoSize = true;
            this.tplace.Location = new System.Drawing.Point(548, 58);
            this.tplace.Name = "tplace";
            this.tplace.Size = new System.Drawing.Size(19, 15);
            this.tplace.TabIndex = 5;
            this.tplace.Text = "10";
            // 
            // eplace
            // 
            this.eplace.AutoSize = true;
            this.eplace.Location = new System.Drawing.Point(548, 100);
            this.eplace.Name = "eplace";
            this.eplace.Size = new System.Drawing.Size(19, 15);
            this.eplace.TabIndex = 6;
            this.eplace.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 413);
            this.Controls.Add(this.eplace);
            this.Controls.Add(this.tplace);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.total);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enter;
        private Button exit;
        private ListBox listBox1;
        private Label total;
        private Label empty;
        private Label tplace;
        private Label eplace;
    }
}