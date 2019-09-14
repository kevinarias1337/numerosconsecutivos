namespace numerosconsecutivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.limitetxt = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.DataGridView();
            this.continuar = new System.Windows.Forms.Button();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el número limite:";
            // 
            // limitetxt
            // 
            this.limitetxt.Location = new System.Drawing.Point(221, 23);
            this.limitetxt.Name = "limitetxt";
            this.limitetxt.Size = new System.Drawing.Size(31, 20);
            this.limitetxt.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.BackgroundColor = System.Drawing.SystemColors.Control;
            this.numero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2});
            this.numero.Location = new System.Drawing.Point(275, 12);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(184, 229);
            this.numero.TabIndex = 2;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(177, 49);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(75, 23);
            this.continuar.TabIndex = 3;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Número";
            this.columna1.Name = "columna1";
            this.columna1.Width = 70;
            // 
            // columna2
            // 
            this.columna2.HeaderText = "Número limite";
            this.columna2.Name = "columna2";
            this.columna2.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 253);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.limitetxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Números consecutivos determinados por el usuario.";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox limitetxt;
        private System.Windows.Forms.DataGridView numero;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
    }
}

