﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Xenia.Debug.UI.Controls {
  public partial class BasePanel : DockContent {
    public static MainWindow MainWindow;

    public BasePanel() {
      InitializeComponent();
    }
  }
}
