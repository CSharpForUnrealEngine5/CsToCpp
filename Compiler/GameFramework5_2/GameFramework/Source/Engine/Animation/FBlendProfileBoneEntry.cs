#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/BlendProfile.h")]
///<summary>A single entry for a blend scale within a profile, mapping a bone to a blendscale</summary>
public partial struct FBlendProfileBoneEntry {
// BlendProfileBoneEntry
	public FBoneReference BoneReference;
	public float BlendScale;
}
