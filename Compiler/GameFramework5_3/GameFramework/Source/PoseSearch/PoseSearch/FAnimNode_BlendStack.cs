namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/AnimNode_BlendStack.h")]
public partial struct FAnimNode_BlendStack {
	public UAnimationAsset AnimationAsset;
	public float AnimationTime;
	public bool bLoop;
	public bool bMirrored;
	public float WantedPlayRate;
	public float BlendTime;
	public float RootBoneBlendTime;
	public float MaxAnimationDeltaTime;
	public int MaxActiveBlends;
	public UBlendProfile BlendProfile;
	public EAlphaBlendOption BlendOption;
	public FVector BlendParameters;
	public UMirrorDataTable MirrorDataTable;
}
