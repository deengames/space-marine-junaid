using DeenGames.AliTheAndroid.Accessibility.Colour;

namespace DeenGames.AliTheAndroid
{
    public static class Options
    {
        // Options
        public static bool DisplayOldStyleAsciiCharacters = false;
        public static SelectablePalette CurrentPalette = SelectablePalette.SaturatedPalette;

        // Constants
        public const bool ShowFakeWalls = true; // Should always be true

        // Debug stuff
        public const bool StartWithAllWeapons = false;
        public const bool EnableOmniSight = true;
        public const bool CanUseStairsFromAnywhere = true;
        public const bool PlayerStartsWithAllDataCubes = true;
    }
}