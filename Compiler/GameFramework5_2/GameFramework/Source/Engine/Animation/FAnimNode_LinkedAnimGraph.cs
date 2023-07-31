#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_LinkedAnimGraph.h")]
public partial struct FAnimNode_LinkedAnimGraph {
	public TArray<FPoseLink> InputPoses;
	public TArray<string> InputPoseNames;
	public UClass InstanceClass;
	public string Tag_DEPRECATED;
	public UBlendProfile PendingBlendOutProfile;
	public UBlendProfile PendingBlendInProfile;
	public bool bReceiveNotifiesFromLinkedInstances;
	public bool bPropagateNotifiesToLinkedInstances;
}
