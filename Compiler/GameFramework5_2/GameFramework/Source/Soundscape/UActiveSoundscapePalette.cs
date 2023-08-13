namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundScapePalette.h")]
public partial class UActiveSoundscapePalette : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Play</summary>
	public void Play() {}
	///<summary>Stop</summary>
	public void Stop() {}
	///<summary>World</summary>
	public UWorld World;
	///<summary>ActiveSoundscapeColors</summary>
	public TArray<UActiveSoundscapeColor> ActiveSoundscapeColors;
}
