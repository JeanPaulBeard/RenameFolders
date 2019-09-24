namespace RenameFolders
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ToFind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txFind = new System.Windows.Forms.TextBox();
            this.txReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialogOrigin = new System.Windows.Forms.FolderBrowserDialog();
            this.txOriginFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txDetinyFolder = new System.Windows.Forms.TextBox();
            this.btOriginFolder = new System.Windows.Forms.Button();
            this.btDetinyFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialogDestiny = new System.Windows.Forms.FolderBrowserDialog();
            this.btProcess = new System.Windows.Forms.Button();
            this.btPaste = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToFind});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado a buscar";
            // 
            // ToFind
            // 
            this.ToFind.HeaderText = "To Find";
            this.ToFind.Name = "ToFind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto a reemplazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Texto de reemplazo";
            // 
            // txFind
            // 
            this.txFind.Location = new System.Drawing.Point(305, 25);
            this.txFind.Name = "txFind";
            this.txFind.Size = new System.Drawing.Size(210, 20);
            this.txFind.TabIndex = 4;
            this.txFind.Text = "SM_";
            this.txFind.TextChanged += new System.EventHandler(this.TxFind_TextChanged);
            // 
            // txReplace
            // 
            this.txReplace.Location = new System.Drawing.Point(534, 25);
            this.txReplace.Name = "txReplace";
            this.txReplace.Size = new System.Drawing.Size(210, 20);
            this.txReplace.TabIndex = 5;
            this.txReplace.Text = "C07_820001181_SM";
            this.txReplace.TextChanged += new System.EventHandler(this.TxReplace_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(305, 184);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(439, 254);
            this.rtbLog.TabIndex = 7;
            this.rtbLog.Text = "";
            // 
            // txOriginFolder
            // 
            this.txOriginFolder.Location = new System.Drawing.Point(305, 76);
            this.txOriginFolder.Name = "txOriginFolder";
            this.txOriginFolder.ReadOnly = true;
            this.txOriginFolder.Size = new System.Drawing.Size(181, 20);
            this.txOriginFolder.TabIndex = 8;
            this.txOriginFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carpeta de busqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Carpeta de destino";
            // 
            // txDetinyFolder
            // 
            this.txDetinyFolder.Location = new System.Drawing.Point(534, 76);
            this.txDetinyFolder.Name = "txDetinyFolder";
            this.txDetinyFolder.ReadOnly = true;
            this.txDetinyFolder.Size = new System.Drawing.Size(181, 20);
            this.txDetinyFolder.TabIndex = 10;
            this.txDetinyFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btOriginFolder
            // 
            this.btOriginFolder.Location = new System.Drawing.Point(492, 74);
            this.btOriginFolder.Name = "btOriginFolder";
            this.btOriginFolder.Size = new System.Drawing.Size(23, 23);
            this.btOriginFolder.TabIndex = 12;
            this.btOriginFolder.Text = "..";
            this.btOriginFolder.UseVisualStyleBackColor = true;
            this.btOriginFolder.Click += new System.EventHandler(this.BtOriginFolder_Click);
            // 
            // btDetinyFolder
            // 
            this.btDetinyFolder.Location = new System.Drawing.Point(721, 74);
            this.btDetinyFolder.Name = "btDetinyFolder";
            this.btDetinyFolder.Size = new System.Drawing.Size(23, 23);
            this.btDetinyFolder.TabIndex = 13;
            this.btDetinyFolder.Text = "..";
            this.btDetinyFolder.UseVisualStyleBackColor = true;
            this.btDetinyFolder.Click += new System.EventHandler(this.BtDetinyFolder_Click);
            // 
            // btProcess
            // 
            this.btProcess.Location = new System.Drawing.Point(669, 122);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(75, 23);
            this.btProcess.TabIndex = 14;
            this.btProcess.Text = "Procesar";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.BtProcess_Click);
            // 
            // btPaste
            // 
            this.btPaste.Location = new System.Drawing.Point(214, 23);
            this.btPaste.Name = "btPaste";
            this.btPaste.Size = new System.Drawing.Size(75, 23);
            this.btPaste.TabIndex = 15;
            this.btPaste.Text = "Pegar";
            this.btPaste.UseVisualStyleBackColor = true;
            this.btPaste.Click += new System.EventHandler(this.BtPaste_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(305, 122);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btPaste);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.btDetinyFolder);
            this.Controls.Add(this.btOriginFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txDetinyFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txOriginFolder);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txReplace);
            this.Controls.Add(this.txFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Folders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txFind;
        private System.Windows.Forms.TextBox txReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOrigin;
        private System.Windows.Forms.TextBox txOriginFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txDetinyFolder;
        private System.Windows.Forms.Button btOriginFolder;
        private System.Windows.Forms.Button btDetinyFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestiny;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Button btPaste;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

