namespace _30XX_Trainer.Modules
{
    public class GameParameters
    {
        private readonly Game _game;

        public GameParameters(Game game)
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
    }
}