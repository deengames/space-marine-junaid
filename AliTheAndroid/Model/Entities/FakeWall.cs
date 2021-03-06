using DeenGames.AliTheAndroid.Enums;
using Microsoft.Xna.Framework;

namespace DeenGames.AliTheAndroid.Model.Entities
{
    [System.Diagnostics.DebuggerDisplay("FakeWall at ({X}, {Y})")]
    public class FakeWall : AbstractEntity
    {
        public static readonly Color Colour = Palette.Brown;
        public bool IsBacktrackingWall { get; private set; } = false;

        // Values duplicated in AbstractEntity.Create
        public FakeWall(int x, int y, bool isBacktrackingWall = false)
            : base(x, y, '#', Palette.Grey)
        {
            this.IsBacktrackingWall = isBacktrackingWall;
        }
    }
}