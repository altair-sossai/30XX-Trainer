﻿namespace _30XX_Trainer.Modules
{
    public class Parameters
    {
        private readonly Game _game;

        public Parameters(Game game)
        {
            _game = game;
        }

        public int Memoria
        {
            get => _game.ReadInt("memoria");
            set => _game.SetInt("memoria", value);
        }

        public int TitanShards
        {
            get => _game.ReadInt("titan_shards");
            set => _game.SetInt("titan_shards", value);
        }

        public int Nuts
        {
            get => _game.ReadInt("nuts_magic_number") - _game.ReadInt("nuts");
            set => _game.SetInt("nuts_magic_number", value + _game.ReadInt("nuts"));
        }

        public int Cubes
        {
            get => _game.ReadInt("cubes");
            set => _game.SetInt("cubes", value);
        }
    }
}