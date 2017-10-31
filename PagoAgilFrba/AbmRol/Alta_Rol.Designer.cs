namespace PagoAgilFrba.AbmRol
{
    partial class Alta_Rol
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
            this.funcionalidadesDGV = new System.Windows.Forms.DataGridView();
            this.Activado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rolNameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionalidadesDGV
            // 
            this.funcionalidadesDGV.AllowUserToAddRows = false;
            this.funcionalidadesDGV.AllowUserToDeleteRows = false;
            this.funcionalidadesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionalidadesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activado,
            this.Nombre,
            this.Id});
            this.funcionalidadesDGV.Location = new System.Drawing.Point(42, 86);
            this.funcionalidadesDGV.Name = "funcionalidadesDGV";
            this.funcionalidadesDGV.Size = new System.Drawing.Size(387, 150);
            this.funcionalidadesDGV.TabIndex = 9;
            // 
            // Activado
            // 
            this.Activado.DataPropertyName = "activado";
            this.Activado.HeaderText = "Activado";
            this.Activado.Name = "Activado";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el nombre del rol";
            // 
            // rolNameTextBox
            // 
            this.rolNameTextBox.Location = new System.Drawing.Point(25, 35);
            this.rolNameTextBox.Name = "rolNameTextBox";
            this.rolNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.rolNameTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Alta_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 291);
            this.Controls.Add(this.funcionalidadesDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolNameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Alta_Rol";
            this.Text = "Alta_Rol";
            this.Load += new System.EventHandler(this.Alta_Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView funcionalidadesDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rolNameTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}