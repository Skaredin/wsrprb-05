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
    public partial class Redaktirovanie_agentes : Form
    {
        public Redaktirovanie_agentes()
        {
            InitializeComponent();
            Left.MouseEnter += OnMouseEnterMenuStripLeft;
            Left.MouseLeave += OnMouseEnterMenuStripLeft;
            Rigiht.MouseEnter += OnMouseEnterMenuStripRigiht;
            Rigiht.MouseLeave += OnMouseEnterMenuStripRigiht;
            Save.MouseEnter += OnMouseLeaveMenuStripSave;
            Save.MouseLeave += OnMouseLeaveMenuStripSave;
            Deleted.MouseEnter += OnMouseEnterMenuStripDeleted;
            Deleted.MouseLeave += OnMouseEnterMenuStripDeleted;

        }
        private void OnMouseEnterMenuStripLeft(object sender, EventArgs e)
        {
            Left.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripLeft(object sender, EventArgs e)
        {
            Left.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStripRigiht(object sender, EventArgs e)
        {
            Rigiht.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripRigiht(object sender, EventArgs e)
        {
            Rigiht.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStripSave(object sender, EventArgs e)
        {
            Save.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripSave(object sender, EventArgs e)
        {
            Save.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStripDeleted(object sender, EventArgs e)
        {
            Deleted.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStripDeleted(object sender, EventArgs e)
        {
            Deleted.BackColor = Color.FromArgb(198, 215, 255);

        }

        private void Photo()
        {
            try
            {
                PhotoPB.Image = Image.FromFile(logoComboBox.Text.Replace(@" ", @""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);

        }

        private void agentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);

        }

        private void Redaktirovanie_agentes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_wsrprb_05DataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this._wsrprb_05DataSet.Agent);

        }

        private void Left_Click(object sender, EventArgs e)
        {
            agentBindingSource.MovePrevious();
            if (logoComboBox.Text != "") { Photo(); }
           
        }

        private void Rigiht_Click(object sender, EventArgs e)
        {
            agentBindingSource.MovePrevious();
            if (logoComboBox.Text != "") { Photo(); }
        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                agentBindingSource.RemoveCurrent();
                this.Validate();
                this.agentBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);
            }
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
