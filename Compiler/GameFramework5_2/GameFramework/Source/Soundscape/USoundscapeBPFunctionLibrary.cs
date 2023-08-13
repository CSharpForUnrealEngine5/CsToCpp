namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundScape.h")]
public partial class USoundscapeBPFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Spawns a new Soundscape Elemental Agent. Returns true if spawn was successful.</summary>
	public static bool SpawnSoundscapeColor(UObject WorldContextObject,USoundscapeColor SoundscapeColorIn,UActiveSoundscapeColor ActiveSoundscapeColor) { return default; }
	///<summary>Spawns a new Soundscape Palette Agent. Returns true if spawn was successful.</summary>
	public static bool SpawnSoundscapePalette(UObject WorldContextObject,USoundscapePalette SoundscapePaletteIn,UActiveSoundscapePalette SoundscapePaletteAgentsOut) { return default; }
}
