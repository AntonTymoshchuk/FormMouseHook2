using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMouseHook2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RamGecTools.MouseHook MouseHook = new RamGecTools.MouseHook();
            MouseHook.Install();
            MouseHook.LeftButtonDown += MouseHook_LeftButtonDown;
        }

        private void MouseHook_LeftButtonDown(RamGecTools.MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
