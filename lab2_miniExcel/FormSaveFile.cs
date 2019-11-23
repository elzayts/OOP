using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_excel_lab2
{
    public partial class FormSaveFile : Form
    {
        public FormSaveFile()
        {
            InitializeComponent();
            FormMiniExcel formMiniExcel = new FormMiniExcel();

        }

        private void btnStopSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Структура
         * кількість ствбчиків
         * кількість рядочків
         * iм'я клітинки1
         * значення1
         * вираз1
         * i т.д.
         */

         
        private void btnSaveOK_Click(object sender, EventArgs e)
        {
            string path = @TBpath.Text + @"\" + TBname.Text + ".txt";
            //File.Create(path);

            DataGridView mainTable = Program.mainFormMiniExcel.dgv;

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(mainTable.ColumnCount);
            sw.WriteLine(mainTable.RowCount);
            Dictionary<string, Cell> mainDict = Program.mainFormMiniExcel.getDict();
            foreach (KeyValuePair<string, Cell> keyValue in mainDict)
            {
                sw.WriteLine(keyValue.Key);
                sw.WriteLine(mainDict[keyValue.Key].Value);
                sw.WriteLine(mainDict[keyValue.Key].Exp);
            }
            sw.Flush();
            sw.Close();
            this.Close();
        }

        private void TBpath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}