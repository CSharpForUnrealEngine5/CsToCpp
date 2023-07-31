#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class containing relevant data for a Soundscape Element</summary>
[CppInclude("SoundScapePalette.h")]
public partial class USoundscapePalette : UObject {
	///<summary>SoundscapePalettePlaybackConditions</summary>
	public FGameplayTagQuery SoundscapePalettePlaybackConditions;
	///<summary>Elements</summary>
	public TArray<FSoundscapePaletteColor> Colors;
}
