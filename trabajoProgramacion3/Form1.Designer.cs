
namespace trabajoProgramacion3
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMillasKm = new System.Windows.Forms.Button();
            this.btnKmMillas = new System.Windows.Forms.Button();
            this.numberCalc = new System.Windows.Forms.NumericUpDown();
            this.lblConsultasMaK = new System.Windows.Forms.Label();
            this.lblContadorMaK = new System.Windows.Forms.Label();
            this.lblContadorKaM = new System.Windows.Forms.Label();
            this.lblConsultasKaM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(121, 30);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(585, 42);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¡Hola! Ingrese el número que quiere calcular";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(194, 215);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(432, 38);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Porfavor, ingrese un número";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(247, 276);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(164, 31);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "El resultado es:";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // btnMillasKm
            // 
            this.btnMillasKm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMillasKm.Location = new System.Drawing.Point(128, 153);
            this.btnMillasKm.Name = "btnMillasKm";
            this.btnMillasKm.Size = new System.Drawing.Size(205, 42);
            this.btnMillasKm.TabIndex = 5;
            this.btnMillasKm.Text = "Millas a Kilometros";
            this.btnMillasKm.UseVisualStyleBackColor = true;
            this.btnMillasKm.Click += new System.EventHandler(this.btnMillasKm_Click);
            // 
            // btnKmMillas
            // 
            this.btnKmMillas.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKmMillas.Location = new System.Drawing.Point(453, 153);
            this.btnKmMillas.Name = "btnKmMillas";
            this.btnKmMillas.Size = new System.Drawing.Size(253, 42);
            this.btnKmMillas.TabIndex = 6;
            this.btnKmMillas.Text = "Kilometros a Millas";
            this.btnKmMillas.UseVisualStyleBackColor = true;
            this.btnKmMillas.Click += new System.EventHandler(this.btnKmMillas_Click);
            // 
            // numberCalc
            // 
            this.numberCalc.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCalc.Location = new System.Drawing.Point(335, 92);
            this.numberCalc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numberCalc.Name = "numberCalc";
            this.numberCalc.Size = new System.Drawing.Size(120, 38);
            this.numberCalc.TabIndex = 10;
            this.numberCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConsultasMaK
            // 
            this.lblConsultasMaK.AutoSize = true;
            this.lblConsultasMaK.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultasMaK.Location = new System.Drawing.Point(176, 322);
            this.lblConsultasMaK.Name = "lblConsultasMaK";
            this.lblConsultasMaK.Size = new System.Drawing.Size(450, 31);
            this.lblConsultasMaK.TabIndex = 11;
            this.lblConsultasMaK.Text = "Cantidad de consultas de millas a kilometros:";
            this.lblConsultasMaK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConsultasMaK.Visible = false;
            // 
            // lblContadorMaK
            // 
            this.lblContadorMaK.AutoSize = true;
            this.lblContadorMaK.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorMaK.Location = new System.Drawing.Point(632, 322);
            this.lblContadorMaK.Name = "lblContadorMaK";
            this.lblContadorMaK.Size = new System.Drawing.Size(0, 31);
            this.lblContadorMaK.TabIndex = 12;
            this.lblContadorMaK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContadorMaK.Visible = false;
            // 
            // lblContadorKaM
            // 
            this.lblContadorKaM.AutoSize = true;
            this.lblContadorKaM.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorKaM.Location = new System.Drawing.Point(632, 354);
            this.lblContadorKaM.Name = "lblContadorKaM";
            this.lblContadorKaM.Size = new System.Drawing.Size(0, 31);
            this.lblContadorKaM.TabIndex = 13;
            this.lblContadorKaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContadorKaM.Visible = false;
            // 
            // lblConsultasKaM
            // 
            this.lblConsultasKaM.AutoSize = true;
            this.lblConsultasKaM.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultasKaM.Location = new System.Drawing.Point(176, 353);
            this.lblConsultasKaM.Name = "lblConsultasKaM";
            this.lblConsultasKaM.Size = new System.Drawing.Size(450, 31);
            this.lblConsultasKaM.TabIndex = 14;
            this.lblConsultasKaM.Text = "Cantidad de consultas de kilometros a millas:";
            this.lblConsultasKaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConsultasKaM.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConsultasKaM);
            this.Controls.Add(this.lblContadorKaM);
            this.Controls.Add(this.lblContadorMaK);
            this.Controls.Add(this.lblConsultasMaK);
            this.Controls.Add(this.numberCalc);
            this.Controls.Add(this.btnKmMillas);
            this.Controls.Add(this.btnMillasKm);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMillasKm;
        private System.Windows.Forms.Button btnKmMillas;
        private System.Windows.Forms.NumericUpDown numberCalc;
        private System.Windows.Forms.Label lblConsultasMaK;
        private System.Windows.Forms.Label lblContadorMaK;
        private System.Windows.Forms.Label lblContadorKaM;
        private System.Windows.Forms.Label lblConsultasKaM;
    }
}

