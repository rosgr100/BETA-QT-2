namespace MusicBeePlugin
{
    partial class ConfigurationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.priorityWordsTextBox = new System.Windows.Forms.TextBox();
            this.savePriorityWordsBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aboytLbl = new System.Windows.Forms.Label();
            this.tableRemoveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagTable = new System.Windows.Forms.DataGridView();
            this.tableTagField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableValueField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tagTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Append in front (Separate by comma)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // priorityWordsTextBox
            // 
            this.priorityWordsTextBox.AllowDrop = true;
            this.priorityWordsTextBox.BackColor = System.Drawing.Color.White;
            this.priorityWordsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priorityWordsTextBox.Location = new System.Drawing.Point(12, 299);
            this.priorityWordsTextBox.MaximumSize = new System.Drawing.Size(800, 27);
            this.priorityWordsTextBox.MinimumSize = new System.Drawing.Size(100, 25);
            this.priorityWordsTextBox.Name = "priorityWordsTextBox";
            this.priorityWordsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.priorityWordsTextBox.Size = new System.Drawing.Size(695, 25);
            this.priorityWordsTextBox.TabIndex = 9;
            // 
            // savePriorityWordsBtn
            // 
            this.savePriorityWordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savePriorityWordsBtn.Location = new System.Drawing.Point(621, 382);
            this.savePriorityWordsBtn.Name = "savePriorityWordsBtn";
            this.savePriorityWordsBtn.Size = new System.Drawing.Size(86, 32);
            this.savePriorityWordsBtn.TabIndex = 8;
            this.savePriorityWordsBtn.Text = "Save Words";
            this.savePriorityWordsBtn.UseVisualStyleBackColor = true;
            this.savePriorityWordsBtn.Click += new System.EventHandler(this.savePriorityWordsBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTE: Restart the program to ensure all changes are applied.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // aboytLbl
            // 
            this.aboytLbl.AutoSize = true;
            this.aboytLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboytLbl.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboytLbl.Location = new System.Drawing.Point(12, 420);
            this.aboytLbl.Name = "aboytLbl";
            this.aboytLbl.Size = new System.Drawing.Size(162, 17);
            this.aboytLbl.TabIndex = 6;
            this.aboytLbl.Text = "QuickTagger by SpirosG -";
            this.aboytLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableRemoveBtn
            // 
            this.tableRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tableRemoveBtn.Location = new System.Drawing.Point(769, 296);
            this.tableRemoveBtn.Name = "tableRemoveBtn";
            this.tableRemoveBtn.Size = new System.Drawing.Size(30, 30);
            this.tableRemoveBtn.TabIndex = 4;
            this.tableRemoveBtn.Text = "-";
            this.tableRemoveBtn.UseVisualStyleBackColor = true;
            this.tableRemoveBtn.Click += new System.EventHandler(this.tableRemoveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Location = new System.Drawing.Point(713, 420);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 34);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(621, 420);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableAddBtn
            // 
            this.tableAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tableAddBtn.Location = new System.Drawing.Point(733, 296);
            this.tableAddBtn.Name = "tableAddBtn";
            this.tableAddBtn.Size = new System.Drawing.Size(30, 30);
            this.tableAddBtn.TabIndex = 3;
            this.tableAddBtn.Text = "+";
            this.tableAddBtn.UseVisualStyleBackColor = true;
            this.tableAddBtn.Click += new System.EventHandler(this.tableAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tags: ";
            // 
            // tagTable
            // 
            this.tagTable.AllowUserToAddRows = false;
            this.tagTable.AllowUserToDeleteRows = false;
            this.tagTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableTagField,
            this.tableValueField});
            this.tagTable.Location = new System.Drawing.Point(12, 33);
            this.tagTable.MultiSelect = false;
            this.tagTable.Name = "tagTable";
            this.tagTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tagTable.Size = new System.Drawing.Size(787, 257);
            this.tagTable.TabIndex = 1;
            // 
            // tableTagField
            // 
            this.tableTagField.HeaderText = "Tag Name";
            this.tableTagField.Name = "tableTagField";
            this.tableTagField.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTagField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tableTagField.Width = 130;
            // 
            // tableValueField
            // 
            this.tableValueField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableValueField.HeaderText = "Values (separate using semicolon)";
            this.tableValueField.Name = "tableValueField";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(811, 466);
            this.Controls.Add(this.priorityWordsTextBox);
            this.Controls.Add(this.aboytLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savePriorityWordsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableRemoveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tableAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tagTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quick Tagger Configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tagTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tableAddBtn;
        private System.Windows.Forms.Button tableRemoveBtn;
        private System.Windows.Forms.Label aboytLbl;
        private System.Windows.Forms.DataGridViewComboBoxColumn tableTagField;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableValueField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button savePriorityWordsBtn;
        private System.Windows.Forms.TextBox priorityWordsTextBox;
        private System.Windows.Forms.Label label2;
    }
}