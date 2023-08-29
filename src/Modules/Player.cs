namespace _30XX_Trainer.Modules
{
    public class Player
    {
        private readonly Game _game;
        private readonly int _playerId;

        public Player(Game game, int playerId)
        {
            _game = game;
            _playerId = playerId;
        }

        public int Hp
        {
            get => ReadInt("hp");
            set => SetInt("hp", value);
        }

        public int MaxHp
        {
            get => ReadInt("max_hp");
            set => SetInt("max_hp", value);
        }

        public int En
        {
            get => ReadInt("en");
            set => SetInt("en", value);
        }

        public int MaxEn
        {
            get => ReadInt("max_en");
            set => SetInt("max_en", value);
        }

        public int AttackPoints
        {
            get => ReadInt("attack_points");
            set => SetInt("attack_points", value);
        }

        public int PowerPoints
        {
            get => ReadInt("power_points");
            set => SetInt("power_points", value);
        }

        public int SpeedPoints
        {
            get => ReadInt("speed_points");
            set => SetInt("speed_points", value);
        }

        public int JumpPoints
        {
            get => ReadInt("jump_points");
            set => SetInt("jump_points", value);
        }

        public int Cores
        {
            get => ReadInt("cores");
            set => SetInt("cores", value);
        }

        private int ReadInt(string code)
        {
            return _game.ReadInt($"player_{_playerId}_{code}");
        }

        private void SetInt(string code, int value)
        {
            _game.SetInt($"player_{_playerId}_{code}", value);
        }
    }
}