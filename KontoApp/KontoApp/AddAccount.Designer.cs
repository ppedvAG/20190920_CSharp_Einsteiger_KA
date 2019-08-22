namespace KontoApp
{
    partial class AddAccount
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
            this.btn_AddAccountSave = new System.Windows.Forms.Button();
            this.btn_AddAccountCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddAccountSave
            // 
            this.btn_AddAccountSave.Location = new System.Drawing.Point(199, 395);
            this.btn_AddAccountSave.Name = "btn_AddAccountSave";
            this.btn_AddAccountSave.Size = new System.Drawing.Size(87, 23);
            this.btn_AddAccountSave.TabIndex = 0;
            this.btn_AddAccountSave.Text = "Speichern";
            this.btn_AddAccountSave.UseVisualStyleBackColor = true;
            this.btn_AddAccountSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_AddAccountCancel
            // 
            this.btn_AddAccountCancel.Location = new System.Drawing.Point(377, 395);
            this.btn_AddAccountCancel.Name = "btn_AddAccountCancel";
            this.btn_AddAccountCancel.Size = new System.Drawing.Size(89, 23);
            this.btn_AddAccountCancel.TabIndex = 1;
            this.btn_AddAccountCancel.Text = "Abbrechen";
            this.btn_AddAccountCancel.UseVisualStyleBackColor = true;
            this.btn_AddAccountCancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddAccountCancel);
            this.Controls.Add(this.btn_AddAccountSave);
            this.Name = "AddAccount";
            this.Text = "Konto hinzufügen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddAccountSave;
        private System.Windows.Forms.Button btn_AddAccountCancel;
        private System.Windows.Forms.Label label1;
    }
}