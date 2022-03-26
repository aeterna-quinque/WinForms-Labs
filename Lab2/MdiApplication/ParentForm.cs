using System;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 1;

        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(DateTime.Today.ToLongDateString());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text += $" {openDocuments++}";
            newChild.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text += $" {openDocuments++}";
                    break;
                case "Cascade":
                    LayoutMdi(MdiLayout.Cascade);
                    spWin.Text = "Window is cascade";
                    break;
                case "Tile":
                    LayoutMdi(MdiLayout.TileHorizontal);
                    spWin.Text = "Window is horizontal";
                    break;
            }
        }
    }
}
