#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CopyBonesModifier.h")]
///<summary>Animation Modifier to copy the transform of 'SourceBone(s)' to 'TargetBone(s)'</summary>
public partial class UCopyBonesModifier : UAnimationModifier {
// CopyBonesModifier
	public TArray<FBoneReferencePair> BonePairs;
	public EAnimPoseSpaces BonePoseSpace;
}
