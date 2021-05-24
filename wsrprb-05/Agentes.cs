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
    public partial class Agentes : Form
    {
        public Agentes()
        {
            InitializeComponent();
            Redaktirovanie.MouseEnter += OnMouseEnterMenuStrip1;
            Redaktirovanie.MouseLeave += OnMouseLeaveMenuStrip1;
            Add.MouseEnter += OnMouseEnterMenuStrip2;
            Add.MouseLeave += OnMouseLeaveMenuStrip2;
        }
        private void OnMouseEnterMenuStrip1(object sender, EventArgs e)
        {
            Redaktirovanie.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStrip1(object sender, EventArgs e)
        {
            Redaktirovanie.BackColor = Color.FromArgb(198, 215, 255);

        }
        private void OnMouseEnterMenuStrip2(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(70, 178, 157); // or Color.Red or whatever you want

        }
        private void OnMouseLeaveMenuStrip2(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(198, 215, 255);

        }




        private void agentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._wsrprb_05DataSet);

        }

        private void Agentes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_wsrprb_05DataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this._wsrprb_05DataSet.Agent);

        }

        private void Redaktirovanie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redaktirovanie_agentes redaktirovanie_Agentes = new Redaktirovanie_agentes();
            redaktirovanie_Agentes.Show();
        }

        private void SortirovkaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (SortirovkaName.Text == "От а до я")
                {
                    agentDataGridView.Sort(dataGridViewTextBoxColumn4, ListSortDirection.Ascending);
                    
                }
                else if (SortirovkaName.Text == "От я до а")
                {
                    agentDataGridView.Sort(dataGridViewTextBoxColumn4, ListSortDirection.Descending);
                  
                }
                else if (SortirovkaName.Text == "Всё")
                {
                    agentBindingSource.Filter = "";

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void SortirovkaPrioritet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (SortirovkaPrioritet.Text == "От а до я")
                {
                    agentDataGridView.Sort(dataGridViewTextBoxColumn15, ListSortDirection.Ascending);

                }
                else if (SortirovkaPrioritet.Text == "От я до а")
                {
                    agentDataGridView.Sort(dataGridViewTextBoxColumn15, ListSortDirection.Descending);

                }
                else if (SortirovkaPrioritet.Text == "Всё")
                {
                    agentBindingSource.Filter = "";

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FiltraciaTipAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltraciaTipAgent.Text == "Все")
            {
                agentBindingSource.Filter = "Tip_agenta like'*" + "" + "'";

            }
            else { agentBindingSource.Filter = "Tip_agenta like'*" + FiltraciaTipAgent.Text + "'"; }

        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                

                agentBindingSource.Filter = "Email like'*" + filter.Text + "*' or Telefon like'*" + filter.Text + "*' or Naimenovanie_agenta like'*" + filter.Text + "'" ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
