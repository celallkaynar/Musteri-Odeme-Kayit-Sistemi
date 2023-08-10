namespace OrnekDatatable
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxMiktar = new TextBox();
            comboBoxOdeme = new ComboBox();
            comboBoxKimden = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            textBoxFaturaNo = new TextBox();
            comboBoxSehir = new ComboBox();
            comboBoxFatura = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBoxMiktar);
            groupBox1.Controls.Add(comboBoxOdeme);
            groupBox1.Controls.Add(comboBoxKimden);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 249);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Ödeme Bilgileri";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBoxMiktar
            // 
            textBoxMiktar.Location = new Point(130, 67);
            textBoxMiktar.Name = "textBoxMiktar";
            textBoxMiktar.Size = new Size(250, 27);
            textBoxMiktar.TabIndex = 7;
            // 
            // comboBoxOdeme
            // 
            comboBoxOdeme.FormattingEnabled = true;
            comboBoxOdeme.Items.AddRange(new object[] { "Havale", "Eft", "Mastercard", "Visa" });
            comboBoxOdeme.Location = new Point(130, 106);
            comboBoxOdeme.Name = "comboBoxOdeme";
            comboBoxOdeme.Size = new Size(250, 28);
            comboBoxOdeme.TabIndex = 6;
            // 
            // comboBoxKimden
            // 
            comboBoxKimden.FormattingEnabled = true;
            comboBoxKimden.Items.AddRange(new object[] { "Ahmet Kaya", "Remziye Sultan", "Fahriye Türk", "Turgut Alp", "Robert Brown", "Rıfkı Gökalp", "Semih Şentürk", "Güzel Afşin", "Polat Zenginoğlu", "Kemal Tanca", "Zeynep Demirel" });
            comboBoxKimden.Location = new Point(130, 28);
            comboBoxKimden.Name = "comboBoxKimden";
            comboBoxKimden.Size = new Size(250, 28);
            comboBoxKimden.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 150);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Ödeme Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Miktarı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Ödeme Yöntemi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kimden Aldı";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(431, 232);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBoxFaturaNo);
            groupBox2.Controls.Add(comboBoxSehir);
            groupBox2.Controls.Add(comboBoxFatura);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(544, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 249);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fatura Bilgileri";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(373, 153);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 11;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxFaturaNo
            // 
            textBoxFaturaNo.Enabled = false;
            textBoxFaturaNo.Location = new Point(141, 70);
            textBoxFaturaNo.Name = "textBoxFaturaNo";
            textBoxFaturaNo.Size = new Size(250, 27);
            textBoxFaturaNo.TabIndex = 9;
            // 
            // comboBoxSehir
            // 
            comboBoxSehir.FormattingEnabled = true;
            comboBoxSehir.Items.AddRange(new object[] { "Edinburg", "İstanbul", "London", "New York", "Paris", "San Francisco", "Seul", "Singapore", "Tokyo" });
            comboBoxSehir.Location = new Point(141, 109);
            comboBoxSehir.Name = "comboBoxSehir";
            comboBoxSehir.Size = new Size(250, 28);
            comboBoxSehir.TabIndex = 10;
            // 
            // comboBoxFatura
            // 
            comboBoxFatura.FormattingEnabled = true;
            comboBoxFatura.Items.AddRange(new object[] { "Bireysel", "Kurumsal" });
            comboBoxFatura.Location = new Point(141, 31);
            comboBoxFatura.Name = "comboBoxFatura";
            comboBoxFatura.Size = new Size(250, 28);
            comboBoxFatura.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 150);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 4;
            label8.Text = "Ödeme Kontrolü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 117);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 3;
            label7.Text = "Şehir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 2;
            label6.Text = "Fatura No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Fatura Türü";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1152, 284);
            dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 594);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxMiktar;
        private ComboBox comboBoxOdeme;
        private ComboBox comboBoxKimden;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private TextBox textBoxFaturaNo;
        private ComboBox comboBoxSehir;
        private ComboBox comboBoxFatura;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private DataGridView dataGridView1;
    }
}