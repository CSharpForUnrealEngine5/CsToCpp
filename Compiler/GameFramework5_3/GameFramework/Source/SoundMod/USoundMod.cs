namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundMod.h")]
public partial class USoundMod : USoundBase {
	public static UClass StaticClass() {return default;}
	///<summary>If set, when played directly (not through a sound cue) the nid will be played looping.</summary>
	public bool bLooping;
}
