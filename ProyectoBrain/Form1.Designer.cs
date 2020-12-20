namespace ProyectoBrain
{
    partial class FormBrain
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
            this.components = new System.ComponentModel.Container();
            this.labPuntuacion = new System.Windows.Forms.Label();
            this.labTiempo = new System.Windows.Forms.Label();
            this.labOperand1 = new System.Windows.Forms.Label();
            this.labOperator = new System.Windows.Forms.Label();
            this.labOperand2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nivelNum = new System.Windows.Forms.NumericUpDown();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nivelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // labPuntuacion
            // 
            this.labPuntuacion.BackColor = System.Drawing.Color.FloralWhite;
            this.labPuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPuntuacion.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPuntuacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labPuntuacion.Location = new System.Drawing.Point(12, 9);
            this.labPuntuacion.Name = "labPuntuacion";
            this.labPuntuacion.Size = new System.Drawing.Size(75, 75);
            this.labPuntuacion.TabIndex = 0;
            this.labPuntuacion.Text = "0";
            this.labPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTiempo
            // 
            this.labTiempo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTiempo.Location = new System.Drawing.Point(201, 9);
            this.labTiempo.Name = "labTiempo";
            this.labTiempo.Size = new System.Drawing.Size(50, 50);
            this.labTiempo.TabIndex = 1;
            this.labTiempo.Text = "0";
            this.labTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOperand1
            // 
            this.labOperand1.BackColor = System.Drawing.Color.Moccasin;
            this.labOperand1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOperand1.Location = new System.Drawing.Point(42, 102);
            this.labOperand1.Name = "labOperand1";
            this.labOperand1.Size = new System.Drawing.Size(50, 50);
            this.labOperand1.TabIndex = 2;
            this.labOperand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOperator
            // 
            this.labOperator.BackColor = System.Drawing.Color.Moccasin;
            this.labOperator.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOperator.Location = new System.Drawing.Point(110, 102);
            this.labOperator.Name = "labOperator";
            this.labOperator.Size = new System.Drawing.Size(50, 50);
            this.labOperator.TabIndex = 3;
            this.labOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labOperand2
            // 
            this.labOperand2.BackColor = System.Drawing.Color.Moccasin;
            this.labOperand2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOperand2.Location = new System.Drawing.Point(177, 102);
            this.labOperand2.Name = "labOperand2";
            this.labOperand2.Size = new System.Drawing.Size(50, 50);
            this.labOperand2.TabIndex = 4;
            this.labOperand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(42, 171);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(187, 38);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbResult_KeyPress);
            this.tbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbResult_KeyUp);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nivelNum
            // 
            this.nivelNum.Location = new System.Drawing.Point(128, 12);
            this.nivelNum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nivelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nivelNum.Name = "nivelNum";
            this.nivelNum.ReadOnly = true;
            this.nivelNum.Size = new System.Drawing.Size(43, 20);
            this.nivelNum.TabIndex = 6;
            this.nivelNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nivelNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormBrain_KeyUp);
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(42, 225);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(187, 38);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(398, 247);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 8;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // dgvRanking
            // 
            this.dgvRanking.AllowUserToAddRows = false;
            this.dgvRanking.AllowUserToDeleteRows = false;
            this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRanking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Location = new System.Drawing.Point(257, 9);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.Size = new System.Drawing.Size(364, 225);
            this.dgvRanking.TabIndex = 9;
            // 
            // FormBrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 282);
            this.Controls.Add(this.dgvRanking);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.nivelNum);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.labOperand2);
            this.Controls.Add(this.labOperator);
            this.Controls.Add(this.labOperand1);
            this.Controls.Add(this.labTiempo);
            this.Controls.Add(this.labPuntuacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBrain";
            this.Text = "Brain Training";
            this.Load += new System.EventHandler(this.FormBrain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormBrain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nivelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPuntuacion;
        private System.Windows.Forms.Label labTiempo;
        private System.Windows.Forms.Label labOperand1;
        private System.Windows.Forms.Label labOperator;
        private System.Windows.Forms.Label labOperand2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown nivelNum;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.DataGridView dgvRanking;
    }
}

