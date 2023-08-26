﻿namespace _30XX_Trainer
{
    partial class FrmTrainer
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
            this.BtnAttach = new System.Windows.Forms.Button();
            this.BtnDettach = new System.Windows.Forms.Button();
            this.GrpParameters = new System.Windows.Forms.GroupBox();
            this.BtnMaxMemoria = new System.Windows.Forms.Button();
            this.NumMemoria = new System.Windows.Forms.NumericUpDown();
            this.LblMemoria = new System.Windows.Forms.Label();
            this.BtnTitanShards = new System.Windows.Forms.Button();
            this.NumTitanShards = new System.Windows.Forms.NumericUpDown();
            this.LblTitanShards = new System.Windows.Forms.Label();
            this.GrpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTitanShards)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAttach
            // 
            this.BtnAttach.Location = new System.Drawing.Point(12, 12);
            this.BtnAttach.Name = "BtnAttach";
            this.BtnAttach.Size = new System.Drawing.Size(135, 23);
            this.BtnAttach.TabIndex = 0;
            this.BtnAttach.Text = "Attach game process";
            this.BtnAttach.UseVisualStyleBackColor = true;
            this.BtnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // BtnDettach
            // 
            this.BtnDettach.Enabled = false;
            this.BtnDettach.Location = new System.Drawing.Point(153, 12);
            this.BtnDettach.Name = "BtnDettach";
            this.BtnDettach.Size = new System.Drawing.Size(135, 23);
            this.BtnDettach.TabIndex = 1;
            this.BtnDettach.Text = "Dettach game process";
            this.BtnDettach.UseVisualStyleBackColor = true;
            this.BtnDettach.Click += new System.EventHandler(this.BtnDettach_Click);
            // 
            // GrpParameters
            // 
            this.GrpParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpParameters.Controls.Add(this.BtnTitanShards);
            this.GrpParameters.Controls.Add(this.NumTitanShards);
            this.GrpParameters.Controls.Add(this.LblTitanShards);
            this.GrpParameters.Controls.Add(this.BtnMaxMemoria);
            this.GrpParameters.Controls.Add(this.NumMemoria);
            this.GrpParameters.Controls.Add(this.LblMemoria);
            this.GrpParameters.Enabled = false;
            this.GrpParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpParameters.Location = new System.Drawing.Point(12, 41);
            this.GrpParameters.Name = "GrpParameters";
            this.GrpParameters.Size = new System.Drawing.Size(510, 258);
            this.GrpParameters.TabIndex = 2;
            this.GrpParameters.TabStop = false;
            this.GrpParameters.Text = "Parameters";
            // 
            // BtnMaxMemoria
            // 
            this.BtnMaxMemoria.Location = new System.Drawing.Point(208, 17);
            this.BtnMaxMemoria.Name = "BtnMaxMemoria";
            this.BtnMaxMemoria.Size = new System.Drawing.Size(40, 23);
            this.BtnMaxMemoria.TabIndex = 2;
            this.BtnMaxMemoria.Text = "Max";
            this.BtnMaxMemoria.UseVisualStyleBackColor = true;
            this.BtnMaxMemoria.Click += new System.EventHandler(this.BtnMaxMemoria_Click);
            // 
            // NumMemoria
            // 
            this.NumMemoria.Location = new System.Drawing.Point(82, 19);
            this.NumMemoria.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumMemoria.Name = "NumMemoria";
            this.NumMemoria.Size = new System.Drawing.Size(120, 20);
            this.NumMemoria.TabIndex = 1;
            this.NumMemoria.ValueChanged += new System.EventHandler(this.NumMemoria_ValueChanged);
            // 
            // LblMemoria
            // 
            this.LblMemoria.AutoSize = true;
            this.LblMemoria.Location = new System.Drawing.Point(6, 21);
            this.LblMemoria.Name = "LblMemoria";
            this.LblMemoria.Size = new System.Drawing.Size(50, 13);
            this.LblMemoria.TabIndex = 0;
            this.LblMemoria.Text = "Memoria:";
            // 
            // BtnTitanShards
            // 
            this.BtnTitanShards.Location = new System.Drawing.Point(208, 43);
            this.BtnTitanShards.Name = "BtnTitanShards";
            this.BtnTitanShards.Size = new System.Drawing.Size(40, 23);
            this.BtnTitanShards.TabIndex = 5;
            this.BtnTitanShards.Text = "Max";
            this.BtnTitanShards.UseVisualStyleBackColor = true;
            this.BtnTitanShards.Click += new System.EventHandler(this.BtnTitanShards_Click);
            // 
            // NumTitanShards
            // 
            this.NumTitanShards.Location = new System.Drawing.Point(82, 45);
            this.NumTitanShards.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumTitanShards.Name = "NumTitanShards";
            this.NumTitanShards.Size = new System.Drawing.Size(120, 20);
            this.NumTitanShards.TabIndex = 4;
            this.NumTitanShards.ValueChanged += new System.EventHandler(this.NumTitanShards_ValueChanged);
            // 
            // LblTitanShards
            // 
            this.LblTitanShards.AutoSize = true;
            this.LblTitanShards.Location = new System.Drawing.Point(6, 47);
            this.LblTitanShards.Name = "LblTitanShards";
            this.LblTitanShards.Size = new System.Drawing.Size(70, 13);
            this.LblTitanShards.TabIndex = 3;
            this.LblTitanShards.Text = "Titan Shards:";
            // 
            // FrmTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.GrpParameters);
            this.Controls.Add(this.BtnDettach);
            this.Controls.Add(this.BtnAttach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "30XX Trainer - v1.00.15";
            this.GrpParameters.ResumeLayout(false);
            this.GrpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTitanShards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.Button BtnDettach;
        private System.Windows.Forms.GroupBox GrpParameters;
        private System.Windows.Forms.Button BtnMaxMemoria;
        private System.Windows.Forms.NumericUpDown NumMemoria;
        private System.Windows.Forms.Label LblMemoria;
        private System.Windows.Forms.Button BtnTitanShards;
        private System.Windows.Forms.NumericUpDown NumTitanShards;
        private System.Windows.Forms.Label LblTitanShards;
    }
}

