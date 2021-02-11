using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Note_App
{
    public partial class TheIndex : Form
    {
        float firstWidth;
        float firstHeight;
        public DataTable table;
        public TheIndex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable(tableName:"solutions");
            
            if (File.Exists("saved.xml"))
            {

                table.ReadXml("saved.xml");
            }
            else 
            {
                table.Columns.Add("Title", typeof(String));
                table.Columns.Add("Description", typeof(String));
                table.Columns.Add("Solution", typeof(String));
            }
          
            solutionList.DataSource = table;

            solutionList.Columns["Description"].Visible = false;
            solutionList.Columns["Solution"].Visible = false;

            solutionList.Columns["Title"].Width = solutionList.Size.Width -3;

            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
            solutionList.ContextMenuStrip = solutionMenuStrip;
            

        }
        
       
        private void newBtn_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            desTxt.Clear();
            solTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            bool contains = false;
            foreach (DataGridViewRow row in solutionList.Rows)
            {
                
                Console.WriteLine(row.Cells[0].Value);
                if ((string)row.Cells[0].Value == titleTxt.Text)
                {
                    warningPopup warn = new warningPopup();
                    warn.ShowDialog();
                    if(warn.Replace == true)
                    {
                        row.Cells[1].Value = desTxt.Text;
                        row.Cells[2].Value = solTxt.Text;
                    }
                    contains = true;
                    break;
                }
               
            }
            if(contains == false)
            {
                table.Rows.Add(titleTxt.Text, desTxt.Text, solTxt.Text);
            }

            titleTxt.Clear();
            desTxt.Clear();
            solTxt.Clear();
        }

        private void solutionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try 
            {
                //titleTxt.Text = solutionList.Rows[e.RowIndex].Cells[0].Value.ToString();
                // desTxt.Text = solutionList.Rows[e.RowIndex].Cells[1].Value.ToString();
                // solTxt.Text = solutionList.Rows[e.RowIndex].Cells[2].Value.ToString();
                SolutionInfo solu = new SolutionInfo(solutionList.Rows[e.RowIndex].Cells[0].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[1].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[2].Value.ToString());
                solu.ShowDialog();

            }
            catch(ArgumentOutOfRangeException a)
            {
                //can just ignore this error
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            table.WriteXml("saved.xml", XmlWriteMode.WriteSchema);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = solutionList.CurrentCell.RowIndex;

                table.Rows[index].Delete();
            }
            catch (NullReferenceException a )
            {
                MessageBox.Show("There is no solution to delete");
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float size1 = this.Size.Width / firstWidth;
            float size2 = this.Size.Height / firstHeight;

            SizeF scale = new SizeF(size1, size2);
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            foreach (Control control in this.Controls)
            {

                control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));

                control.Scale(scale);
                solutionList.Columns["Title"].Width = solutionList.Size.Width - 3;

            }


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search(table, this);
            search.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int index = solutionList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            titleTxt.Text = solutionList.Rows[index].Cells[0].Value.ToString();
            desTxt.Text = solutionList.Rows[index].Cells[1].Value.ToString();
            solTxt.Text = solutionList.Rows[index].Cells[2].Value.ToString();
        }

        private void solutionList_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                solutionList.ClearSelection();
                solutionList.Rows[solutionList.HitTest(e.X, e.Y).RowIndex].Selected = true;
            }
        }
    }
}
