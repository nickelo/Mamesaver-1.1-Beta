/**
 * Licensed under The MIT License
 * Redistributions of files must retain the above copyright notice.
 */

namespace Mamesaver
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtExec = new System.Windows.Forms.TextBox();
            this.btnExecBrowse = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstGames = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colYear = new System.Windows.Forms.ColumnHeader();
            this.colManufacturer = new System.Windows.Forms.ColumnHeader();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.btnSelNone = new System.Windows.Forms.Button();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.ListBuilder = new System.ComponentModel.BackgroundWorker();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommandLineOptions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picBuilding = new System.Windows.Forms.PictureBox();
            this.lblNoGames = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mame Path:";
            // 
            // txtExec
            // 
            this.txtExec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExec.Location = new System.Drawing.Point(9, 33);
            this.txtExec.Name = "txtExec";
            this.txtExec.Size = new System.Drawing.Size(378, 20);
            this.txtExec.TabIndex = 1;
            // 
            // btnExecBrowse
            // 
            this.btnExecBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecBrowse.Location = new System.Drawing.Point(393, 30);
            this.btnExecBrowse.Name = "btnExecBrowse";
            this.btnExecBrowse.Size = new System.Drawing.Size(41, 23);
            this.btnExecBrowse.TabIndex = 2;
            this.btnExecBrowse.Text = "...";
            this.btnExecBrowse.UseVisualStyleBackColor = true;
            this.btnExecBrowse.Click += new System.EventHandler(this.btnExecBrowse_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(385, 381);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstGames
            // 
            this.lstGames.AllowColumnReorder = true;
            this.lstGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGames.CheckBoxes = true;
            this.lstGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colYear,
            this.colManufacturer});
            this.lstGames.FullRowSelect = true;
            this.lstGames.Location = new System.Drawing.Point(6, 38);
            this.lstGames.MultiSelect = false;
            this.lstGames.Name = "lstGames";
            this.lstGames.ShowItemToolTips = true;
            this.lstGames.Size = new System.Drawing.Size(428, 293);
            this.lstGames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstGames.TabIndex = 7;
            this.lstGames.UseCompatibleStateImageBehavior = false;
            this.lstGames.View = System.Windows.Forms.View.Details;
            this.lstGames.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstGames_ColumnClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 191;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            // 
            // colManufacturer
            // 
            this.colManufacturer.Text = "Manufacturer";
            this.colManufacturer.Width = 152;
            // 
            // btnRebuild
            // 
            this.btnRebuild.Location = new System.Drawing.Point(6, 9);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(75, 23);
            this.btnRebuild.TabIndex = 8;
            this.btnRebuild.Text = "&Rebuild List";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnRebuild_Click);
            // 
            // btnSelNone
            // 
            this.btnSelNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelNone.Location = new System.Drawing.Point(359, 9);
            this.btnSelNone.Name = "btnSelNone";
            this.btnSelNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelNone.TabIndex = 9;
            this.btnSelNone.Text = "Select &None";
            this.btnSelNone.UseVisualStyleBackColor = true;
            this.btnSelNone.Click += new System.EventHandler(this.btnSelNone_Click);
            // 
            // btnSelAll
            // 
            this.btnSelAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelAll.Location = new System.Drawing.Point(278, 9);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelAll.TabIndex = 10;
            this.btnSelAll.Text = "Select &All";
            this.btnSelAll.UseVisualStyleBackColor = true;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // ListBuilder
            // 
            this.ListBuilder.WorkerSupportsCancellation = true;
            this.ListBuilder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListBuilder_DoWork);
            this.ListBuilder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ListBuilder_RunWorkerCompleted);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "*.exe";
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.Filter = "EXE Files|*.exe|All files|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 363);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMinutes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCommandLineOptions);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtExec);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnExecBrowse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval:";
            // 
            // txtCommandLineOptions
            // 
            this.txtCommandLineOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandLineOptions.Location = new System.Drawing.Point(9, 83);
            this.txtCommandLineOptions.Name = "txtCommandLineOptions";
            this.txtCommandLineOptions.Size = new System.Drawing.Size(378, 20);
            this.txtCommandLineOptions.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command line options:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNoGames);
            this.tabPage2.Controls.Add(this.lstGames);
            this.tabPage2.Controls.Add(this.btnSelAll);
            this.tabPage2.Controls.Add(this.btnRebuild);
            this.tabPage2.Controls.Add(this.btnSelNone);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picBuilding
            // 
            this.picBuilding.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBuilding.Image = global::Mamesaver.Properties.Resources.SEARCH_00;
            this.picBuilding.Location = new System.Drawing.Point(32, 102);
            this.picBuilding.Name = "picBuilding";
            this.picBuilding.Size = new System.Drawing.Size(80, 50);
            this.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBuilding.TabIndex = 12;
            this.picBuilding.TabStop = false;
            this.picBuilding.Visible = false;
            // 
            // lblNoGames
            // 
            this.lblNoGames.AutoSize = true;
            this.lblNoGames.Location = new System.Drawing.Point(87, 14);
            this.lblNoGames.Name = "lblNoGames";
            this.lblNoGames.Size = new System.Drawing.Size(69, 13);
            this.lblNoGames.TabIndex = 11;
            this.lblNoGames.Text = "No Games: 0";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(8, 133);
            this.txtMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.txtMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(80, 20);
            this.txtMinutes.TabIndex = 6;
            this.txtMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 416);
            this.Controls.Add(this.picBuilding);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = global::Mamesaver.Properties.Resources.otheroptions;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 450);
            this.Name = "ConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mamesaver Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configForm_FormClosing);
            this.Load += new System.EventHandler(this.configForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExec;
        private System.Windows.Forms.Button btnExecBrowse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lstGames;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ColumnHeader colManufacturer;
        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.Button btnSelNone;
        private System.Windows.Forms.Button btnSelAll;
        private System.ComponentModel.BackgroundWorker ListBuilder;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCommandLineOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNoGames;
        private System.Windows.Forms.PictureBox picBuilding;
        private System.Windows.Forms.NumericUpDown txtMinutes;
    }
}