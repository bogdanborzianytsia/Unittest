namespace Diplom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.рухСтудентівBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рухСтудентівBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spusok_ychnivDataSet = new Diplom.Spusok_ychnivDataSet();
            this.рух_студентівTableAdapter = new Diplom.Spusok_ychnivDataSetTableAdapters.Рух_студентівTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spusok_ychnivDataSet1 = new Diplom.Spusok_ychnivDataSet();
            this.spusokychnivDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рухСтудентівBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusokychnivDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // рухСтудентівBindingSource1
            // 
            this.рухСтудентівBindingSource1.DataMember = "Рух студентів";
            this.рухСтудентівBindingSource1.DataSource = this.spusok_ychnivDataSet;
            // 
            // spusok_ychnivDataSet
            // 
            this.spusok_ychnivDataSet.DataSetName = "Spusok_ychnivDataSet";
            this.spusok_ychnivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рух_студентівTableAdapter
            // 
            this.рух_студентівTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dataGridView1.DataSource = this.рухСтудентівBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(117, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // spusok_ychnivDataSet1
            // 
            this.spusok_ychnivDataSet1.DataSetName = "Spusok_ychnivDataSet";
            this.spusok_ychnivDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spusokychnivDataSet1BindingSource
            // 
            this.spusokychnivDataSet1BindingSource.DataSource = this.spusok_ychnivDataSet1;
            this.spusokychnivDataSet1BindingSource.Position = 0;
            // 
            // рухСтудентівBindingSource2
            // 
            this.рухСтудентівBindingSource2.DataMember = "Рух студентів";
            this.рухСтудентівBindingSource2.DataSource = this.spusokychnivDataSet1BindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "група";
            this.dataGridViewTextBoxColumn1.HeaderText = "група";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Призвіщя,Ім\'я,По батькові";
            this.dataGridViewTextBoxColumn2.HeaderText = "Призвіщя,Ім\'я,По батькові";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "наказ на зарахування";
            this.dataGridViewTextBoxColumn3.HeaderText = "наказ на зарахування";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "джерело фінансування";
            this.dataGridViewTextBoxColumn4.HeaderText = "джерело фінансування";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "наказ на переведення на 2 курс";
            this.dataGridViewTextBoxColumn5.HeaderText = "наказ на переведення на 2 курс";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "наказ на переведення на 3 курс";
            this.dataGridViewTextBoxColumn6.HeaderText = "наказ на переведення на 3 курс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "наказ на переведення на 4 курс";
            this.dataGridViewTextBoxColumn7.HeaderText = "наказ на переведення на 4 курс";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "наказ на зміну прізвища";
            this.dataGridViewTextBoxColumn8.HeaderText = "наказ на зміну прізвища";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "наказ про надання  академ відпустки";
            this.dataGridViewTextBoxColumn9.HeaderText = "наказ про надання  академ відпустки";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "наказ про повернення з  академвідпустки";
            this.dataGridViewTextBoxColumn10.HeaderText = "наказ про повернення з  академвідпустки";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "наказ на зміну джерела фінансування";
            this.dataGridViewTextBoxColumn11.HeaderText = "наказ на зміну джерела фінансування";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "наказ на переведення на іншу спеціальність";
            this.dataGridViewTextBoxColumn12.HeaderText = "наказ на переведення на іншу спеціальність";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "наказ на відрахування в зв\'язку з завершенням навчання";
            this.dataGridViewTextBoxColumn13.HeaderText = "наказ на відрахування в зв\'язку з завершенням навчання";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "наказ на відрахування з інших причин";
            this.dataGridViewTextBoxColumn14.HeaderText = "наказ на відрахування з інших причин";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "номер договору на освітні послуги";
            this.dataGridViewTextBoxColumn15.HeaderText = "номер договору на освітні послуги";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "номер договору на оплату навчання";
            this.dataGridViewTextBoxColumn16.HeaderText = "номер договору на оплату навчання";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "пільги";
            this.dataGridViewTextBoxColumn17.HeaderText = "пільги";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusokychnivDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource рухСтудентівBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn групаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn призвіщяІмяПоБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаЗарахуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn джерелоФінансуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаПереведенняНа2КурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаПереведенняНа3КурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаПереведенняНа4КурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаЗмінуПрізвищаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказПроНаданняАкадемВідпусткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказПроПоверненняЗАкадемвідпусткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаЗмінуДжерелаФінансуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаПереведенняНаІншуСпеціальністьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаВідрахуванняВЗвязкуЗЗавершеннямНавчанняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наказНаВідрахуванняЗІншихПричинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговоруНаОсвітніПослугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговоруНаОплатуНавчанняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пільгиDataGridViewTextBoxColumn;
        private Spusok_ychnivDataSet spusok_ychnivDataSet;
        private System.Windows.Forms.BindingSource рухСтудентівBindingSource1;
        private Spusok_ychnivDataSetTableAdapters.Рух_студентівTableAdapter рух_студентівTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spusokychnivDataSet1BindingSource;
        private Spusok_ychnivDataSet spusok_ychnivDataSet1;
        private System.Windows.Forms.BindingSource рухСтудентівBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}

