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

namespace Score
{
    public partial class Form1 : Form
    {

        DataTable InputDT = new DataTable();
        OpenFileDialog input_path = new OpenFileDialog();
        FolderBrowserDialog output_path = new FolderBrowserDialog();
        Color selected = Color.LawnGreen;

        public Form1()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btn_res();
            IBrowse.BackColor = selected;
        }

        private void ReadCSV_Click(object sender, EventArgs e)
        {
            InputDT.Clear();
            DataSet ds = new DataSet();
            StreamReader s = new StreamReader(input_path.FileName, Encoding.Default);
            
            //char word = cutting_word.Text.ToString()[0];
            //string[] columns = s.ReadLine().Split(word);
            string[] columns = s.ReadLine().Split(',');

            ds.Tables.Add();

            foreach (string col in columns)
            {
                bool added = false;
                string next = "";
                int i = 0;
                while (!added)
                {
                    string columnname = col + next;
                    columnname = columnname.Replace("#", "");
                    columnname = columnname.Replace("'", "");
                    columnname = columnname.Replace("&", "");

                    if (!ds.Tables[0].Columns.Contains(columnname))
                    {
                        ds.Tables[0].Columns.Add(columnname.ToUpper());
                        added = true;
                    }
                    else
                    {
                        i++;
                        next = "_" + i.ToString();
                    }
                }
            }
            //ds.Tables[0].Columns.Add("Score");

            string AllData = s.ReadToEnd();
            AllData = AllData.TrimEnd('\n');
            string[] rows = AllData.Split('\n');

            foreach (string r in rows)
            {
                string[] items = r.Split(',');
                ds.Tables[0].Rows.Add(items);
            }

            s.Close();
            InputDT = ds.Tables[0].Copy();
            dataGridView1.DataSource = InputDT;
            reset();
            ReadCSV.BackColor = Color.White;
            AddNewCol.Enabled = true;
            AddNewCol.BackColor = selected;
            search.Enabled = true;
            search.BackColor = selected;
            Enter.Enabled = true;
            Enter.BackColor = selected;
            SaveDT.Enabled = true;
            SaveDT.BackColor = selected;
            update_input_col();
        }

        private void IBrowse_Click(object sender, EventArgs e)
        {
            IBrowse.BackColor = selected;
            btn_res();
            reset();
            input_path.Filter = "逗號分隔值 (*.csv*)|*.csv";
            input_path.ShowDialog();
            IPath.Text = input_path.FileName;

            if(input_path.FileName != "")
            {
                ReadCSV.Enabled = true;
                ReadCSV.BackColor = selected;
                IBrowse.BackColor = Color.White;
            }
        }

        private void last5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void last5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //search.Focus();
                search_Click(sender, e);
                //TextBox1.Focus();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            names_com.Items.Clear();
            names_com.ResetText();
            string target = last5.Text.ToString();
            int count = 0;
            //string trim_last = "";

