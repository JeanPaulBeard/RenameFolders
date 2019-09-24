using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFolders
{
    public partial class Form1 : Form
    {
        private string origen;
        private string destino;
        private string oldPrefijo;
        private string newPrefijo;


        public Form1()
        {
            InitializeComponent();
        }




        private int CalcPercernt(int total, int valor)
        {
            float perc = ((100 / total) * valor);
            return (int)Math.Round(perc, 0);
        }


        private void BtOriginFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogOrigin.ShowDialog();
            if (result == DialogResult.OK)
            {
                origen = folderBrowserDialogOrigin.SelectedPath;
                txOriginFolder.Text = origen;
                Environment.SpecialFolder root = folderBrowserDialogOrigin.RootFolder;
            }
        }

        private void BtDetinyFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogDestiny.ShowDialog();
            if (result == DialogResult.OK)
            {
                destino = folderBrowserDialogDestiny.SelectedPath;
                txDetinyFolder.Text = destino;
                Environment.SpecialFolder root = folderBrowserDialogDestiny.RootFolder;
            }
        }



        private void Paste(DataGridView d)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.StringFormat))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.StringFormat).ToString().TrimEnd("\r\n".ToCharArray()), "\r");
                int j = 0;
                try { j = d.CurrentRow.Index; } catch { }
                foreach (string pastedRow in pastedRows)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(d, pastedRow.Split(new char[] { '\t' }));
                    d.Rows.Insert(j, r);
                    j++;
                }
            }
        }

        private void BtPaste_Click(object sender, EventArgs e)
        {
            Paste(dataGridView1);
        }

        private void BtProcess_Click(object sender, EventArgs e)
        {
            origen = txOriginFolder.Text;
            destino = txDetinyFolder.Text;

            oldPrefijo = txFind.Text;
            newPrefijo = txReplace.Text;

            progressBar1.Value = 0;
            progressBar1.Enabled = true;
            progressBar1.Visible = true;
            btProcess.Enabled = false;

            backgroundWorker1.RunWorkerAsync(dataGridView1);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataGridView tabla = (DataGridView)e.Argument;
            int total = tabla.Rows.Count;
            int i = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                i++;
                string factura = "";

                try
                {
                    factura = row.Cells[0].Value.ToString().Trim();

                    string ori = origen + @"\" + oldPrefijo + factura;
                    string des = destino + @"\" + newPrefijo + "00" + factura;

                    if (!Directory.Exists(ori))
                    {
                        ori = origen + @"\" + oldPrefijo + "00" + factura;
                    }


                    if (!Directory.Exists(ori))
                    {
                        //Directorio no existe
                        backgroundWorker1.ReportProgress(CalcPercernt(total, i), "ER\t" + factura + "\t No encontrado");
                    }
                    else
                    {
                        if (!Directory.Exists(des))
                        {
                            Directory.CreateDirectory(des);
                        }
                        //My.Computer.FileSystem.CopyDirectory(ori, des);
                        CopyFilesRecursively(new DirectoryInfo(ori), new DirectoryInfo(des));
                        backgroundWorker1.ReportProgress(CalcPercernt(total, i), "OK\t" + factura);
                    }
                }
                catch (Exception ex)
                {
                    backgroundWorker1.ReportProgress(CalcPercernt(total, i), "EK\t" + factura + "\t " + ex.Message);
                }
            }
        }








        public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            oldPrefijo = txFind.Text;
            newPrefijo = txReplace.Text;
        }

        private void TxFind_TextChanged(object sender, EventArgs e)
        {
            oldPrefijo = txFind.Text;
        }

        private void TxReplace_TextChanged(object sender, EventArgs e)
        {
            newPrefijo = txReplace.Text;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
                rtbLog.Text = rtbLog.Text + "\n" + e.UserState;
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Enabled = false;
            progressBar1.Visible = false;
            btProcess.Enabled = true;
        }


        //


    }





    //
}
