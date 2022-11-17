namespace WindowsAppPubs
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
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.txtIdToDelete = new System.Windows.Forms.TextBox();
            this.txtIdToUpdate = new System.Windows.Forms.TextBox();
            this.txtIdToInsert = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(455, 41);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(201, 56);
            this.btnTraerTodos.TabIndex = 1;
            this.btnTraerTodos.Text = "Traer todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(662, 41);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(201, 56);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(869, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 56);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1076, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 56);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(60, 131);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 72;
            this.dataGrid1.RowTemplate.Height = 31;
            this.dataGrid1.Size = new System.Drawing.Size(1612, 591);
            this.dataGrid1.TabIndex = 5;
            // 
            // txtIdToDelete
            // 
            this.txtIdToDelete.Location = new System.Drawing.Point(1076, 6);
            this.txtIdToDelete.Name = "txtIdToDelete";
            this.txtIdToDelete.Size = new System.Drawing.Size(201, 29);
            this.txtIdToDelete.TabIndex = 6;
            // 
            // txtIdToUpdate
            // 
            this.txtIdToUpdate.Location = new System.Drawing.Point(869, 6);
            this.txtIdToUpdate.Name = "txtIdToUpdate";
            this.txtIdToUpdate.Size = new System.Drawing.Size(201, 29);
            this.txtIdToUpdate.TabIndex = 7;
            // 
            // txtIdToInsert
            // 
            this.txtIdToInsert.Location = new System.Drawing.Point(662, 6);
            this.txtIdToInsert.Name = "txtIdToInsert";
            this.txtIdToInsert.Size = new System.Drawing.Size(201, 29);
            this.txtIdToInsert.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1733, 779);
            this.Controls.Add(this.txtIdToInsert);
            this.Controls.Add(this.txtIdToUpdate);
            this.Controls.Add(this.txtIdToDelete);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnTraerTodos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.TextBox txtIdToDelete;
        private System.Windows.Forms.TextBox txtIdToUpdate;
        private System.Windows.Forms.TextBox txtIdToInsert;
    }
}

