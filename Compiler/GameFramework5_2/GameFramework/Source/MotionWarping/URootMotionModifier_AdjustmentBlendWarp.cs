namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>EXPERIMENTAL: Marked with &#39;hidedropdown&#39; to prevent it from showing up in the UI since it is not ready for production.</summary>
[CppInclude("RootMotionModifier_AdjustmentBlendWarp.h")]
public partial class URootMotionModifier_AdjustmentBlendWarp : URootMotionModifier_Warp {
	public static UClass StaticClass() {return default;}
	///<summary>bWarpIKBones</summary>
	public bool bWarpIKBones;
	///<summary>IKBones</summary>
	public TArray<string> IKBones;
	///<summary>CachedMeshTransform</summary>
	public FTransform CachedMeshTransform;
	///<summary>CachedMeshRelativeTransform</summary>
	public FTransform CachedMeshRelativeTransform;
	///<summary>CachedRootMotion</summary>
	public FTransform CachedRootMotion;
	///<summary>Result</summary>
	public FAnimSequenceTrackContainer Result;
}
