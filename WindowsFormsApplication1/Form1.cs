using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> dateComment = new Dictionary<String, String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String date = monthCalendar1.SelectionRange.Start.ToString();

            if (dateComment.ContainsKey(date))
            {
                dateComment[date] = this.textBox1.Text;
            }
            else {
                dateComment.Add(date, this.textBox1.Text);
            }  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            String date2 = this.monthCalendar1.SelectionRange.Start.ToString();


            if (dateComment.ContainsKey(date2))
            {
                this.label2.Text = dateComment[date2];
            }
            else
            {
                this.label2.Text = "Geen notitie";
            }
          
        }

        private void DropDown(object sender, EventArgs e)
        {

        }

      
    }
}
