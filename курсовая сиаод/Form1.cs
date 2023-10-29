using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace курсовая_сиаод
{
    public partial class Form1 : Form
    {
        public int NumOfCheck = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            SinglyLlinkedList.GetRandomUnorderedList(1000);
            string value = "";
            if (radioButton1.Checked)
                value = radioButton1.Text;
            else if (radioButton2.Checked)
                value = radioButton2.Text;
            else if (radioButton3.Checked)
                value = radioButton3.Text;
            else if (radioButton4.Checked)
                value = radioButton4.Text;
            else value = "error";
            if (value == "Неупорядоченый")
                this.dataGridView1.Rows.Add(NumOfCheck, value, numericUpDownSizeList.Value, 
                    sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomUnorderedList((int)numericUpDownSizeList.Value)),
                    sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomUnorderedList((int)numericUpDownSizeList.Value)),
                    sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomUnorderedList((int)numericUpDownSizeList.Value)));
            else if (value == "Упорядоченый")
                this.dataGridView1.Rows.Add(NumOfCheck, value, numericUpDownSizeList.Value,
                    sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomOrderedList((int)numericUpDownSizeList.Value)),
                    sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomOrderedList((int)numericUpDownSizeList.Value)),
                    sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomOrderedList((int)numericUpDownSizeList.Value)));
            else if (value == "Упорядоченный в обратном порядке")
                this.dataGridView1.Rows.Add(NumOfCheck, value, numericUpDownSizeList.Value,
    sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomOrderedInReverseOrderList((int)numericUpDownSizeList.Value)),
    sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomOrderedInReverseOrderList((int)numericUpDownSizeList.Value)),
    sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomOrderedInReverseOrderList((int)numericUpDownSizeList.Value)));
            else
                this.dataGridView1.Rows.Add(NumOfCheck, value, numericUpDownSizeList.Value,
    sorter.ShellSortingMethodVirt(SinglyLlinkedList.GetRandomPartlyOrderedList((int)numericUpDownSizeList.Value, (int)numericUpDownPercentOfFill.Value)),
    sorter.ShellSortingMethodKnyt(SinglyLlinkedList.GetRandomPartlyOrderedList((int)numericUpDownSizeList.Value, (int)numericUpDownPercentOfFill.Value)),
    sorter.ShellSortingMethodOfDividingInHalf(SinglyLlinkedList.GetRandomPartlyOrderedList((int)numericUpDownSizeList.Value, (int)numericUpDownPercentOfFill.Value)));    
            NumOfCheck++;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            chartGrafics.Series[0].Points.Clear();
            if (this.dataGridView1.CurrentCell.RowIndex == -1) throw new Exception("неккоректный выбор строки таблицы");
            chartGrafics.Series[0].Name =dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value+"";
            chartGrafics.Series[0].Points.AddXY(5, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
            chartGrafics.Series[0].Points.AddXY(10, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
            chartGrafics.Series[0].Points.AddXY(15, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
        }
    }
}
