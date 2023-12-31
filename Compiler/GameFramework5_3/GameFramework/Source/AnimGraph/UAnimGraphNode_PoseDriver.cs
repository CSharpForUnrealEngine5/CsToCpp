namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_PoseDriver.h")]
public partial class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_PoseDriver Node;
	///<summary>Length of axis in world units used for debug drawing</summary>
	public float AxisLength;
	///<summary>Number of subdivisions / lines used when debug drawing a cone</summary>
	public int ConeSubdivision;
	///<summary>If checked the cones will be drawn in 3d for debugging</summary>
	public bool bDrawDebugCones;
	///<summary>Util to replace current contents of PoseTargets with info from assigned PoseAsset</summary>
	public void CopyTargetsFromPoseAsset() {}
	///<summary>Sets the pose-driver its source bones by name</summary>
	public void SetSourceBones(TArray<FName> BoneNames) {}
	///<summary>Returns the pose-driver its source bones by name</summary>
	public void GetSourceBoneNames(TArray<FName> BoneNames) {}
	///<summary>Set the pose-driver its driven bones by name</summary>
	public void SetDrivingBones(TArray<FName> BoneNames) {}
	///<summary>Returns the pose-driver its driven bones by name</summary>
	public void GetDrivingBoneNames(TArray<FName> BoneNames) {}
	///<summary>SetRBFParameters</summary>
	public void SetRBFParameters(FRBFParams Parameters) {}
	///<summary>GetRBFParameters</summary>
	public FRBFParams GetRBFParameters() { return default; }
	///<summary>SetPoseDriverSource</summary>
	public void SetPoseDriverSource(EPoseDriverSource DriverSource) {}
	///<summary>GetPoseDriverSource</summary>
	public EPoseDriverSource GetPoseDriverSource() { return default; }
	///<summary>SetPoseDriverOutput</summary>
	public void SetPoseDriverOutput(EPoseDriverOutput DriverOutput) {}
	///<summary>GetPoseDriverOutput</summary>
	public EPoseDriverOutput GetPoseDriverOutput() { return default; }
	///<summary>Used to refer back to preview instance in anim tools</summary>
	public USkeletalMeshComponent LastPreviewComponent;
}
