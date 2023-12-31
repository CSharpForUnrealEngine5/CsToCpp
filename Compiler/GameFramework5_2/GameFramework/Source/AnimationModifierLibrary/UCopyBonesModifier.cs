namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation Modifier to copy the transform of &#39;SourceBone(s)&#39; to &#39;TargetBone(s)&#39;</summary>
[CppInclude("CopyBonesModifier.h")]
public partial class UCopyBonesModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Source and Target bone pairs</summary>
	public TArray<FBoneReferencePair> BonePairs;
	///<summary>Space to convert SourceBone transforms into before copying them to TargetBone</summary>
	public EAnimPoseSpaces BonePoseSpace;
}
