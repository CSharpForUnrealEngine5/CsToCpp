namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseCorrectivesAnimInstance.h")]
public partial class UPoseCorrectivesAnimInstance : UAnimPreviewInstance {
	public static UClass StaticClass() {return default;}
	///<summary>PoseCorrectivesNode</summary>
	public FAnimNode_CorrectPose PoseCorrectivesNode;
	///<summary>ControlRigSourceNode</summary>
	public FAnimNode_ControlRig_CorrectivesSource ControlRigSourceNode;
}
