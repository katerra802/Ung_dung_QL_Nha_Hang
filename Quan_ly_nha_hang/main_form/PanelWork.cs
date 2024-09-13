using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public class PanelWork
    {
        private Form currentChildForm = null;

        public Form CurrentChildForm { get => currentChildForm; set => currentChildForm = value; }

        public void OpenChildForm(Form childForm, Panel panelContent)
        {

            if (CurrentChildForm != null && CurrentChildForm.GetType() == childForm.GetType())
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(childForm);
                panelContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                return;
            }

            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            return;
        }
    }
}
