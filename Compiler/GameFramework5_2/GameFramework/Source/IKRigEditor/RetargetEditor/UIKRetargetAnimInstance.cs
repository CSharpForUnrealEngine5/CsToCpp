namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargetAnimInstance.h")]
public partial class UIKRetargetAnimInstance : UAnimPreviewInstance {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewPoseNode</summary>
	public FAnimNode_PreviewRetargetPose PreviewPoseNode;
	///<summary>RetargetNode</summary>
	public FAnimNode_RetargetPoseFromMesh RetargetNode;
}
