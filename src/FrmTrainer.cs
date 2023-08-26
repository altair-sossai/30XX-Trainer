using System;
using System.Windows.Forms;
using _30XX_Trainer.Modules;

namespace _30XX_Trainer
{
    public partial class FrmTrainer : Form
    {
        private static readonly string File = $@"{Application.StartupPath}\codes.ini";
        private Game _game;

        public FrmTrainer()
        {
            InitializeComponent();
        }

        private GameParameters Parameters => _game.Parameters;

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            _game = new Game(File);

            var success = _game.AttachGameProcess();
            if (!success)
            {
                MessageBox.Show("Failed to attach to game process");
                return;
            }

            BtnAttach.Enabled = false;
            BtnDettach.Enabled = true;
            BtnReloadParameters.Enabled = true;
            GrpParameters.Enabled = true;

            ReloadParameters();
        }

        private void BtnDettach_Click(object sender, EventArgs e)
        {
            _game.DettachGameProcess();
            _game = null;

            BtnAttach.Enabled = true;
            BtnDettach.Enabled = false;
            BtnReloadParameters.Enabled = false;
            GrpParameters.Enabled = false;
        }

        private void BtnReloadParameters_Click(object sender, EventArgs e)
        {
            ReloadParameters();
        }

        private void NumMemoria_ValueChanged(object sender, EventArgs e)
        {
            Parameters.Memoria = (int)NumMemoria.Value;
        }

        private void BtnMaxMemoria_Click(object sender, EventArgs e)
        {
            NumMemoria.Value = 999_999;
        }

        private void NumTitanShards_ValueChanged(object sender, EventArgs e)
        {
            Parameters.TitanShards = (int)NumTitanShards.Value;
        }

        private void BtnMaxTitanShards_Click(object sender, EventArgs e)
        {
            NumTitanShards.Value = 999_999;
        }

        private void NumNuts_ValueChanged(object sender, EventArgs e)
        {
            Parameters.Nuts = (int)NumNuts.Value;
        }

        private void BtnMaxNuts_Click(object sender, EventArgs e)
        {
            NumNuts.Value = 999_999;
        }

        private void NumCubes_ValueChanged(object sender, EventArgs e)
        {
            Parameters.Cubes = (int)NumCubes.Value;
        }

        private void BtnMaxCubes_Click(object sender, EventArgs e)
        {
            NumCubes.Value = 999_999;
        }

        private void ReloadParameters()
        {
            NumMemoria.Value = Parameters.Memoria;
            NumTitanShards.Value = Parameters.TitanShards;
            NumNuts.Value = Parameters.Nuts;
            NumCubes.Value = Parameters.Cubes;
        }
    }
}