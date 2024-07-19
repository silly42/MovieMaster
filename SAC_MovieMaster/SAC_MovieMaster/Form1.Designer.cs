namespace SAC_MovieMaster
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
            lstViewCSV = new ListView();
            lstWatched = new ListView();
            btnRead = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // lstViewCSV
            // 
            lstViewCSV.Location = new Point(12, 41);
            lstViewCSV.Name = "lstViewCSV";
            lstViewCSV.Size = new Size(410, 397);
            lstViewCSV.TabIndex = 0;
            lstViewCSV.UseCompatibleStateImageBehavior = false;
            // 
            // lstWatched
            // 
            lstWatched.Location = new Point(428, 12);
            lstWatched.Name = "lstWatched";
            lstWatched.Size = new Size(360, 167);
            lstWatched.TabIndex = 1;
            lstWatched.UseCompatibleStateImageBehavior = false;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(348, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(74, 25);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read*";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(632, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 52);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(330, 23);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "Search here";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnRead);
            Controls.Add(lstWatched);
            Controls.Add(lstViewCSV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstViewCSV;
        private ListView lstWatched;
        private Button btnRead;
        private Button btnAdd;
        private TextBox txtSearch;
    }
}
