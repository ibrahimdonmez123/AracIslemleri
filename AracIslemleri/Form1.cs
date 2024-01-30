using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aracTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aracTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aracDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.aracTableTableAdapter.Fill(this.aracDataSet.AracTable);

        }
    }
}
