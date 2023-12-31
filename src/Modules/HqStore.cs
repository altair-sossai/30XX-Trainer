using System.Collections.Generic;
using System.Linq;
using _30XX_Trainer.Enums;

namespace _30XX_Trainer.Modules
{
    public class HqStore
    {
        public HqStore(Game game)
        {
            Items = Enumerable.Range(0, 5).Select(index => new StoreItem(game, index)).ToList();
        }

        public List<StoreItem> Items { get; private set; }

        public class StoreItem
        {
            private readonly Game _game;
            private readonly int _index;

            public StoreItem(Game game, int index)
            {
                _game = game;
                _index = index;
            }

            public Item Item
            {
                get => (Item)_game.ReadInt($"hq_store_{_index}_item");
                set => _game.SetInt($"hq_store_{_index}_item", (int)value);
            }

            public int Cost
            {
                get => _game.ReadInt($"hq_store_{_index}_cost");
                set => _game.SetInt($"hq_store_{_index}_cost", value);
            }

            public bool Purchased
            {
                get => _game.ReadInt($"hq_store_{_index}_purchased") == 1;
                set => _game.SetInt($"hq_store_{_index}_purchased", value ? 1 : 0);
            }
        }
    }
}