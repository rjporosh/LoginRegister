﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class Main : Form
    {
        public Main(string name,string type)
        {
            InitializeComponent();
            lbl.Text = name;
            lblType.Text = type;
        }
    }
}
