using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public partial class FormOrder : Form
    {
        PanelWork pw = new PanelWork();
        public FormOrder()
        {
            InitializeComponent();
            setUpOrder();
        }

        private void setUpOrder()
        {
            pw.CurrentChildForm = new FormTable();
            pw.OpenChildForm(pw.CurrentChildForm, pan_table);


            pw.CurrentChildForm = new FormDetail();
            pw.OpenChildForm(pw.CurrentChildForm, pan_detail);
        }
    }
}
