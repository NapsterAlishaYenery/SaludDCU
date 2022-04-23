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
    public partial class FormDoctores : Form
    {
        int id = 0;
        Presentacion presentacion = new Presentacion();
        public FormDoctores()
        {
            InitializeComponent();
            LoadTheme();
        }

        //Aplicando colores del tema actual
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

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            MostrarTablaDoctores();
        }
        private void MostrarTablaDoctores()
        {
            dgvDoctors.DataSource = presentacion.MostrarTablaDoctores();
        }

        private void CleanControlsDoctors()
        {
            txtUserNam.Text = null;
            txtPassword.Text = null;
            txtName.Text = null;
            txtLastName.Text = null;
            txtSpecialty.Text = null;
            txtPosition.Text = null;
            txtSalary.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string User = txtUserNam.Text;
                string Password = txtPassword.Text;
                string name = txtName.Text;
                string lastname = txtLastName.Text;
                string specialty = txtSpecialty.Text;
                DateTime dateTime = dtpDateOfBirth.Value.ToUniversalTime();
                string position = txtPosition.Text;
                float salario = float.Parse(txtSalary.Text);

                presentacion.InsertarDoctores(User, Password, name, lastname, specialty, dateTime, position, salario);
                MessageBox.Show("Record Saved Successfully");
                MostrarTablaDoctores();
                CleanControlsDoctors();
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
                string User = txtUserNam.Text;
                string Password = txtPassword.Text;
                string name = txtName.Text;
                string lastname = txtLastName.Text;
                string specialty = txtSpecialty.Text;
                DateTime dateTime = dtpDateOfBirth.Value.ToUniversalTime();
                string position = txtPosition.Text;
                float salario = float.Parse(txtSalary.Text);

                presentacion.EditarDoctores(User, Password, name, lastname, specialty, dateTime, position, salario, id);
                MessageBox.Show("Record Updated Successfully");
                MostrarTablaDoctores();
                CleanControlsDoctors();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a complete row");
            }
        }

        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //tratar de conseguir la fila de la tabla a editar
                id = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);
                txtUserNam.Text = dgvDoctors.SelectedRows[0].Cells[1].Value.ToString();
                txtName.Text = dgvDoctors.SelectedRows[0].Cells[3].Value.ToString();
                txtLastName.Text = dgvDoctors.SelectedRows[0].Cells[4].Value.ToString();
                txtSpecialty.Text = dgvDoctors.SelectedRows[0].Cells[5].Value.ToString();
                txtPosition.Text = dgvDoctors.SelectedRows[0].Cells[7].Value.ToString();
                txtSalary.Text = dgvDoctors.SelectedRows[0].Cells[8].Value.ToString();
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
                id = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells[0].Value);
                presentacion.EliminarDoctores(id);
                MessageBox.Show("Record Deleted Successfully");
                MostrarTablaDoctores();
                id = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Select a complete row");
            }
        }
    }
}
