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
    public partial class FormLoadFile : Form
    {




            public FormLoadFile()
            {
                InitializeComponent();

            }

            private void btnClose_Click(object sender, EventArgs e)
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

            private void btnOK_Click(object sender, EventArgs e)
            {
                 

                string path = @TBpapka.Text;
                List<string> files = (from a in Directory.GetFiles(path) select Path.GetFileName(a)).ToList();
                int k = 0;
                for (int i = 0; i < files.Count; i++)
                {
                    if (TextBoxFile.Text == files[i])
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("No such file in folder");
                    return;
                }

                else
                {

                    string nameFile = TextBoxFile.Text;
                    Program.mainFormMiniExcel.label1.Text = nameFile;
                    StreamReader sr = new StreamReader(TBpapka.Text + @"\" + nameFile);

                    while (Program.mainFormMiniExcel.dgv.ColumnCount != 1)
                    {

                    Program.mainFormMiniExcel.dgv.Columns.RemoveAt(Program.mainFormMiniExcel.dgv.ColumnCount-1);
                    }
                Program.mainFormMiniExcel.dgv.Columns.RemoveAt(Program.mainFormMiniExcel.dgv.ColumnCount-1);
                Program.mainFormMiniExcel.dictionary.Clear();
                Program.mainFormMiniExcel.dependentfrom.Clear();
                Program.mainFormMiniExcel.dependson.Clear();
                // while (Program.mainFormMiniExcel.dgv.RowCount != 1)
                //   {
                //     Program.mainFormMiniExcel.currRow = Program.mainFormMiniExcel.dgv.RowCount - 1;
                //   Program.mainFormMiniExcel.DelRow();
                //}

                uint newColumnCount;
                    uint newRowCount;
                    try
                    {
                        newColumnCount = UInt32.Parse(sr.ReadLine());
                        newRowCount = UInt32.Parse(sr.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }


                    for (int i = 0; i < newRowCount; i++)
                    {
                        Program.mainFormMiniExcel.AddRow();
                    }
                    for (int i = 0; i < newColumnCount; i++)
                    {
                        Program.mainFormMiniExcel.AddColumn();
                    }
                    string name;
                    while ((name = sr.ReadLine()) != null)
                    {
                        string value = sr.ReadLine();
                        string exp = sr.ReadLine();
                        Cell c = new Cell();
                        c.Name = name;
                        c.Value = value;
                        c.Exp = exp;
                        try
                        {
                            Program.mainFormMiniExcel.dictionary.Add(name, c);
                        }
                        catch (System.ArgumentException)
                        {
                            Program.mainFormMiniExcel.dictionary.Remove(name);
                            Program.mainFormMiniExcel.dictionary.Add(name, c);
                        }
                    }
                    Program.mainFormMiniExcel.CalcExp();
                    this.Close();
                }
            }
        }
    }
