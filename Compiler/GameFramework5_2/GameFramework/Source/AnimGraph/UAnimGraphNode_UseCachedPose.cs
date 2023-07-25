#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_UseCachedPose.h")]
public partial class UAnimGraphNode_UseCachedPose : UAnimGraphNode_Base {
// AnimGraphNode_UseCachedPose
	public FAnimNode_UseCachedPose Node;
	public TWeakObjectPtr<UAnimGraphNode_SaveCachedPose> SaveCachedPoseNode;
	public string NameOfCache;
}
