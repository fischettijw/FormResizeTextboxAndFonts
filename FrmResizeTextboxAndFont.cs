using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResizeTextboxAndFonts
{
    public partial class FrmResizeTextboxAndFont : Form
    {
        ResizeFormControls ReSizeFrm;
        public FrmResizeTextboxAndFont()
        {
            InitializeComponent();
        }

        private void FrmResizeTextboxAndFont_Load(object sender, EventArgs e)
        {
            ReSizeFrm = new ResizeFormControls(this);
        }

        private void FrmResizeTextboxAndFont_Resize(object sender, EventArgs e)
        {
            ReSizeFrm.ResizeControls();
        }
    }


    public class ResizeFormControls
    {
        Rectangle frmResizeInit;
        Dictionary<string, Control> ctrls = new Dictionary<string, Control>();

        private Form FrmToResize;

        public ResizeFormControls(Form frm)
        {
            FrmToResize = frm;

            frmResizeInit = new Rectangle(frm.ClientRectangle.X, frm.ClientRectangle.Y,
                   frm.ClientRectangle.Width, frm.ClientRectangle.Height);
            frm.Tag = frmResizeInit;

            foreach (Control ctrl in frm.Controls)
            {
                ctrl.Tag = new Rectangle(ctrl.Left, ctrl.Top, ctrl.Width, ctrl.Height);
                ctrls.Add(ctrl.Name, ctrl);

                //if (ctrl.GetType() == typeof(TextBox)) { MessageBox.Show(((TextBox)ctrl).Multiline.ToString()); }
            }

        }

        public void ResizeControls()
        {
            float xRatio = (float)FrmToResize.ClientRectangle.Width / (float)((Rectangle)FrmToResize.Tag).Width;
            float yRatio = (float)FrmToResize.ClientRectangle.Height / (float)((Rectangle)FrmToResize.Tag).Height;

            foreach (Control ctrl in FrmToResize.Controls)
            {
                ctrl.Left = Convert.ToInt32((((Rectangle)ctrls[ctrl.Name].Tag).Left) * xRatio);
                ctrl.Top = Convert.ToInt32((((Rectangle)ctrls[ctrl.Name].Tag).Top) * yRatio);
                ctrl.Width = Convert.ToInt32((((Rectangle)ctrls[ctrl.Name].Tag).Width) * xRatio);
                ctrl.Height = Convert.ToInt32((((Rectangle)ctrls[ctrl.Name].Tag).Height) * yRatio);

                //if (ctrl.GetType() == typeof(TextBox))
                //{
                //    ctrl.Top = ctrl.Top + (ctrl.Height / 2);
                //}
            }
        }

    }
}
