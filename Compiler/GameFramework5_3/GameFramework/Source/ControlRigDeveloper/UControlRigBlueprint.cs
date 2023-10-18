namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprint.h")]
public partial class UControlRigBlueprint : URigVMBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>GetControlRigClass</summary>
	public UClass GetControlRigClass() { return default; }
	///<summary>CreateControlRig</summary>
	public UControlRig CreateControlRig() { return default; }
	///<summary>IInterface_PreviewMeshProvider interface</summary>
	public virtual void SetPreviewMesh(USkeletalMesh PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	///<summary>GetPreviewMesh</summary>
	public virtual USkeletalMesh GetPreviewMesh() { return default; }
	///<summary>HierarchySettings</summary>
	public FRigHierarchySettings HierarchySettings;
	///<summary>Asset searchable information about exposed public functions on this rig</summary>
	public TArray<FRigVMOldPublicFunctionData> PublicFunctions_DEPRECATED;
	///<summary>GetCurrentlyOpenRigBlueprints</summary>
	public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints() { return default; }
	///<summary>GizmoLibrary_DEPRECATED</summary>
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	///<summary>ShapeLibraries</summary>
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	///<summary>Statistics_DEPRECATED</summary>
	public FRigVMStatistics Statistics_DEPRECATED;
	///<summary>DrawContainer</summary>
	public FRigVMDrawContainer DrawContainer;
	///<summary>Influences</summary>
	public FRigInfluenceMapPerEvent Influences;
	///<summary>HierarchyContainer_DEPRECATED</summary>
	public FRigHierarchyContainer HierarchyContainer_DEPRECATED;
	///<summary>Hierarchy</summary>
	public URigHierarchy Hierarchy;
	///<summary>GetHierarchyController</summary>
	public URigHierarchyController GetHierarchyController() { return default; }
	///<summary>Whether or not this rig has an Inversion Event</summary>
	public bool bSupportsInversion;
	///<summary>Whether or not this rig has Controls on It</summary>
	public bool bSupportsControls;
	///<summary>PreviewSkeletalMesh</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>The skeleton from import into a hierarchy</summary>
	public TSoftObjectPtr<UObject> SourceHierarchyImport;
	///<summary>The skeleton from import into a curve</summary>
	public TSoftObjectPtr<UObject> SourceCurveImport;
	///<summary>If set to true, this control rig has animatable controls</summary>
	public bool bExposesAnimatableControls;
	///<summary>Validator</summary>
	public UControlRigValidator Validator;
	///<summary>DebugBoneRadius</summary>
	public float DebugBoneRadius;
}