            for (int i = 0; i < InputDT.Rows.Count; i++)
            {
                string temp = InputDT.Rows[i][0].ToString();
                string trim_last = "";
                if (temp.Length > 0)
                {
                    trim_last = temp.Substring(5);
                }

                if(string.Compare(trim_last, target, true) == 0)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = InputDT.Rows[i][1].ToString();
                    item.Value = i;
                    names_com.Items.Add(item);
                    count++;
                }
            }
            try
            {
                if(count > 1)
                {
                    label2.BackColor = System.Drawing.Color.Red;
                }
                names_com.SelectedIndex = 0;
                names_com.Focus();
            }
            catch(Exception ex)
            {
                last5.Focus();
                last5.SelectAll();
            }

            //names.DataSource = index;
            //names.Update();
        }

        private void score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Enter.Focus();
                Enter_Click(sender, e);
                //last5.Focus();
                //last5.SelectAll();
                //TextBox1.Focus();
            }
        }

        private void names_com_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                score.Focus();
                score.SelectAll();
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //int select_index = int.Parse(names_com.SelectedItem.ToString());
            ComboboxItem item = names_com.Items[names_com.SelectedIndex] as ComboboxItem;
            ComboboxItem tar_col = Input_col.Items[Input_col.SelectedIndex] as ComboboxItem;
            int select_index = int.Parse(item.Value.ToString());
            int select_col = int.Parse(tar_col.Value.ToString());
            int limit_int = 0;
            try
            {
                limit_int = int.Parse(limit.Text.ToString());
            }catch(Exception ex)
            {
                limit.Text = "";
                Input_Limit.Checked = false;
            }
            bool check = true;
            if (Input_Limit.Checked)
            {
                if (int.Parse(score.Text.ToString()) <= limit_int){
                    check = false;
                }
                else
                {
                    MessageBox.Show("Out of Limit");
                    score.SelectAll();
                    score.Focus();
                }
            }
            if(check)
            {
                InputDT.Rows[select_index][select_col] = score.Text.ToString();
                dataGridView1.Update();
                dataGridView1.CurrentCell = dataGridView1.Rows[select_index].Cells[0];
                label2.BackColor = Color.Black;
                last5.Focus();
                last5.SelectAll();
            }
            
            
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                names_com.Focus();
            }
        }

        private void OBrowse_Click(object sender, EventArgs e)
        {
            output_path.ShowDialog();
            OPath.Text = output_path.SelectedPath;
            SaveDT.Enabled = true;
        }

        private void SaveDT_Click(object sender, EventArgs e)
        {
            string data = "";
            string FileStr = "";
            if (output_path.SelectedPath == "")
            {
                FileStr = input_path.FileName;
            }
            else
            {
                FileStr = output_path.SelectedPath + "\\";
                FileStr += "Output_" + input_path.SafeFileName;
            }
            
            StreamWriter wr = new StreamWriter(FileStr, false, Encoding.Default);
            foreach (DataColumn column in InputDT.Columns)
            {
                data += column.ColumnName + ",";
            }
            data = data.TrimEnd(',');
            data += "\n";
            wr.Write(data);
            data = "";
            for (int i = 0; i < InputDT.Rows.Count; i++)
            {
                foreach (DataColumn column in InputDT.Columns)
                {
                    data += InputDT.Rows[i][column].ToString().Trim() + ",";
                }
                data = data = data.TrimEnd(',');
                if(i+1< InputDT.Rows.Count)
                {
                    data += "\n";
                }
                wr.Write(data);
                data = "";
            }
            wr.Dispose();
            wr.Close();
        }

        private void names_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewCol_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNewCol_Click(sender, e);
                
            }
        }

        private void AddNewCol_Click(object sender, EventArgs e)
        {
            
            InputDT.Columns.Add(NewCol_Name.Text.ToString());
            update_input_col();
            Input_col.Focus();

        }

        public void update_input_col()
        {
            Input_col.Items.Clear();
            Input_col.ResetText();
            int i = 0;
            foreach (DataColumn column in InputDT.Columns)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = column.ColumnName;
                item.Value = i;
                Input_col.Items.Add(item);
                i++;
            }
            Input_col.SelectedIndex = InputDT.Columns.Count - 1;
            dataGridView1.Update();
        }

        private void Input_col_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = Input_col.Items[Input_col.SelectedIndex].ToString();
        }

        private void names_com_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboboxItem item = names_com.Items[names_com.SelectedIndex] as ComboboxItem;
            int select_index = int.Parse(item.Value.ToString());
            dataGridView1.CurrentCell = dataGridView1.Rows[select_index].Cells[0];
        }

        public void reset()
        {
            NewCol_Name.Text = "";
            Input_col.Items.Clear();
            Input_col.ResetText();

            last5.Text = "";
            names_com.Items.Clear();
            names_com.ResetText();
            score.Text = "";

        }
        public void btn_res()
        {
            ReadCSV.Enabled = false;
            ReadCSV.BackColor = Color.White;
            AddNewCol.Enabled = false;
            AddNewCol.BackColor = Color.White;
            search.Enabled = false;
            search.BackColor = Color.White;
            Enter.Enabled = false;
            Enter.BackColor = Color.White;
            SaveDT.Enabled = false;
            SaveDT.BackColor = Color.White;
        }
    }
}
