﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace OwnProject
{
    public partial class Print : FormBase
    {
        public Print()
        {
            InitializeComponent();
            Forms.PrintForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.MenuForm.Show();
            this.Hide();

            List<string> Print = new List<string>();

            if (checkBoxGodolloiTemeto.Checked) Print.Add("GodolloTemeto");
            if (checkBoxANTSZKerelem.Checked) Print.Add("ANTSZKerelem");
            if (checkBoxMeghatalmazas.Checked) Print.Add("Meghatalmazas");
            if (checkBoxKatolikusTemetes.Checked) Print.Add("KatolikusTemetes");
            if (checkBoxKiserojegyzek.Checked) Print.Add("Kiserojegyzek");
            if (checkBoxHamvasztasBudapest.Checked) Print.Add("HamvasztasBudapest");
            if (checkBoxHamvasztasSzolnok.Checked) Print.Add("HamvasztasSzolnok");
            if (checkBoxRegisztraciosLap.Checked) Print.Add("RegLap");
            if (checkBoxStatlap.Checked)
            {
                Print.Add("Statlap1");
                Print.Add("Statlap2");
            }

            Save();
            //Thread.Sleep(3000);
            //printSheet(Print);
        }

        public void printSheet(List<string> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                var filePath = (Settings.outputDocFolderPath + $@"\{Forms.decievedData.Name}\{Forms.decievedData.Name}_{list[i]}.docx");

                var startInfo = new ProcessStartInfo(filePath);
                startInfo.Verb = "print";

                Process.Start(startInfo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.FuneralForm.Show();
            this.Hide();
        }

        private void FormPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }
    }
}
