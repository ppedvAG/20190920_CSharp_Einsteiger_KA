namespace KontoApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.accountDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CsvImport = new System.Windows.Forms.Button();
            this.lblDateDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CsvExport = new System.Windows.Forms.Button();
            this.tb_Balance = new System.Windows.Forms.TextBox();
            this.tb_Owner = new System.Windows.Forms.TextBox();
            this.btn_CreateAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(685, 344);
            this.dataGridView.TabIndex = 23;
            // 
            // accountDataBindingSource
            // 
            this.accountDataBindingSource.DataMember = "AccountData";
            // 
            // btn_CsvImport
            // 
            this.btn_CsvImport.Location = new System.Drawing.Point(425, 57);
            this.btn_CsvImport.Name = "btn_CsvImport";
            this.btn_CsvImport.Size = new System.Drawing.Size(97, 23);
            this.btn_CsvImport.TabIndex = 22;
            this.btn_CsvImport.Text = "CSV Import";
            this.btn_CsvImport.UseVisualStyleBackColor = true;
            // 
            // lblDateDisplay
            // 
            this.lblDateDisplay.AutoSize = true;
            this.lblDateDisplay.Location = new System.Drawing.Point(114, 79);
            this.lblDateDisplay.Name = "lblDateDisplay";
            this.lblDateDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblDateDisplay.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Datum";
            // 
            // btn_CsvExport
            // 
            this.btn_CsvExport.Location = new System.Drawing.Point(425, 28);
            this.btn_CsvExport.Name = "btn_CsvExport";
            this.btn_CsvExport.Size = new System.Drawing.Size(97, 23);
            this.btn_CsvExport.TabIndex = 19;
            this.btn_CsvExport.Text = "CSV Export";
            this.btn_CsvExport.UseVisualStyleBackColor = true;
            this.btn_CsvExport.Click += new System.EventHandler(this.Btn_CsvExport_Click);
            // 
            // tb_Balance
            // 
            this.tb_Balance.Location = new System.Drawing.Point(117, 46);
            this.tb_Balance.Name = "tb_Balance";
            this.tb_Balance.Size = new System.Drawing.Size(100, 22);
            this.tb_Balance.TabIndex = 18;
            // 
            // tb_Owner
            // 
            this.tb_Owner.Location = new System.Drawing.Point(117, 20);
            this.tb_Owner.Name = "tb_Owner";
            this.tb_Owner.Size = new System.Drawing.Size(100, 22);
            this.tb_Owner.TabIndex = 17;
            // 
            // btn_CreateAccount
            // 
            this.btn_CreateAccount.Location = new System.Drawing.Point(9, 111);
            this.btn_CreateAccount.Name = "btn_CreateAccount";
            this.btn_CreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateAccount.TabIndex = 16;
            this.btn_CreateAccount.Text = "Erstellen";
            this.btn_CreateAccount.UseVisualStyleBackColor = true;
            this.btn_CreateAccount.Click += new System.EventHandler(this.Btn_CreateAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kontostand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inhaber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_CsvImport);
            this.Controls.Add(this.lblDateDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CsvExport);
            this.Controls.Add(this.tb_Balance);
            this.Controls.Add(this.tb_Owner);
            this.Controls.Add(this.btn_CreateAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kontoanwendung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_CsvImport;
        private System.Windows.Forms.Label lblDateDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CsvExport;
        private System.Windows.Forms.TextBox tb_Balance;
        private System.Windows.Forms.TextBox tb_Owner;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accountsDataSetBindingSource;
        private System.Windows.Forms.BindingSource accountsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource accountDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}

