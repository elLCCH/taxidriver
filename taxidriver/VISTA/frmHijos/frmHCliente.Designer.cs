namespace taxidriver.VISTA.frmHijos
{
    partial class frmHCliente
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
            this.btnResgistrarServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(348, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Size = new System.Drawing.Size(487, 46);
            this.label1.Text = "GESTION DE CLIENTES";
            // 
            // btnResgistrarServicio
            // 
            this.btnResgistrarServicio.Location = new System.Drawing.Point(807, 608);
            this.btnResgistrarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResgistrarServicio.Name = "btnResgistrarServicio";
            this.btnResgistrarServicio.Size = new System.Drawing.Size(175, 52);
            this.btnResgistrarServicio.TabIndex = 16;
            this.btnResgistrarServicio.Text = "REGISTRAR SERVICIO";
            this.btnResgistrarServicio.UseVisualStyleBackColor = true;
            this.btnResgistrarServicio.Click += new System.EventHandler(this.btnResgitrarServicio_Click);
            // 
            // frmHCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 738);
            this.Controls.Add(this.btnResgistrarServicio);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "frmHCliente";
            this.Text = "frmHCliente";
            this.Controls.SetChildIndex(this.pbxImagenBusqueda, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.btnResgistrarServicio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResgistrarServicio;
    }
}