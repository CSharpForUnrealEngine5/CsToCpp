namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundCueDistanceCrossfade.h")]
public partial class USoundCueDistanceCrossfade : USoundCueTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>Variations</summary>
	public TArray<FSoundCueCrossfadeInfo> Variations;
}
