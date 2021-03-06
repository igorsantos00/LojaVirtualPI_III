﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaTeste
{
    public partial class MdiMenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MdiMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // childForm = new frmPrincipal();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();

            //frmMenu frmp = new frmMenu();
            //frmp.MdiParent = this;
            //frmp.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //Form tela = new Form1();
            //tela.MdiParent = this;
            //tela.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form tela = new frmUsuario();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form tela = new frmCliente();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form tela = new frmStatusPedido();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form tela = new frmCategoria();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form tela = new frmEstoque();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //Form tela = new frmp();
            //tela.MdiParent = this;
            //tela.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto();
            tela.MdiParent = this;
            tela.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Form tela = new frmPedido();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
