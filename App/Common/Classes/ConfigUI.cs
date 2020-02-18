using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Common.Classes
{
    public class ConfigUI
    {
        public static void LaunchChildForm(Form myForm, Form myParent)
        {
            myForm.MdiParent = myParent;
            myForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myForm.ControlBox = false;
            myForm.MaximizeBox = false;
            myForm.MinimizeBox = false;
            //myForm.MOVEABLE LOCK o lo que sea
            myForm.Dock = DockStyle.Fill;
            myForm.Show();
        }

        public static DialogResult LaunchDialogForm(Form myForm)
        {
            myForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            myForm.ControlBox = false;
            myForm.MaximizeBox = false;
            myForm.MinimizeBox = false;
            //myForm.MOVEABLE LOCK o lo que sea
            
            return myForm.ShowDialog();
        }
    }
}
