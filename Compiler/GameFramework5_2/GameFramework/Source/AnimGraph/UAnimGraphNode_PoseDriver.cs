#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_PoseDriver.h")]
public partial class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler {
// AnimGraphNode_PoseDriver
	public FAnimNode_PoseDriver Node;
	public float AxisLength;
	public int ConeSubdivision;
	public bool bDrawDebugCones;
	public  void CopyTargetsFromPoseAsset() {}
	public  void SetSourceBones(TArray<string> BoneNames) {}
	public  void GetSourceBoneNames(TArray<string> BoneNames) {}
	public  void SetDrivingBones(TArray<string> BoneNames) {}
	public  void GetDrivingBoneNames(TArray<string> BoneNames) {}
	public  void SetRBFParameters(FRBFParams Parameters) {}
	public  FRBFParams GetRBFParameters() { return default; }
	public  void SetPoseDriverSource(EPoseDriverSource DriverSource) {}
	public  EPoseDriverSource GetPoseDriverSource() { return default; }
	public  void SetPoseDriverOutput(EPoseDriverOutput DriverOutput) {}
	public  EPoseDriverOutput GetPoseDriverOutput() { return default; }
	public  void SetOnlyDriveSelectedBones(bool bOnlyDriveSelectedBones) {}
	public  bool GetOnlyDriveSelectedBones() { return default; }
	public USkeletalMeshComponent LastPreviewComponent;
}
