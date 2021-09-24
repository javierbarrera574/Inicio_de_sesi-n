
namespace Inicio_de_sesión
{
    partial class frmEntrar
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.ForeColor = System.Drawing.Color.Red;
            this.lblmensaje.Location = new System.Drawing.Point(196, 142);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(73, 31);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "hgfff";
            this.lblmensaje.Visible = false;
            this.lblmensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // btMensaje
            // 
            this.btMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMensaje.Location = new System.Drawing.Point(270, 272);
            this.btMensaje.Name = "btMensaje";
            this.btMensaje.Size = new System.Drawing.Size(187, 54);
            this.btMensaje.TabIndex = 1;
            this.btMensaje.Text = "Ver mensaje";
            this.btMensaje.UseVisualStyleBackColor = true;
            this.btMensaje.Click += new System.EventHandler(this.btMensaje_Click);
            // 
            // frmEntrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMensaje);
            this.Controls.Add(this.lblmensaje);
            this.Name = "frmEntrar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btMensaje;
    }
}