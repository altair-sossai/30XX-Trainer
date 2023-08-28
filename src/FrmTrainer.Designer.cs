namespace _30XX_Trainer
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
            this.CbCores = new System.Windows.Forms.CheckBox();
            this.CbCubes = new System.Windows.Forms.CheckBox();
            this.CbNuts = new System.Windows.Forms.CheckBox();
            this.CbTitanShards = new System.Windows.Forms.CheckBox();
            this.CbMemoria = new System.Windows.Forms.CheckBox();
            this.GrpParameters.SuspendLayout();
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
            this.GrpParameters.Controls.Add(this.CbCores);
            this.GrpParameters.Controls.Add(this.CbCubes);
            this.GrpParameters.Controls.Add(this.CbNuts);
            this.GrpParameters.Controls.Add(this.CbTitanShards);
            this.GrpParameters.Controls.Add(this.CbMemoria);
            this.GrpParameters.Enabled = false;
            this.GrpParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpParameters.Location = new System.Drawing.Point(12, 41);
            this.GrpParameters.Name = "GrpParameters";
            this.GrpParameters.Size = new System.Drawing.Size(510, 258);
            this.GrpParameters.TabIndex = 2;
            this.GrpParameters.TabStop = false;
            this.GrpParameters.Text = "Parameters";
            // 
            // CbCores
            // 
            this.CbCores.AutoSize = true;
            this.CbCores.Location = new System.Drawing.Point(9, 111);
            this.CbCores.Name = "CbCores";
            this.CbCores.Size = new System.Drawing.Size(76, 17);
            this.CbCores.TabIndex = 19;
            this.CbCores.Text = "Max Cores";
            this.CbCores.UseVisualStyleBackColor = true;
            // 
            // CbCubes
            // 
            this.CbCubes.AutoSize = true;
            this.CbCubes.Location = new System.Drawing.Point(9, 88);
            this.CbCubes.Name = "CbCubes";
            this.CbCubes.Size = new System.Drawing.Size(79, 17);
            this.CbCubes.TabIndex = 18;
            this.CbCubes.Text = "Max Cubes";
            this.CbCubes.UseVisualStyleBackColor = true;
            // 
            // CbNuts
            // 
            this.CbNuts.AutoSize = true;
            this.CbNuts.Location = new System.Drawing.Point(9, 65);
            this.CbNuts.Name = "CbNuts";
            this.CbNuts.Size = new System.Drawing.Size(71, 17);
            this.CbNuts.TabIndex = 17;
            this.CbNuts.Text = "Max Nuts";
            this.CbNuts.UseVisualStyleBackColor = true;
            // 
            // CbTitanShards
            // 
            this.CbTitanShards.AutoSize = true;
            this.CbTitanShards.Location = new System.Drawing.Point(9, 42);
            this.CbTitanShards.Name = "CbTitanShards";
            this.CbTitanShards.Size = new System.Drawing.Size(109, 17);
            this.CbTitanShards.TabIndex = 16;
            this.CbTitanShards.Text = "Max Titan Shards";
            this.CbTitanShards.UseVisualStyleBackColor = true;
            // 
            // CbMemoria
            // 
            this.CbMemoria.AutoSize = true;
            this.CbMemoria.Location = new System.Drawing.Point(9, 19);
            this.CbMemoria.Name = "CbMemoria";
            this.CbMemoria.Size = new System.Drawing.Size(89, 17);
            this.CbMemoria.TabIndex = 15;
            this.CbMemoria.Text = "Max Memoria";
            this.CbMemoria.UseVisualStyleBackColor = true;
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
            this.Text = "30XX Trainer";
            this.Load += new System.EventHandler(this.FrmTrainer_Load);
            this.GrpParameters.ResumeLayout(false);
            this.GrpParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.Button BtnDettach;
        private System.Windows.Forms.GroupBox GrpParameters;
        private System.Windows.Forms.CheckBox CbCores;
        private System.Windows.Forms.CheckBox CbCubes;
        private System.Windows.Forms.CheckBox CbNuts;
        private System.Windows.Forms.CheckBox CbTitanShards;
        private System.Windows.Forms.CheckBox CbMemoria;
    }
}

