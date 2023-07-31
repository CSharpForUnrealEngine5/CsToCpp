#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SoundNodeDistanceCrossFade</summary>
[CppInclude("Sound/SoundNodeDistanceCrossFade.h")]
public partial class USoundNodeDistanceCrossFade : USoundNode {
	///<summary>Each input needs to have the correct data filled in so the SoundNodeDistanceCrossFade is able</summary>
	public TArray<FDistanceDatum> CrossFadeInput;
}
