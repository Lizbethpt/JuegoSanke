
namespace JuegoSanke
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblpuntajealto = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIniciar.Location = new System.Drawing.Point(642, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 47);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.StartGame);
            // 
            // btnAjuste
            // 
            this.btnAjuste.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAjuste.Location = new System.Drawing.Point(642, 81);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(94, 47);
            this.btnAjuste.TabIndex = 1;
            this.btnAjuste.Text = "Ajuste";
            this.btnAjuste.UseVisualStyleBackColor = false;
            this.btnAjuste.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picCanvas.Location = new System.Drawing.Point(22, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(617, 169);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(119, 25);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "Puntaje: 0";
            this.lblPuntaje.Click += new System.EventHandler(this.lblPuntaje_Click);
            // 
            // lblpuntajealto
            // 
            this.lblpuntajealto.AutoSize = true;
            this.lblpuntajealto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntajealto.Location = new System.Drawing.Point(608, 205);
            this.lblpuntajealto.Name = "lblpuntajealto";
            this.lblpuntajealto.Size = new System.Drawing.Size(143, 20);
            this.lblpuntajealto.TabIndex = 3;
            this.lblpuntajealto.Text = "Puntaje mas alto";
            this.lblpuntajealto.Click += new System.EventHandler(this.lblPuntaje_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 40;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.lblpuntajealto);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblpuntajealto;
        private System.Windows.Forms.Timer GameTimer;
    }
}

