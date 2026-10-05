namespace AutoService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAdd = new GroupBox();
            btnAdd = new Button();
            dtpVisit = new DateTimePicker();
            label5 = new Label();
            txtPlate = new TextBox();
            label4 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            grpSearch = new GroupBox();
            label7 = new Label();
            txtSearchPlate = new TextBox();
            txtSearchName = new TextBox();
            btnSearchName = new Button();
            label6 = new Label();
            btnSearchPlate = new Button();
            btnShowAll = new Button();
            btnLastMonth = new Button();
            dgvAppointments = new DataGridView();
            btnDelete = new Button();
            btnDeleteById = new Button();
            label8 = new Label();
            txtDeleteId = new TextBox();
            grpAdd.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Controls.Add(dtpVisit);
            grpAdd.Controls.Add(label5);
            grpAdd.Controls.Add(txtPlate);
            grpAdd.Controls.Add(label4);
            grpAdd.Controls.Add(txtModel);
            grpAdd.Controls.Add(label3);
            grpAdd.Controls.Add(txtPhone);
            grpAdd.Controls.Add(label2);
            grpAdd.Controls.Add(txtFullName);
            grpAdd.Controls.Add(label1);
            grpAdd.Location = new Point(12, 35);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(299, 300);
            grpAdd.TabIndex = 1;
            grpAdd.TabStop = false;
            grpAdd.Text = "Новая запись";
            grpAdd.Enter += groupBox1_Enter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить запись";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtpVisit
            // 
            dtpVisit.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpVisit.Format = DateTimePickerFormat.Custom;
            dtpVisit.Location = new Point(6, 219);
            dtpVisit.Name = "dtpVisit";
            dtpVisit.Size = new Size(200, 23);
            dtpVisit.TabIndex = 9;
            dtpVisit.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 201);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 8;
            label5.Text = "Дата и время визита";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(93, 141);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 144);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Гос. номер";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(93, 99);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 102);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Марка/модель";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(93, 59);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Телефон";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(94, 19);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО клиента";
            // 
            // grpSearch
            // 
            grpSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSearch.Controls.Add(label7);
            grpSearch.Controls.Add(txtSearchPlate);
            grpSearch.Controls.Add(txtSearchName);
            grpSearch.Controls.Add(btnSearchName);
            grpSearch.Controls.Add(label6);
            grpSearch.Controls.Add(btnSearchPlate);
            grpSearch.Controls.Add(btnShowAll);
            grpSearch.Controls.Add(btnLastMonth);
            grpSearch.Location = new Point(332, 12);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(640, 120);
            grpSearch.TabIndex = 2;
            grpSearch.TabStop = false;
            grpSearch.Text = "Поиск";
            grpSearch.Enter += groupBox1_Enter_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 61);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 7;
            label7.Text = "ФИО";
            label7.Click += label7_Click_1;
            // 
            // txtSearchPlate
            // 
            txtSearchPlate.Location = new Point(100, 90);
            txtSearchPlate.Name = "txtSearchPlate";
            txtSearchPlate.Size = new Size(150, 23);
            txtSearchPlate.TabIndex = 6;
            txtSearchPlate.TextChanged += txtSearchPlate_TextChanged_1;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(100, 58);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(150, 23);
            txtSearchName.TabIndex = 8;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(256, 54);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(70, 27);
            btnSearchName.TabIndex = 3;
            btnSearchName.Text = "Найти";
            btnSearchName.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 90);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 4;
            label6.Text = "Номер авто";
            // 
            // btnSearchPlate
            // 
            btnSearchPlate.Location = new Point(256, 87);
            btnSearchPlate.Name = "btnSearchPlate";
            btnSearchPlate.Size = new Size(70, 27);
            btnSearchPlate.TabIndex = 2;
            btnSearchPlate.Text = "Найти";
            btnSearchPlate.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(185, 25);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(130, 30);
            btnShowAll.TabIndex = 1;
            btnShowAll.Text = "Показать все";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += button2_Click;
            // 
            // btnLastMonth
            // 
            btnLastMonth.Location = new Point(15, 25);
            btnLastMonth.Name = "btnLastMonth";
            btnLastMonth.Size = new Size(160, 30);
            btnLastMonth.TabIndex = 0;
            btnLastMonth.Text = "За последний месяц";
            btnLastMonth.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(330, 145);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(640, 330);
            dgvAppointments.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(330, 485);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 32);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Отменить выбранную запись";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteById
            // 
            btnDeleteById.AllowDrop = true;
            btnDeleteById.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteById.Location = new Point(710, 485);
            btnDeleteById.Name = "btnDeleteById";
            btnDeleteById.Size = new Size(160, 32);
            btnDeleteById.TabIndex = 13;
            btnDeleteById.Text = "Отменить по Id";
            btnDeleteById.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(570, 493);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 14;
            label8.Text = "Id записи";
            // 
            // txtDeleteId
            // 
            txtDeleteId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDeleteId.Location = new Point(640, 490);
            txtDeleteId.MaxLength = 9;
            txtDeleteId.Name = "txtDeleteId";
            txtDeleteId.Size = new Size(60, 23);
            txtDeleteId.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(txtDeleteId);
            Controls.Add(label8);
            Controls.Add(btnDeleteById);
            Controls.Add(btnDelete);
            Controls.Add(dgvAppointments);
            Controls.Add(grpSearch);
            Controls.Add(grpAdd);
            Name = "Form1";
            Text = "Автосервис: очередь на ремонт";
            Load += Form1_Load;
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAdd;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtPhone;
        private Label label2;
        private DateTimePicker dtpVisit;
        private Label label5;
        private TextBox txtPlate;
        private Label label4;
        private Button btnAdd;
        private GroupBox grpSearch;
        private Button btnSearchName;
        private Button btnSearchPlate;
        private Button btnShowAll;
        private Button btnLastMonth;
        private TextBox txtSearchPlate;
        private Label label6;
        private Label label7;
        private TextBox txtSearchName;
        private DataGridView dgvAppointments;
        private Button btnDelete;
        private Button btnDeleteById;
        private Label label8;
        private TextBox txtDeleteId;
    }
}
