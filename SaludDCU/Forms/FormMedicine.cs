using SaludDCU.Layers.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludDCU.Forms
{
    public partial class FormMedicine : Form
    {
        int id = 0;
        Presentacion presentacion = new Presentacion();
        public FormMedicine()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }
        }
        private void MostrarTablaMedicina()
        {
            dgvMedicine.DataSource = presentacion.MostrarTablaMedicine();
        }

        private void CleanControlsMedicina()
        {
            txtMedicineName.Text = null;
            txtLaboratory.Text = null;
            rtbComentary.Text = null;
            txtPrice.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtMedicineName.Text;
                string lab = txtLaboratory.Text;
                string TypeMedicine = cbType.SelectedItem.ToString();
                string comentary = rtbComentary.Text;
                float price = float.Parse(txtPrice.Text);

                presentacion.InsertarMedicine(name, lab, TypeMedicine, comentary,price);
                MessageBox.Show("Record Saved Successfully");
                MostrarTablaMedicina();
                CleanControlsMedicina();
            }
            catch (Exception)
            {
                MessageBox.Show("Record Seved");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //editar dicha fila
                string name = txtMedicineName.Text;
                string lab = txtLaboratory.Text;
                string TypeMedicine = cbType.SelectedItem.ToString();
                string comentary = rtbComentary.Text;
                float price = float.Parse(txtPrice.Text);

                presentacion.EditarMedicine(name, lab, TypeMedicine, comentary, price, id);
                MessageBox.Show("Record Updated Successfully");
                MostrarTablaMedicina();
                CleanControlsMedicina();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a complete row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvMedicine.SelectedRows[0].Cells[0].Value);
                presentacion.EliminarMedicine(id);
                MessageBox.Show("Record Deleted Successfully");
                MostrarTablaMedicina();
                CleanControlsMedicina();
                id = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Select a complete row");
            }
        }

        private void dgvMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //tratar de conseguir la fila de la tabla a editar
                id = Convert.ToInt32(dgvMedicine.SelectedRows[0].Cells[0].Value);
                txtMedicineName.Text = dgvMedicine.SelectedRows[0].Cells[1].Value.ToString();
                txtLaboratory.Text = dgvMedicine.SelectedRows[0].Cells[2].Value.ToString();
                rtbComentary.Text = dgvMedicine.SelectedRows[0].Cells[4].Value.ToString();
                txtPrice.Text = dgvMedicine.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a complete row");
            }
        }

        private void FormMedicine_Load(object sender, EventArgs e)
        {
            MostrarTablaMedicina();
        }
    }
}
