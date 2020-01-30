// C# .NET
//
// DocString
//
// author: Simon Renblad
// version: 0.1.0
// license: MIT

using System;
using System.Windows.Forms;
using System.Drawing;

namespace First
{
    public class MyForm : Form
    {

        public MyForm()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            Text = "First application";
            ClientSize = new Size(800, 450);
            // add stuff to frame here
            CenterToScreen();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MyForm());
        }
    }
}
