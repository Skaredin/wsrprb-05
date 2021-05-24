using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsrprb_05
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Agents.MouseEnter += OnMouseEnterMenuStrip1;
            Agents.MouseLeave += OnMouseLeaveMenuStrip1;
            Prodaga.MouseEnter += OnMouseEnterMenuStrip2;
            Prodaga.MouseLeave += OnMouseLeaveMenuStrip2;
            Produktes.MouseEnter += OnMouseEnterMenuStrip3;
            Produktes.MouseLeave += OnMouseLeaveMenuStrip3;
        }
        private void OnMouseEnterMenuStrip1(object sender, EventArgs e)
        {
            Agents.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want
       
        }
        private void OnMouseLeaveMenuStrip1(object sender, EventArgs e)
        {
            Agents.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStrip2(object sender, EventArgs e)
        {
            Prodaga.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStrip2(object sender, EventArgs e)
        {
            Prodaga.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStrip3(object sender, EventArgs e)
        {
            Produktes.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStrip3(object sender, EventArgs e)
        {
            Produktes.BackColor = Color.FromArgb(198, 215, 255);

        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void агентToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Agents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agentes agentes = new Agentes();
            agentes.Show();
        }
    }
}
