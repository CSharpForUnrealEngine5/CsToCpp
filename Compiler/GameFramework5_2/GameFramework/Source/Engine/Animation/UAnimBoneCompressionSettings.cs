#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimBoneCompressionSettings.h")]
///<summary>* This object is used to wrap a bone compression codec. It allows a clean integration in the editor by avoiding the need</summary>
public partial class UAnimBoneCompressionSettings : UObject {
// AnimBoneCompressionSettings
	public TArray<UAnimBoneCompressionCodec> Codecs;
	public float ErrorThreshold;
	public bool bForceBelowThreshold;
}
