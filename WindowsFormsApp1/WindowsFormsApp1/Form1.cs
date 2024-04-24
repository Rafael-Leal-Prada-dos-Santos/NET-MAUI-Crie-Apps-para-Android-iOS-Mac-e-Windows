using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGPLUSLib;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static SigPlus sig = new SigPlus();

        public Form1()
        {
            InitializeComponent();
        }

        public void InitTablet()
        {
            sig.InitSigPlus();
        }

        
    }
}
