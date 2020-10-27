using Microsoft.VisualBasic.FileIO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadCSV
{
    public partial class Form1 : Form
    {
        List<string[]> csv = null;
        Type[] types = null;
        bool numericDistribution = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBoxPathCSV_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxPathCSV_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxPathCSV.Text = filePaths[0];

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string path = textBoxPathCSV.Text.Trim();
            this.dataGrid.Columns.Clear();
            this.dataGrid.Rows.Clear();
            this.dataGridTypes.Columns.Clear();
            this.dataGridTypes.Rows.Clear();
            this.comboBoxAttributes.Items.Clear();
            this.comboBoxAttributeCalc.Items.Clear();

            int rowLimit = (int) this.numericUpDownRowLimit.Value;

            if (!File.Exists(path))
            {
                this.textBoxPathCSV.Text = "THE PATH DOES NOT EXIST";

            }
            else
            {




                using TextFieldParser parser = new TextFieldParser(path);

                string delimiter = CSV.DetectDelimiter(path);

                types = CSV.DetectTypes(path, delimiter);
                csv = CSV.Read(path, delimiter, rowLimit);
                int NAttributes = csv[0].Length;
                string[] names = new string[NAttributes];

                if (CSV.IsFirstRowNames(path, delimiter, types))
                {
                    names = csv[0];
                    csv.RemoveAt(0);
                }
                else
                {
                    for (int i = 0; i < NAttributes; i++)
                    {
                        names[i] = "X_" + (i + 1).ToString();
                    }
                }

                foreach (string n in names)
                {
                    DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                    this.dataGrid.Columns.Add(n,n);
                    this.dataGridTypes.Columns.Add(n, n);
                    this.comboBoxAttributes.Items.Add(n);
                    this.comboBoxAttributeCalc.Items.Add(n);

                }


                string[] typesString = Array.ConvertAll(types, element => element.Name.ToString());
                this.dataGridTypes.Rows.Add(typesString);
                

                foreach (string[] row in csv)
                {
                    this.dataGrid.Rows.Add(row);
                }

                setDataGridTypes();
                this.dataGrid.AutoResizeColumns();


            }
            
        }

        private void comboBoxAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            if(types!= null)
            {

                if (types[index] == typeof(double))
                    this.radioButtonDouble.Checked = true;
                else if (types[index] == typeof(Int32))
                    this.radioButtonInt32.Checked = true;
                else if (types[index] == typeof(Int64))
                    this.radioButtonInt64.Checked = true;
                else if (types[index] == typeof(DateTime))
                    this.radioButtonDateTime.Checked = true;
                else if (types[index] == typeof(bool))
                    this.radioButtonBool.Checked = true;
                else
                    this.radioButtonString.Checked = true;

            }
        }

        private bool setDataGridTypes()
        {
            for (int i=0; i < types.Length; i++)
            {
                if (!setDataGridTypesRow(i,types[i]))
                    return false;
                this.dataGrid.Columns[i].ValueType = types[i];
            }
            return true;
        }

        private bool setDataGridTypesRow(int i, Type type)
        {
            bool result = true;
            for (int r = 0; r < this.dataGrid.Rows.Count; r++)
            {
                try
                {
                    this.dataGrid[i, r].Value = Convert.ChangeType(this.dataGrid[i, r].Value, type);
                    Debug.Write("Converted");
                }catch (Exception e)
                {
                    Debug.Write("Exception");
                    result = false;
                    break;

                }
            }  
            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributeCalc.SelectedIndex;
            if ((types[index] == typeof(Int32)) || (types[index] == typeof(Int64)) || (types[index] == typeof(Double)))
            {
                this.numericUpDownIntervalDistance.Enabled = true;
                numericDistribution = true;
            }
            else
            {
                this.numericUpDownIntervalDistance.Value = 1;
                this.numericUpDownIntervalDistance.Enabled = false;
                numericDistribution = false;

            }
        }

        private void Calcolate_Click(object sender, EventArgs e)
        {
            this.dataGridDistribution.Columns.Clear();
            this.dataGridDistribution.Rows.Clear();

            if (csv != null)
            {
                this.dataGridDistribution.Columns.Add("interval", "interval");
                this.dataGridDistribution.Columns.Add("counter", "counter");
                this.dataGridDistribution.Columns.Add("frequency", "frequency");
                this.dataGridDistribution.Columns.Add("percentage", "percentage");


                int index = this.comboBoxAttributeCalc.SelectedIndex;

                    Statistics stat = new Statistics();

                    double distance = (double)this.numericUpDownIntervalDistance.Value;
                    if (distance == 1)
                    {
                        if (numericDistribution)
                        {
                            foreach (string[] row in csv)
                            {
                                stat.OnlineArithmeticMean(Convert.ToDouble(row[index]));
                            }
                        }

                        foreach (string[] row in csv)
                        {
                            stat.OnlineDistribution(row[index], 1);
                        }

                        Dictionary<string, int> distribution = stat.distribution;

                        foreach (KeyValuePair<string, int> value in distribution)
                        {
                            this.dataGridDistribution.Rows.Add(value.Key, value.Value);
                        }

                    }
                    else
                    {


                        stat.intervalDim = distance;
                        foreach (string[] row in csv)
                        {
                            stat.OnlineArithmeticMean(Convert.ToDouble(row[index]));
                            stat.OnlineContinuosDistribution(Convert.ToDouble(row[index]), 1);
                        }

                        stat.UpdateFreq();

                        List<interval> distribution = stat.distributionCont;
                        foreach (interval value in distribution)
                        {
                            string name = "[ " + value.start + " ; " + value.end + " )";
                            this.dataGridDistribution.Rows.Add(name, value.value, value.freq, value.perc);
                        }



                    }

                    this.labelMeanValue.Text = stat.avg.ToString();
                    this.dataGridDistribution.AutoResizeColumns();


                
                

            }
            
        }


        // radio buttons
        private void radioButtonString_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            if (setDataGridTypesRow(index, typeof(string)))
            {        
                types[index] = typeof(string);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }else
            {
                this.radioButtonString.Checked = false;
            }
            
        }

        private void radioButtonDouble_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            bool test = setDataGridTypesRow(index, typeof(double));
            if (test)
            {
                types[index] = typeof(double);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }
            else
            {
                this.radioButtonDouble.Checked = false;
            }
        }

        private void radioButtonInt64_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            if (setDataGridTypesRow(index, typeof(Int64)))
            {
                types[index] = typeof(Int64);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }
            else
            {
                this.radioButtonInt64.Checked = false;
            }
        }

        private void radioButtonInt32_Click(object sender, EventArgs e)
        {

            int index = this.comboBoxAttributes.SelectedIndex;
            if (setDataGridTypesRow(index, typeof(Int32)))
            {
                types[index] = typeof(Int32);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }
            else
            {
                this.radioButtonInt32.Checked = false;
            }
        }

        private void radioButtonDateTime_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            if (setDataGridTypesRow(index, typeof(DateTime)))
            {
                types[index] = typeof(DateTime);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }
            else
            {
                this.radioButtonDateTime.Checked = false;
            }
        }

        private void radioButtonBool_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxAttributes.SelectedIndex;
            if (setDataGridTypesRow(index, typeof(bool)))
            {
                types[index] = typeof(bool);
                this.dataGridTypes[index, 0].Value = types[index].Name;
            }
            else
            {
                this.radioButtonBool.Checked = false;
            }

        }
    }
}
