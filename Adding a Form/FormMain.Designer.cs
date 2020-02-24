namespace Adding_a_Form
{
    partial class FormMain
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
            this.btnAddNames = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnRemoveNames = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNames
            // 
            this.btnAddNames.Location = new System.Drawing.Point(12, 12);
            this.btnAddNames.Name = "btnAddNames";
            this.btnAddNames.Size = new System.Drawing.Size(106, 23);
            this.btnAddNames.TabIndex = 0;
            this.btnAddNames.Text = "Add Names";
            this.btnAddNames.UseVisualStyleBackColor = true;
            this.btnAddNames.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(12, 41);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(106, 23);
            this.btnEditName.TabIndex = 1;
            this.btnEditName.Text = "Edit Name";
            this.btnEditName.UseVisualStyleBackColor = true;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(124, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(151, 199);
            this.lstNames.TabIndex = 2;
            // 
            // btnRemoveNames
            // 
            this.btnRemoveNames.Location = new System.Drawing.Point(13, 70);
            this.btnRemoveNames.Name = "btnRemoveNames";
            this.btnRemoveNames.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveNames.TabIndex = 3;
            this.btnRemoveNames.Text = "Remove Names";
            this.btnRemoveNames.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(13, 188);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(105, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 219);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemoveNames);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnAddNames);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNames;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnRemoveNames;
        private System.Windows.Forms.Button btnQuit;
    }
}

