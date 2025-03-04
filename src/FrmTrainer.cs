﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using _30XX_Trainer.Enums;
using _30XX_Trainer.Modules;

namespace _30XX_Trainer
{
    public partial class FrmTrainer : Form
    {
        private static readonly string File = $@"{Application.StartupPath}\codes.ini";
        private static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
        private static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
        private readonly Timer _timer = new Timer();
        private Game _game;

        public FrmTrainer()
        {
            InitializeComponent();
        }

        private void FrmTrainer_Load(object sender, EventArgs e)
        {
            _timer.Tick += Timer_Tick;

            Text = $@"30XX Trainer - v{FileVersionInfo.FileVersion}";
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            _game = new Game(File);

            var success = _game.AttachGameProcess();
            if (!success)
            {
                MessageBox.Show(@"Failed to attach to game process", @"Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _timer.Enabled = true;

            BtnAttach.Enabled = false;
            BtnDettach.Enabled = true;
            GrpParameters.Enabled = true;
        }

        private void BtnDettach_Click(object sender, EventArgs e)
        {
            _timer.Enabled = false;

            _game.DettachGameProcess();
            _game = null;

            BtnAttach.Enabled = true;
            BtnDettach.Enabled = false;
            GrpParameters.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateParameters();
            UpdateStartWithResonantArmorSet();
            UpdatePlayers();
        }

        private void UpdateParameters()
        {
            var parameters = _game?.Parameters;
            if (parameters == null)
                return;

            if (CbMemoria.Checked)
                parameters.Memoria = 999_999;

            if (CbTitanShards.Checked)
                parameters.TitanShards = 999_999;

            if (CbNuts.Checked)
                parameters.Nuts = 999_999;

            if (CbCubes.Checked)
                parameters.Cubes = 999_999;
        }

        private void UpdateStartWithResonantArmorSet()
        {
            for (var i = 0; CbStartWithResonantArmorSet.Checked && i < 4 && i < _game.SmugglerShop.Items.Count; i++)
            {
                var shopItem = _game.SmugglerShop.Items[i];

                shopItem.Item = Item.ForceResonator + i;
                shopItem.Purchased = true;
            }
        }

        private void UpdatePlayers()
        {
            foreach (var player in _game.Players)
                UpdatePlayer(player);
        }

        private void UpdatePlayer(Player player)
        {
            if (player == null)
                return;

            if (CbCores.Checked)
                player.Cores = 999_999;

            if (CbMaxHp.Checked)
                player.Hp = player.MaxHp = 999_999;

            if (CbMaxEn.Checked)
                player.En = player.MaxEn = 999_999;

            if (CbAttackPoints.Checked)
                player.AttackPoints = 999;

            if (CbPowerPoints.Checked)
                player.PowerPoints = 999;

            if (CbSpeedPoints.Checked)
                player.SpeedPoints = 100;

            if (CbJumpPoints.Checked)
                player.JumpPoints = 500;
        }
    }
}