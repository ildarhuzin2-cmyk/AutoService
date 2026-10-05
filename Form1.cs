using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        List<Appointment> list = new List<Appointment>();
        int nextId = 1;

        public Form1()
        {
            InitializeComponent();

            dgvAppointments.Columns.Add("c1", "Id");
            dgvAppointments.Columns.Add("c2", "Дата и время");
            dgvAppointments.Columns.Add("c3", "ФИО клиента");
            dgvAppointments.Columns.Add("c4", "Телефон");
            dgvAppointments.Columns.Add("c5", "Марка/модель");
            dgvAppointments.Columns.Add("c6", "Гос. номер");
            dgvAppointments.Columns[0].FillWeight = 30;
            dgvAppointments.Columns[2].FillWeight = 150;

            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnDeleteById.Click += btnDeleteById_Click;
            btnLastMonth.Click += btnLastMonth_Click;
            btnShowAll.Click += btnShowAll_Click;
            btnSearchPlate.Click += btnSearchPlate_Click;
            btnSearchName.Click += btnSearchName_Click;

            txtDeleteId.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        void Fill(List<Appointment> l)
        {
            dgvAppointments.Rows.Clear();
            foreach (var a in l)
            {
                dgvAppointments.Rows.Add(a.Id, a.DateTime.ToString("dd.MM.yyyy HH:mm"), a.Client.Name, a.Client.Phone, a.Car.Model, a.Car.Number);
            }
        }

        void btnAdd_Click(object? sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtModel.Text.Trim() == "" || txtPlate.Text.Trim() == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Client c = new Client(txtFullName.Text.Trim(), txtPhone.Text.Trim());
            Car car = new Car(txtModel.Text.Trim(), txtPlate.Text.Trim());
            list.Add(new Appointment(nextId, c, car, dtpVisit.Value));
            nextId++;

            txtFullName.Clear();
            txtPhone.Clear();
            txtModel.Clear();
            txtPlate.Clear();
            Fill(list);
        }

        void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            int id = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            list.RemoveAll(a => a.Id == id);
            Fill(list);
        }

        void btnDeleteById_Click(object? sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtDeleteId.Text, out id))
            {
                MessageBox.Show("Введите Id");
                return;
            }
            int n = list.RemoveAll(a => a.Id == id);
            if (n == 0)
            {
                MessageBox.Show("Такой записи нет");
                return;
            }
            txtDeleteId.Clear();
            Fill(list);
        }

        void btnLastMonth_Click(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var r = list.Where(a => a.DateTime >= now.AddMonths(-1) && a.DateTime <= now).ToList();
            Fill(r);
            if (r.Count == 0) MessageBox.Show("Ничего не найдено");
        }

        void btnShowAll_Click(object? sender, EventArgs e)
        {
            Fill(list);
        }

        void btnSearchPlate_Click(object? sender, EventArgs e)
        {
            string p = txtSearchPlate.Text.Replace(" ", "").ToUpper();
            if (p == "")
            {
                MessageBox.Show("Введите номер");
                return;
            }
            var r = list.Where(a => a.Car.Number.Replace(" ", "").ToUpper().Contains(p)).ToList();
            Fill(r);
            if (r.Count == 0) MessageBox.Show("Ничего не найдено");
        }

        void btnSearchName_Click(object? sender, EventArgs e)
        {
            string p = txtSearchName.Text.Trim().ToLower();
            if (p == "")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }
            var r = list.Where(a => a.Client.Name.ToLower().Contains(p)).ToList();
            Fill(r);
            if (r.Count == 0) MessageBox.Show("Ничего не найдено");
        }

        private void groupBox1_Enter(object? sender, EventArgs e) { }
        private void textBox2_TextChanged(object? sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object? sender, EventArgs e) { }
        private void groupBox1_Enter_1(object? sender, EventArgs e) { }
        private void button2_Click(object? sender, EventArgs e) { }
        private void txtSearchPlate_TextChanged_1(object? sender, EventArgs e) { }
        private void label7_Click_1(object? sender, EventArgs e) { }
        private void Form1_Load(object? sender, EventArgs e) { }
    }
}