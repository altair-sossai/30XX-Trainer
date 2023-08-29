namespace _30XX_Trainer.Modules
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
            get => _game.ReadInt("nuts") - _game.ReadInt("nuts_magic_number");
            set => _game.SetInt("nuts", value + _game.ReadInt("nuts_magic_number"));
        }

        public int Cubes
        {
            get => _game.ReadInt("cubes");
            set => _game.SetInt("cubes", value);
        }

        public int Cores
        {
            get => _game.ReadInt("cores");
            set => _game.SetInt("cores", value);
        }

        public int Hp
        {
            get => _game.ReadInt("hp");
            set => _game.SetInt("hp", value);
        }

        public int MaxHp
        {
            get => _game.ReadInt("max_hp");
            set => _game.SetInt("max_hp", value);
        }

        public int En
        {
            get => _game.ReadInt("en");
            set => _game.SetInt("en", value);
        }

        public int MaxEn
        {
            get => _game.ReadInt("max_en");
            set => _game.SetInt("max_en", value);
        }

        public int AttackPoints
        {
            get => _game.ReadInt("attack_points");
            set => _game.SetInt("attack_points", value);
        }

        public int PowerPoints
        {
            get => _game.ReadInt("power_points");
            set => _game.SetInt("power_points", value);
        }

        public int SpeedPoints
        {
            get => _game.ReadInt("speed_points");
            set => _game.SetInt("speed_points", value);
        }

        public int JumpPoints
        {
            get => _game.ReadInt("jump_points");
            set => _game.SetInt("jump_points", value);
        }
    }
}