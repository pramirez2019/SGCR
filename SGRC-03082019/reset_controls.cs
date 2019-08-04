using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAddUser
{
    class reset_controls
    {
        public void reset(Panel p)  //panel and control classes depends of System.Windows.Froms namespace 
        {
             
            foreach (Control c in p.Controls)  //We read all panel and their controls
            {

                if (c is TextBox)  //Checking textboxes, ignoring labels and buttons
                {
                    TextBox t = (TextBox)c; //We do type casting here. I'm converting c in textbox and assigning to t. Casting is a way to convert values from one type to another.
                    t.Text = "";
                }
                
                
            }

        }
    }
}


