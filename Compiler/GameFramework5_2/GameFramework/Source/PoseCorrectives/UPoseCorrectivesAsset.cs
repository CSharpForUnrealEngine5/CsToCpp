namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Pose Correctives Asset</summary>
[CppInclude("PoseCorrectivesAsset.h")]
public partial class UPoseCorrectivesAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Animation Pose Data</summary>
	public TMap<string,FPoseCorrective> PoseCorrectives;
	///<summary>Predefined groups stored here in editor mode for configuring groups in UI and applying to pose but runtime driver/corrective bones live with pose</summary>
	public TMap<string,FPoseGroupDefinition> GroupDefinitions;
	///<summary>TargetMesh</summary>
	public USkeletalMesh TargetMesh;
	///<summary>SourcePreviewMesh</summary>
	public USkeletalMesh SourcePreviewMesh;
	///<summary>ControlRigBlueprint</summary>
	public UObject ControlRigBlueprint;
	///<summary>SourceMeshOffset</summary>
	public FVector SourceMeshOffset;
	///<summary>SourceMeshScale</summary>
	public float SourceMeshScale;
	///<summary>Default rbf params</summary>
	public FRBFParams RBFParams;
}
