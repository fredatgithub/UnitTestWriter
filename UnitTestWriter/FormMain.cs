using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestWriter
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {

    }

    private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBoxApplication aboutBoxApplication = new AboutBoxApplication();
      _ = aboutBoxApplication.ShowDialog();
    }

    private void ButtonWrite_Click(object sender, EventArgs e)
    {
      if (textBoxSource.Text == string.Empty)
      {
        MessageBox.Show("You have to paste a base method", "No Method", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return;
      }

      textBoxUnitTests.Text = string.Empty;

    }
  }
}
