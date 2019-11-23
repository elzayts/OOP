using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_excel_lab2
{
    public partial class FormMiniExcel : Form
    {

        Indexator indexator = new Indexator();
        Parser parser = new Parser();
        Namer handler = new Namer();
        public int currRow, currCol;
        public Dictionary<string, Cell> dictionary = new Dictionary<string, Cell>();
        public Dictionary<string, List<string>> dependson = new Dictionary<string, List<string>>(); //список клеток в ехр клетки-ключа
        public Dictionary<string, List<string>> dependentfrom = new Dictionary<string, List<string>>();//списокклеток в ехр которіх есть клеткаключ 
        public Dictionary<string, int> entrance = new Dictionary<string, int>();

        public DataGridView mainTable()
        {
            return this.dgv;
        }

        public Dictionary<string, Cell> getDict()
        {
            return this.dictionary;
        }

        public FormMiniExcel()
        {
            InitializeComponent();
            DataGridViewColumn A = new DataGridViewColumn();
            DataGridViewColumn B = new DataGridViewColumn();
            DataGridViewColumn C = new DataGridViewColumn();
            DataGridViewColumn D = new DataGridViewColumn();
            DataGridViewColumn E = new DataGridViewColumn();
            DataGridViewColumn F = new DataGridViewColumn();
            DataGridViewColumn G = new DataGridViewColumn();
            DataGridViewColumn H = new DataGridViewColumn();
            DataGridViewColumn I = new DataGridViewColumn();

            Cell cellA = new Cell(); A.CellTemplate = cellA;
            Cell cellB = new Cell(); B.CellTemplate = cellB;
            Cell cellC = new Cell(); C.CellTemplate = cellC;
            Cell cellD = new Cell(); D.CellTemplate = cellD;
            Cell cellE = new Cell(); E.CellTemplate = cellE;
            Cell cellF = new Cell(); F.CellTemplate = cellF;
            Cell cellG = new Cell(); G.CellTemplate = cellG;
            Cell cellH = new Cell(); H.CellTemplate = cellH;
            Cell cellI = new Cell(); I.CellTemplate = cellI;


            A.HeaderText = "A"; A.Name = "A";
            B.HeaderText = "B"; B.Name = "B";
            C.HeaderText = "C"; C.Name = "C";
            D.HeaderText = "D"; D.Name = "D";
            E.HeaderText = "E"; E.Name = "E";
            F.HeaderText = "F"; F.Name = "F";
            G.HeaderText = "G"; G.Name = "G";
            H.HeaderText = "H"; H.Name = "H";
            I.HeaderText = "I"; I.Name = "I";

            dgv.Columns.Add(A);
            dgv.Columns.Add(B);
            dgv.Columns.Add(C);
            dgv.Columns.Add(D);
            dgv.Columns.Add(E);
            dgv.Columns.Add(F);
            dgv.Columns.Add(G);
            dgv.Columns.Add(H);
            dgv.Columns.Add(I);
            dgv.AllowUserToAddRows = false;
            
            dgv.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }

        //---------------------------------------------------------------------------------------//

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        //---------------------------------------------------------------------------------------//

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               /* string currCellName = indexator.FromNumberToWord(currCol + 1) + (currRow + 1).ToString();

                if (dgv.Rows[currRow].Cells[currCol].Value != null)
                {
                    string currCellValue = dgv.Rows[currRow].Cells[currCol].Value.ToString();
                    dictionary[currCellName].Value = parser.result(currCellValue).ToString();
                }
                else
                {
                    dictionary[currCellName].Value = 0.ToString();
                }
                dgv.Rows[currRow].Cells[currCol].Value = dictionary[currCellName].Value;*/
               // calculateExp_Click(sender, e);
            }
            catch { };

        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            currRow = dgv.CurrentCell.RowIndex;
            currCol = dgv.CurrentCell.ColumnIndex;
            string currCellName = indexator.FromNumberToWord(currCol + 1) + (currRow + 1).ToString();
            if (!dictionary.ContainsKey(currCellName))
            {
                Cell cell = new Cell(currCellName, "0", "0");
                //cell.Value = "0";
                //cell.Exp = "0";
                dictionary.Add(currCellName, cell);
            }
            label3.Text = currCellName;
            textBoxFormula.Text = dictionary[currCellName].Exp;
        }

        //------------------------------------------------------------------------------------//

        public void AddColumn()
        {
            int n =++dgv.ColumnCount;
           
            dgv.Columns[n-1].HeaderText = indexator.FromNumberToWord(n);
        }

        //-----------------------------------------------------------------------------//
        private void buttonAddColumn_Click(object sender, EventArgs e)//додати колонку
        {
            AddColumn();
        }

        //---------------------------------------------------------------------------------//

        public void AddRow()
        {
            int n = ++dgv.RowCount;
            for (int i = 0; i < n; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        //----------------------------------------------------------------------------------//

        private void buttonAddRow_Click(object sender, EventArgs e)//додати рядочок
        {
            AddRow();
        }

        //----------------------------------------------------------------------------------//

        private void textBoxFormula_TextChanged(object sender, EventArgs e) // записать формулу
        {
            try
            {
                string currCellName = indexator.FromNumberToWord(currCol + 1) + (currRow + 1).ToString();
                dictionary[currCellName].Exp = textBoxFormula.Text;
            }
            catch { }
        }
        private void textBoxFormula_Leave(object sender, EventArgs e) // записать формулу
        {
            string c = indexator.FromNumberToWord(currCol + 1) + (currRow + 1).ToString();
            List<string> anotherCells = handler.ListNameCells(dictionary[c]).Distinct().ToList(); ;

                if (!dependson.ContainsKey(dictionary[c].Name))
                    dependson.Add(dictionary[c].Name, new List<string>());

                for (int i = 0; i < anotherCells.Count; i++)
                {
                    dependson[dictionary[c].Name].Add(anotherCells[i]);
                    if (!dependentfrom.ContainsKey(anotherCells[i]))
                    {
                        dependentfrom.Add(anotherCells[i], new List<string>());
                    }
                    dependentfrom[anotherCells[i]].Add(dictionary[c].Name);
                    
                }
            CalcExp();
        }

        //---------------------------------------------------------------------------------------//

        private void buildEntranceDictionary()
        {
            entrance = new Dictionary<string, int>();
            for (int j = 0; j < dgv.ColumnCount; j++)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string currCellName = indexator.FromNumberToWord(j + 1) + (i + 1).ToString();
                    entrance.Add(currCellName, 100);
                }
            }
        }

        //------------------------------------------------------------------------------------//

        public void CalcExp()
        {
            entrance = new Dictionary<string, int>();
            buildEntranceDictionary();

            for (int j = 0; j < dgv.ColumnCount; j++)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string currCellName = indexator.FromNumberToWord(j + 1) + (i + 1).ToString();
                    
                    if (dictionary.ContainsKey(currCellName) && dictionary[currCellName].Value != null)
                    {
                        try
                        {
                            dgv.Rows[i].Cells[j].Value = CalcCell(dictionary[currCellName], dgv).ToString();
            
                            dictionary[currCellName].Value = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                        catch (ClassOfExceptions.ExceptionRecursion)
                        {
                            MessageBox.Show(ClassOfExceptions.ExceptionRecursion.what);
                            dictionary[currCellName].Exp = "0";
                            dictionary[currCellName].Value = "0";
                            dgv.Rows[i].Cells[j].Value = dictionary[currCellName].Value;
                            CalcExp();
                            return;
                        }

                    }
                }
            }

            entrance = new Dictionary<string, int>();

        }

        //-----------------------------------------------------------------------------//

        private void calculateExp_Click(object sender, EventArgs e)
        {
            CalcExp();
        }

        //-----------------------------------------------------------------------------//

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)

        { FormSaveFile formSaveFile = new FormSaveFile();
            formSaveFile.Show();
        }

        //-------------------------------------------------------------------------//

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadFile formLoadFile = new FormLoadFile();
            formLoadFile.Show();
            if (MessageBox.Show("Do you want to save current file?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                FormSaveFile formSaveFile = new FormSaveFile();
                formSaveFile.Show();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nbki");
        }

        //----------------------------------------------------------------------------//

        public void DelCol()
        {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    string currCellName = indexator.FromNumberToWord(dgv.ColumnCount) + (i+1).ToString();
                
                if (dictionary.ContainsKey(currCellName))
                {
                    
                    if (dependentfrom[currCellName].Count!=0)
                        {
                        for (int j = 0; j < dependentfrom[currCellName].Count; j++)
                        {
                           // MessageBox.Show(dependentfrom[currCellName][j]);
                            dictionary[dependentfrom[currCellName][j]].Exp = "0";
                            dictionary[dependentfrom[currCellName][j]].Value = "0";
                           
                        }
                        }
                        dictionary.Remove(currCellName);
                    }
                }
  
            dgv.Columns.RemoveAt(dgv.Columns.Count - 1);
            CalcExp();
        }


        //------------------------------------------------------------------------------//


        public void DelRow()
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                string currCellName = indexator.FromNumberToWord(i+1) + (dgv.RowCount).ToString();

                if (dictionary.ContainsKey(currCellName))
                {

                    if (dependentfrom[currCellName].Count != 0)
                    {
                        for (int j = 0; j < dependentfrom[currCellName].Count; j++)
                        {
                            // MessageBox.Show(dependentfrom[currCellName][j]);
                            dictionary[dependentfrom[currCellName][j]].Exp = "0";
                            dictionary[dependentfrom[currCellName][j]].Value = "0";

                        }
                    }
                    dictionary.Remove(currCellName);
                }
            }

            dgv.Columns.RemoveAt(dgv.Columns.Count - 1);
            CalcExp();
        }

        //----------------------------------------------------------------------------//
        private void btnDelCol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete column?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                DelCol();
        }

        //----------------------------------------------------------------------------//

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete row?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                DelRow();
        }

        //---------------------------------------------------------------------------//

        private void FormMiniExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрити?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }



        private void FormMiniExcel_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------//
        public double CalcCell(Cell c, DataGridView dgv)
        {
            try
            {
                entrance[c.Name]--;
                if (entrance[c.Name] < 0)
                {
                    c.Value = "0";
                    throw new ClassOfExceptions.ExceptionRecursion();
                }
            }
            catch (KeyNotFoundException) { }

            string saveFormula = c.Exp;
            List<string> anotherCells = handler.ListNameCells(c).Distinct().ToList(); ;

            if (anotherCells.Count == 0)
            {
                    return parser.result(c.Exp);
            
            }
            else
            {  
                    for (int i = 0; i < anotherCells.Count; i++)
                {
                    if (dictionary.ContainsKey(anotherCells[i]))
                    {
                        c.Exp = c.Exp.Replace(anotherCells[i], CalcCell(dictionary[anotherCells[i]], dgv).ToString()+" ");
                    }
                    else
                    {
                        c.Exp = c.Exp.Replace(anotherCells[i], " 0 ");
                    }
                }

                string finishFormula = c.Exp;
                c.Exp = saveFormula;
                //try {
                    return parser.result(finishFormula);
                //}
                /*catch (DivideByZeroException)
                {
                    c.Value = "0";
                    MessageBox.Show("Division by 0");
                    return 0;
                }*/
                
            }
        }
    }
}
