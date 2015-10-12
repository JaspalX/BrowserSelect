﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrowserSelect {
    public partial class BrowserUC : UserControl {
        public Browser browser;
        public BrowserUC(Browser b) {
            InitializeComponent();

            this.browser = b;

            name.Text = b.name;
            shortcuts.Text = "( " + String.Join(",", b.shortcuts) + " )";
            shortcuts.ForeColor = Color.FromKnownColor(KnownColor.GrayText);
            icon.Image = b.icon.ToBitmap();
            icon.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public new event EventHandler Click {
            add {
                base.Click += value;
                foreach (Control control in Controls) {
                    control.Click += value;
                }
            }
            remove {
                base.Click -= value;
                foreach (Control control in Controls) {
                    control.Click -= value;
                }
            }
        }
    }
}