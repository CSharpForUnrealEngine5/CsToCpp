namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SoundNodeDistanceCrossFade</summary>
[CppInclude("Sound/SoundNodeDistanceCrossFade.h")]
public partial class USoundNodeDistanceCrossFade : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>Each input needs to have the correct data filled in so the SoundNodeDistanceCrossFade is able</summary>
	public TArray<FDistanceDatum> CrossFadeInput;
}
