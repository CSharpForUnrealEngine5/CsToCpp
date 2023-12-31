namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This object is used to wrap a bone compression codec. It allows a clean integration in the editor by avoiding the need</summary>
[CppInclude("Animation/AnimBoneCompressionSettings.h")]
public partial class UAnimBoneCompressionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A list of animation bone compression codecs to try. Empty entries are ignored but the array cannot be empty.</summary>
	public TArray<UAnimBoneCompressionCodec> Codecs;
	///<summary>When compressing, the best codec below this error threshold will be used.</summary>
	public float ErrorThreshold;
	///<summary>Any codec (even one that increases the size) with a lower error will be used until it falls below the threshold.</summary>
	public bool bForceBelowThreshold;
}
