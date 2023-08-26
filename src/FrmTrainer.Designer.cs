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
            this.BtnMaxNuts = new System.Windows.Forms.Button();
            this.NumNuts = new System.Windows.Forms.NumericUpDown();
            this.LblNuts = new System.Windows.Forms.Label();
            this.BtnMaxTitanShards = new System.Windows.Forms.Button();
            this.NumTitanShards = new System.Windows.Forms.NumericUpDown();
            this.LblTitanShards = new System.Windows.Forms.Label();
            this.BtnMaxMemoria = new System.Windows.Forms.Button();
            this.NumMemoria = new System.Windows.Forms.NumericUpDown();
            this.LblMemoria = new System.Windows.Forms.Label();
            this.BtnReloadParameters = new System.Windows.Forms.Button();
            this.BtnMaxCubes = new System.Windows.Forms.Button();
            this.NumCubes = new System.Windows.Forms.NumericUpDown();
            this.LblCubes = new System.Windows.Forms.Label();
            this.GrpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumNuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTitanShards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCubes)).BeginInit();
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
            this.GrpParameters.Controls.Add(this.BtnMaxCubes);
            this.GrpParameters.Controls.Add(this.NumCubes);
            this.GrpParameters.Controls.Add(this.LblCubes);
            this.GrpParameters.Controls.Add(this.BtnMaxNuts);
            this.GrpParameters.Controls.Add(this.NumNuts);
            this.GrpParameters.Controls.Add(this.LblNuts);
            this.GrpParameters.Controls.Add(this.BtnMaxTitanShards);
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
            // BtnMaxNuts
            // 
            this.BtnMaxNuts.Location = new System.Drawing.Point(208, 69);
            this.BtnMaxNuts.Name = "BtnMaxNuts";
            this.BtnMaxNuts.Size = new System.Drawing.Size(40, 23);
            this.BtnMaxNuts.TabIndex = 8;
            this.BtnMaxNuts.Text = "Max";
            this.BtnMaxNuts.UseVisualStyleBackColor = true;
            this.BtnMaxNuts.Click += new System.EventHandler(this.BtnMaxNuts_Click);
            // 
            // NumNuts
            // 
            this.NumNuts.Location = new System.Drawing.Point(82, 71);
            this.NumNuts.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumNuts.Name = "NumNuts";
            this.NumNuts.Size = new System.Drawing.Size(120, 20);
            this.NumNuts.TabIndex = 7;
            this.NumNuts.ValueChanged += new System.EventHandler(this.NumNuts_ValueChanged);
            // 
            // LblNuts
            // 
            this.LblNuts.AutoSize = true;
            this.LblNuts.Location = new System.Drawing.Point(6, 73);
            this.LblNuts.Name = "LblNuts";
            this.LblNuts.Size = new System.Drawing.Size(32, 13);
            this.LblNuts.TabIndex = 6;
            this.LblNuts.Text = "Nuts:";
            // 
            // BtnMaxTitanShards
            // 
            this.BtnMaxTitanShards.Location = new System.Drawing.Point(208, 43);
            this.BtnMaxTitanShards.Name = "BtnMaxTitanShards";
            this.BtnMaxTitanShards.Size = new System.Drawing.Size(40, 23);
            this.BtnMaxTitanShards.TabIndex = 5;
            this.BtnMaxTitanShards.Text = "Max";
            this.BtnMaxTitanShards.UseVisualStyleBackColor = true;
            this.BtnMaxTitanShards.Click += new System.EventHandler(this.BtnMaxTitanShards_Click);
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
            // BtnReloadParameters
            // 
            this.BtnReloadParameters.Enabled = false;
            this.BtnReloadParameters.Location = new System.Drawing.Point(387, 12);
            this.BtnReloadParameters.Name = "BtnReloadParameters";
            this.BtnReloadParameters.Size = new System.Drawing.Size(135, 23);
            this.BtnReloadParameters.TabIndex = 3;
            this.BtnReloadParameters.Text = "Reload parameters";
            this.BtnReloadParameters.UseVisualStyleBackColor = true;
            this.BtnReloadParameters.Click += new System.EventHandler(this.BtnReloadParameters_Click);
            // 
            // BtnMaxCubes
            // 
            this.BtnMaxCubes.Location = new System.Drawing.Point(208, 95);
            this.BtnMaxCubes.Name = "BtnMaxCubes";
            this.BtnMaxCubes.Size = new System.Drawing.Size(40, 23);
            this.BtnMaxCubes.TabIndex = 11;
            this.BtnMaxCubes.Text = "Max";
            this.BtnMaxCubes.UseVisualStyleBackColor = true;
            this.BtnMaxCubes.Click += new System.EventHandler(this.BtnMaxCubes_Click);
            // 
            // NumCubes
            // 
            this.NumCubes.Location = new System.Drawing.Point(82, 97);
            this.NumCubes.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumCubes.Name = "NumCubes";
            this.NumCubes.Size = new System.Drawing.Size(120, 20);
            this.NumCubes.TabIndex = 10;
            this.NumCubes.ValueChanged += new System.EventHandler(this.NumCubes_ValueChanged);
            // 
            // LblCubes
            // 
            this.LblCubes.AutoSize = true;
            this.LblCubes.Location = new System.Drawing.Point(6, 99);
            this.LblCubes.Name = "LblCubes";
            this.LblCubes.Size = new System.Drawing.Size(40, 13);
            this.LblCubes.TabIndex = 9;
            this.LblCubes.Text = "Cubes:";
            // 
            // FrmTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.BtnReloadParameters);
            this.Controls.Add(this.GrpParameters);
            this.Controls.Add(this.BtnDettach);
            this.Controls.Add(this.BtnAttach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "30XX Trainer - v1.00.15";
            this.GrpParameters.ResumeLayout(false);
            this.GrpParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumNuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTitanShards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCubes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.Button BtnDettach;
        private System.Windows.Forms.GroupBox GrpParameters;
        private System.Windows.Forms.Button BtnMaxMemoria;
        private System.Windows.Forms.NumericUpDown NumMemoria;
        private System.Windows.Forms.Label LblMemoria;
        private System.Windows.Forms.Button BtnMaxTitanShards;
        private System.Windows.Forms.NumericUpDown NumTitanShards;
        private System.Windows.Forms.Label LblTitanShards;
        private System.Windows.Forms.Button BtnReloadParameters;
        private System.Windows.Forms.Button BtnMaxNuts;
        private System.Windows.Forms.NumericUpDown NumNuts;
        private System.Windows.Forms.Label LblNuts;
        private System.Windows.Forms.Button BtnMaxCubes;
        private System.Windows.Forms.NumericUpDown NumCubes;
        private System.Windows.Forms.Label LblCubes;
    }
}

