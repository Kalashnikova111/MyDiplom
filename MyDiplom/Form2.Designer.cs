namespace MyDiplom
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label текст_записиLabel;
            System.Windows.Forms.Label дата_напоминанияLabel;
            System.Windows.Forms.Label день_неделиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button5 = new System.Windows.Forms.Button();
            this.BasicData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bDDataSet = new MyDiplom.BDDataSet();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new MyDiplom.BDDataSetTableAdapters.ГруппыTableAdapter();
            this.tableAdapterManager = new MyDiplom.BDDataSetTableAdapters.TableAdapterManager();
            this.датаTextBox = new System.Windows.Forms.TextBox();
            this.текст_записиTextBox = new System.Windows.Forms.TextBox();
            this.дата_напоминанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.день_неделиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bDDataSet1 = new MyDiplom.BDDataSet1();
            this.группыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter1 = new MyDiplom.BDDataSet1TableAdapters.ГруппыTableAdapter();
            this.tableAdapterManager1 = new MyDiplom.BDDataSet1TableAdapters.TableAdapterManager();
            датаLabel = new System.Windows.Forms.Label();
            текст_записиLabel = new System.Windows.Forms.Label();
            дата_напоминанияLabel = new System.Windows.Forms.Label();
            день_неделиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(22, 67);
            датаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 63;
            датаLabel.Text = "Дата:";
            // 
            // текст_записиLabel
            // 
            текст_записиLabel.AutoSize = true;
            текст_записиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            текст_записиLabel.Location = new System.Drawing.Point(22, 101);
            текст_записиLabel.Name = "текст_записиLabel";
            текст_записиLabel.Size = new System.Drawing.Size(112, 20);
            текст_записиLabel.TabIndex = 64;
            текст_записиLabel.Text = "Текст записи:";
            // 
            // дата_напоминанияLabel
            // 
            дата_напоминанияLabel.AutoSize = true;
            дата_напоминанияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_напоминанияLabel.Location = new System.Drawing.Point(21, 153);
            дата_напоминанияLabel.Name = "дата_напоминанияLabel";
            дата_напоминанияLabel.Size = new System.Drawing.Size(157, 20);
            дата_напоминанияLabel.TabIndex = 65;
            дата_напоминанияLabel.Text = "Дата напоминания:";
            // 
            // день_неделиLabel
            // 
            день_неделиLabel.AutoSize = true;
            день_неделиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            день_неделиLabel.Location = new System.Drawing.Point(22, 194);
            день_неделиLabel.Name = "день_неделиLabel";
            день_неделиLabel.Size = new System.Drawing.Size(113, 20);
            день_неделиLabel.TabIndex = 66;
            день_неделиLabel.Text = "День недели:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(413, 120);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 41);
            this.button5.TabIndex = 53;
            this.button5.Text = "ДОБАВИТЬ ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BasicData
            // 
            this.BasicData.AutoSize = true;
            this.BasicData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasicData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BasicData.Location = new System.Drawing.Point(38, -27);
            this.BasicData.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
            this.BasicData.Name = "BasicData";
            this.BasicData.Size = new System.Drawing.Size(311, 24);
            this.BasicData.TabIndex = 51;
            this.BasicData.Text = "Акт о выделении к уничтожению ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(146, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Добавить дела на сегодня :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(413, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 62;
            this.button1.Text = "ВЫХОД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.bDDataSet;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MyDiplom.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыTableAdapter = this.группыTableAdapter;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.СостояниеTableAdapter = null;
            // 
            // датаTextBox
            // 
            this.датаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource, "Дата", true));
            this.датаTextBox.Location = new System.Drawing.Point(185, 196);
            this.датаTextBox.Name = "датаTextBox";
            this.датаTextBox.Size = new System.Drawing.Size(200, 20);
            this.датаTextBox.TabIndex = 64;
            // 
            // текст_записиTextBox
            // 
            this.текст_записиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource, "Текст записи", true));
            this.текст_записиTextBox.Location = new System.Drawing.Point(185, 101);
            this.текст_записиTextBox.Name = "текст_записиTextBox";
            this.текст_записиTextBox.Size = new System.Drawing.Size(200, 20);
            this.текст_записиTextBox.TabIndex = 65;
            // 
            // дата_напоминанияDateTimePicker
            // 
            this.дата_напоминанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "Дата напоминания", true));
            this.дата_напоминанияDateTimePicker.Location = new System.Drawing.Point(185, 152);
            this.дата_напоминанияDateTimePicker.Name = "дата_напоминанияDateTimePicker";
            this.дата_напоминанияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_напоминанияDateTimePicker.TabIndex = 66;
            // 
            // день_неделиDateTimePicker
            // 
            this.день_неделиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "День недели", true));
            this.день_неделиDateTimePicker.Location = new System.Drawing.Point(185, 67);
            this.день_неделиDateTimePicker.Name = "день_неделиDateTimePicker";
            this.день_неделиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.день_неделиDateTimePicker.TabIndex = 67;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet1";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource1
            // 
            this.группыBindingSource1.DataMember = "Группы";
            this.группыBindingSource1.DataSource = this.bDDataSet1;
            // 
            // группыTableAdapter1
            // 
            this.группыTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = MyDiplom.BDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГруппыTableAdapter = this.группыTableAdapter1;
            this.tableAdapterManager1.ЗаписиTableAdapter = null;
            this.tableAdapterManager1.СостояниеTableAdapter = null;
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 229);
            this.Controls.Add(день_неделиLabel);
            this.Controls.Add(this.день_неделиDateTimePicker);
            this.Controls.Add(дата_напоминанияLabel);
            this.Controls.Add(this.дата_напоминанияDateTimePicker);
            this.Controls.Add(текст_записиLabel);
            this.Controls.Add(this.текст_записиTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BasicData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Добавить дела ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label BasicData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private BDDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox датаTextBox;
        private System.Windows.Forms.TextBox текст_записиTextBox;
        private System.Windows.Forms.DateTimePicker дата_напоминанияDateTimePicker;
        private System.Windows.Forms.DateTimePicker день_неделиDateTimePicker;
        private BDDataSet1 bDDataSet1;
        private System.Windows.Forms.BindingSource группыBindingSource1;
        private BDDataSet1TableAdapters.ГруппыTableAdapter группыTableAdapter1;
        private BDDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}