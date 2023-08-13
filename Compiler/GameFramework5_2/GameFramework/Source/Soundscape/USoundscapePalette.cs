namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class containing relevant data for a Soundscape Element</summary>
[CppInclude("SoundScapePalette.h")]
public partial class USoundscapePalette : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SoundscapePalettePlaybackConditions</summary>
	public FGameplayTagQuery SoundscapePalettePlaybackConditions;
	///<summary>Elements</summary>
	public TArray<FSoundscapePaletteColor> Colors;
}
