using System.Windows.Forms;

namespace main_form
{
    public partial class Form_Main : Form
    {
        PanelWork pw = new PanelWork();

        public Form_Main()
        {
            InitializeComponent();
            setUpPanel();
        }

        private void setUpPanel()
        {
            pw.CurrentChildForm = new FormFunction();
            pw.OpenChildForm(pw.CurrentChildForm, pan_funtion);

            pw.CurrentChildForm = new FormOrder();
            pw.OpenChildForm(pw.CurrentChildForm, pan_order);
        }
    }
}
