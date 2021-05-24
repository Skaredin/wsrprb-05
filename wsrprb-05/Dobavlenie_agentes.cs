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
    public partial class Dobavlenie_agentes : Form
    {
        public Dobavlenie_agentes()
        {
            InitializeComponent();
            add.MouseEnter += OnMouseEnterMenuStripAdd;
            add.MouseLeave += OnMouseEnterMenuStripAdd;
            Save.MouseEnter += OnMouseEnterMenuStripSave;
            Save.MouseLeave += OnMouseEnterMenuStripSave;
            add.MouseEnter += OnMouseEnterMenuStripNazad;
            add.MouseLeave += OnMouseEnterMenuStripNazad;
        }
        private void OnMouseEnterMenuStripAdd(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripAdd(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStripSave(object sender, EventArgs e)
        {
            Save.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripSave(object sender, EventArgs e)
        {
            Save.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStripNazad(object sender, EventArgs e)
        {
            Nazad.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripNazad(object sender, EventArgs e)
        {
            Nazad.BackColor = Color.FromArgb(198, 215, 255);

        }
       
        
        private void add_Click(object sender, EventArgs e)
        {
            agentBindingSource.AddNew();
            MessageBox.Show("После добавления данных нужно сохранить");

        }

        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);

        }

        private void Dobavlenie_agentes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_wsrprb_05DataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this._wsrprb_05DataSet.Agent);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);

            MessageBox.Show("Данные сохранены");
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);
            this.Hide();
            Agentes agentes = new Agentes();
            agentes.Show();
        }
    }
}
