namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNode_LinkedAnimGraph.h")]
public partial struct FAnimNode_LinkedAnimGraph {
	public TArray<FPoseLink> InputPoses;
	public TArray<FName> InputPoseNames;
	public UClass InstanceClass;
	public FName Tag_DEPRECATED;
	public UBlendProfile PendingBlendOutProfile;
	public UBlendProfile PendingBlendInProfile;
	public bool bReceiveNotifiesFromLinkedInstances;
	public bool bPropagateNotifiesToLinkedInstances;
}
