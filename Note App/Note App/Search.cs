using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Note_App
{
    public partial class Search : Form
    {
        //private static Tuple<string, string, string> rowData;
        private DataTable origin;
       // public static Tuple<string,string,string> RowData { get { return rowData; } }
        public Search(DataTable solutions, Form owner)
        {
            InitializeComponent();
            solutionList.DataSource = solutions;
            origin = solutions;
            this.Owner = owner;
            solutionList.Columns["Title"].Width = (solutionList.Size.Width - 3) / 3;
           solutionList.Columns["Description"].Width = (solutionList.Size.Width - 3) / 3;
            solutionList.Columns["Solution"].Width = (solutionList.Size.Width - 3) / 3;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable() ;
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Description", typeof(String));
            table.Columns.Add("Solution", typeof(String));
            if (searchTxt.Text == "")
            {
                solutionList.DataSource = origin;
            }
            else
            {
                Regex rx = new Regex(".*?(" + searchTxt.Text + ").*?");
                
                
                solutionList.DataSource = table;
                
                Console.WriteLine((string)origin.Rows[0].ItemArray[0]);
                foreach (DataRow row in origin.Rows)
                {
                    if (rx.IsMatch((string)row.ItemArray[0]) || rx.IsMatch((string)row.ItemArray[1]) || rx.IsMatch((string)row.ItemArray[2]))
                    {
                        table.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2]);
                    }
                }
            }
           
        }

        private void solutionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //rowData = new Tuple<string, string, string>(solutionList.Rows[e.RowIndex].Cells[0].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[1].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[2].Value.ToString());
                SolutionInfo solu = new SolutionInfo(solutionList.Rows[e.RowIndex].Cells[0].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[1].Value.ToString(), solutionList.Rows[e.RowIndex].Cells[2].Value.ToString());
                solu.ShowDialog();
            }
            catch (ArgumentOutOfRangeException a)
            {
                //can just ignore this error
            }
        }
    }
}
