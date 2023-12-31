using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Memory;

namespace _30XX_Trainer.Modules
{
    public class Game
    {
        private const int MaxPlayers = 2;
        private readonly string _file;
        private Mem _mem;

        public Game(string file)
        {
            _file = file;
        }

        public Parameters Parameters { get; private set; }
        public HqStore HqStore { get; private set; }
        public List<Player> Players { get; private set; }

        public bool AttachGameProcess()
        {
            _mem = new Mem();

            if (!_mem.OpenProcess("30XX"))
                return false;

            Parameters = new Parameters(this);
            HqStore = new HqStore(this);

            Players = Enumerable.Range(1, MaxPlayers)
                .Select(playerId => new Player(this, playerId))
                .ToList();

            return true;
        }

        public void DettachGameProcess()
        {
            _mem.CloseProcess();
            _mem = null;

            Parameters = null;
            Players = null;
        }

        internal int ReadInt(string code)
        {
            return _mem.ReadInt(code, _file);
        }

        internal bool SetInt(string code, int value)
        {
            return _mem.WriteMemory(code, "int", value.ToString(CultureInfo.InvariantCulture), _file);
        }
    }
}