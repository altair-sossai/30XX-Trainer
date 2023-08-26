using System.Globalization;
using Memory;

namespace _30XX_Trainer.Modules
{
    public class Game
    {
        private readonly string _file;
        private Mem _mem;

        public Game(string file)
        {
            _file = file;
        }

        public GameParameters Parameters { get; private set; }

        public bool AttachGameProcess()
        {
            _mem = new Mem();

            if (!_mem.OpenProcess("30XX"))
                return false;

            Parameters = new GameParameters(this);

            return true;
        }

        public void DettachGameProcess()
        {
            _mem.CloseProcess();
            _mem = null;
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