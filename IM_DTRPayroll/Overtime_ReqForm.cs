using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_DTRPayroll
{
    public partial class Overtime_ReqForm : Form
    {
        public Overtime_ReqForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = overtime_timepicker_FROM.Value;
            // Use the selectedTime variable as needed, such as storing it in your database or processing it.
        }

        private void Overtime_ReqForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
