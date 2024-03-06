using System.Collections.Generic;
using System.Linq;
using _30XX_Trainer.Enums;

namespace _30XX_Trainer.Modules
{
    public class SmugglerShop
    {
        public SmugglerShop(Game game)
        {
            Items = Enumerable.Range(0, 5).Select(index => new ShopItem(game, index)).ToList();
        }

        public List<ShopItem> Items { get; private set; }

        public class ShopItem
        {
            private readonly Game _game;
            private readonly int _index;

            public ShopItem(Game game, int index)
            {
                _game = game;
                _index = index;
            }

            public Item Item
            {
                get => (Item)_game.ReadInt($"smuggler_shop_{_index}_item");
                set => _game.SetInt($"smuggler_shop_{_index}_item", (int)value);
            }

            public int Cost
            {
                get => _game.ReadInt($"smuggler_shop_{_index}_cost");
                set => _game.SetInt($"smuggler_shop_{_index}_cost", value);
            }

            public bool Purchased
            {
                get => _game.ReadInt($"smuggler_shop_{_index}_purchased") == 1;
                set => _game.SetInt($"smuggler_shop_{_index}_purchased", value ? 1 : 0);
            }
        }
    }
}