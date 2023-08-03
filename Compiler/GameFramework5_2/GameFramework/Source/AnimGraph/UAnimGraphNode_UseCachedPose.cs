#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_UseCachedPose.h")]
public partial class UAnimGraphNode_UseCachedPose : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_UseCachedPose Node;
	///<summary>SaveCachedPoseNode</summary>
	public TWeakObjectPtr<UAnimGraphNode_SaveCachedPose> SaveCachedPoseNode;
	///<summary>NameOfCache</summary>
	public string NameOfCache;
}
