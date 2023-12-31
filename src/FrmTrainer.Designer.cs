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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrainer));
            this.BtnAttach = new System.Windows.Forms.Button();
            this.BtnDettach = new System.Windows.Forms.Button();
            this.GrpParameters = new System.Windows.Forms.GroupBox();
            this.CbStartWithResonantArmorSet = new System.Windows.Forms.CheckBox();
            this.CbJumpPoints = new System.Windows.Forms.CheckBox();
            this.CbSpeedPoints = new System.Windows.Forms.CheckBox();
            this.CbPowerPoints = new System.Windows.Forms.CheckBox();
            this.CbAttackPoints = new System.Windows.Forms.CheckBox();
            this.CbMaxEn = new System.Windows.Forms.CheckBox();
            this.CbMaxHp = new System.Windows.Forms.CheckBox();
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
            this.GrpParameters.Controls.Add(this.CbStartWithResonantArmorSet);
            this.GrpParameters.Controls.Add(this.CbJumpPoints);
            this.GrpParameters.Controls.Add(this.CbSpeedPoints);
            this.GrpParameters.Controls.Add(this.CbPowerPoints);
            this.GrpParameters.Controls.Add(this.CbAttackPoints);
            this.GrpParameters.Controls.Add(this.CbMaxEn);
            this.GrpParameters.Controls.Add(this.CbMaxHp);
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
            // CbStartWithResonantArmorSet
            // 
            this.CbStartWithResonantArmorSet.AutoSize = true;
            this.CbStartWithResonantArmorSet.Location = new System.Drawing.Point(259, 19);
            this.CbStartWithResonantArmorSet.Name = "CbStartWithResonantArmorSet";
            this.CbStartWithResonantArmorSet.Size = new System.Drawing.Size(168, 17);
            this.CbStartWithResonantArmorSet.TabIndex = 26;
            this.CbStartWithResonantArmorSet.Text = "Start with Resonant Armor Set";
            this.CbStartWithResonantArmorSet.UseVisualStyleBackColor = true;
            // 
            // CbJumpPoints
            // 
            this.CbJumpPoints.AutoSize = true;
            this.CbJumpPoints.Location = new System.Drawing.Point(131, 134);
            this.CbJumpPoints.Name = "CbJumpPoints";
            this.CbJumpPoints.Size = new System.Drawing.Size(106, 17);
            this.CbJumpPoints.TabIndex = 25;
            this.CbJumpPoints.Text = "Max Jump Points";
            this.CbJumpPoints.UseVisualStyleBackColor = true;
            // 
            // CbSpeedPoints
            // 
            this.CbSpeedPoints.AutoSize = true;
            this.CbSpeedPoints.Location = new System.Drawing.Point(131, 111);
            this.CbSpeedPoints.Name = "CbSpeedPoints";
            this.CbSpeedPoints.Size = new System.Drawing.Size(112, 17);
            this.CbSpeedPoints.TabIndex = 24;
            this.CbSpeedPoints.Text = "Max Speed Points";
            this.CbSpeedPoints.UseVisualStyleBackColor = true;
            // 
            // CbPowerPoints
            // 
            this.CbPowerPoints.AutoSize = true;
            this.CbPowerPoints.Location = new System.Drawing.Point(131, 88);
            this.CbPowerPoints.Name = "CbPowerPoints";
            this.CbPowerPoints.Size = new System.Drawing.Size(111, 17);
            this.CbPowerPoints.TabIndex = 23;
            this.CbPowerPoints.Text = "Max Power Points";
            this.CbPowerPoints.UseVisualStyleBackColor = true;
            // 
            // CbAttackPoints
            // 
            this.CbAttackPoints.AutoSize = true;
            this.CbAttackPoints.Location = new System.Drawing.Point(131, 65);
            this.CbAttackPoints.Name = "CbAttackPoints";
            this.CbAttackPoints.Size = new System.Drawing.Size(112, 17);
            this.CbAttackPoints.TabIndex = 22;
            this.CbAttackPoints.Text = "Max Attack Points";
            this.CbAttackPoints.UseVisualStyleBackColor = true;
            // 
            // CbMaxEn
            // 
            this.CbMaxEn.AutoSize = true;
            this.CbMaxEn.Location = new System.Drawing.Point(131, 42);
            this.CbMaxEn.Name = "CbMaxEn";
            this.CbMaxEn.Size = new System.Drawing.Size(64, 17);
            this.CbMaxEn.TabIndex = 21;
            this.CbMaxEn.Text = "Max EN";
            this.CbMaxEn.UseVisualStyleBackColor = true;
            // 
            // CbMaxHp
            // 
            this.CbMaxHp.AutoSize = true;
            this.CbMaxHp.Location = new System.Drawing.Point(131, 19);
            this.CbMaxHp.Name = "CbMaxHp";
            this.CbMaxHp.Size = new System.Drawing.Size(64, 17);
            this.CbMaxHp.TabIndex = 20;
            this.CbMaxHp.Text = "Max HP";
            this.CbMaxHp.UseVisualStyleBackColor = true;
            // 
            // CbCores
            // 
            this.CbCores.AutoSize = true;
            this.CbCores.Location = new System.Drawing.Point(131, 157);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.CheckBox CbMaxHp;
        private System.Windows.Forms.CheckBox CbMaxEn;
        private System.Windows.Forms.CheckBox CbJumpPoints;
        private System.Windows.Forms.CheckBox CbSpeedPoints;
        private System.Windows.Forms.CheckBox CbPowerPoints;
        private System.Windows.Forms.CheckBox CbAttackPoints;
        private System.Windows.Forms.CheckBox CbStartWithResonantArmorSet;
    }
}

