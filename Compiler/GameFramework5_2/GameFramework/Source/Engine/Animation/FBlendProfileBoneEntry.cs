#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single entry for a blend scale within a profile, mapping a bone to a blendscale</summary>
[CppInclude("Animation/BlendProfile.h")]
public partial struct FBlendProfileBoneEntry {
	public FBoneReference BoneReference;
	public float BlendScale;
}
