﻿namespace CapaDiseno
{
    partial class Frm_Main
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
            this.Btn_Configuracion = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_RptApp = new System.Windows.Forms.Button();
            this.Btn_RptMdl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.Location = new System.Drawing.Point(12, 12);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Size = new System.Drawing.Size(145, 57);
            this.Btn_Configuracion.TabIndex = 0;
            this.Btn_Configuracion.Text = "Configuracion Carpeta";
            this.Btn_Configuracion.UseVisualStyleBackColor = true;
            this.Btn_Configuracion.Click += new System.EventHandler(this.Btn_Configuracion_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Location = new System.Drawing.Point(12, 75);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(145, 57);
            this.Btn_Reporte.TabIndex = 1;
            this.Btn_Reporte.Text = "Reportes";
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_RptApp
            // 
            this.Btn_RptApp.Location = new System.Drawing.Point(12, 138);
            this.Btn_RptApp.Name = "Btn_RptApp";
            this.Btn_RptApp.Size = new System.Drawing.Size(145, 57);
            this.Btn_RptApp.TabIndex = 2;
            this.Btn_RptApp.Text = "Asociar a Aplicacoin";
            this.Btn_RptApp.UseVisualStyleBackColor = true;
            this.Btn_RptApp.Click += new System.EventHandler(this.Btn_RptApp_Click);
            // 
            // Btn_RptMdl
            // 
            this.Btn_RptMdl.Location = new System.Drawing.Point(12, 201);
            this.Btn_RptMdl.Name = "Btn_RptMdl";
            this.Btn_RptMdl.Size = new System.Drawing.Size(145, 57);
            this.Btn_RptMdl.TabIndex = 3;
            this.Btn_RptMdl.Text = "Asociar a Modulo";
            this.Btn_RptMdl.UseVisualStyleBackColor = true;
            this.Btn_RptMdl.Click += new System.EventHandler(this.Btn_RptMdl_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 267);
            this.Controls.Add(this.Btn_RptMdl);
            this.Controls.Add(this.Btn_RptApp);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Configuracion);
            this.Name = "Frm_Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Configuracion;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_RptApp;
        private System.Windows.Forms.Button Btn_RptMdl;
    }
}