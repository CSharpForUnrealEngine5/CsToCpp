#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprint.h")]
public partial class UControlRigBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>IInterface_PreviewMeshProvider interface</summary>
	public  void SetPreviewMesh(USkeletalMesh PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	///<summary>GetPreviewMesh</summary>
	public  USkeletalMesh GetPreviewMesh() { return default; }
	///<summary>RecompileVM</summary>
	public  void RecompileVM() {}
	///<summary>RecompileVMIfRequired</summary>
	public  void RecompileVMIfRequired() {}
	///<summary>RequestAutoVMRecompilation</summary>
	public  void RequestAutoVMRecompilation() {}
	///<summary>SetAutoVMRecompile</summary>
	public  void SetAutoVMRecompile(bool bAutoRecompile) {}
	///<summary>RequestControlRigInit</summary>
	public  void RequestControlRigInit() {}
	///<summary>GetModel</summary>
	public  URigVMGraph GetModel(UEdGraph InEdGraph/*=nullptr*/) { return default; }
	///<summary>GetDefaultModel</summary>
	public  URigVMGraph GetDefaultModel() { return default; }
	///<summary>GetAllModels</summary>
	public  TArray<URigVMGraph> GetAllModels() { return default; }
	///<summary>GetLocalFunctionLibrary</summary>
	public  URigVMFunctionLibrary GetLocalFunctionLibrary() { return default; }
	///<summary>AddModel</summary>
	public  URigVMGraph AddModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveModel</summary>
	public  bool RemoveModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>GetController</summary>
	public  URigVMController GetController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	///<summary>GetControllerByName</summary>
	public  URigVMController GetControllerByName(string InGraphName/*=TEXT("")*/) { return default; }
	///<summary>GetOrCreateController</summary>
	public  URigVMController GetOrCreateController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	///<summary>GeneratePythonCommands</summary>
	public  TArray<string> GeneratePythonCommands(string InNewBlueprintName) { return default; }
	///<summary>FunctionLibraryEdGraph</summary>
	public UControlRigGraph FunctionLibraryEdGraph;
	///<summary>RigGraphDisplaySettings</summary>
	public FRigGraphDisplaySettings RigGraphDisplaySettings;
	///<summary>HierarchySettings</summary>
	public FRigHierarchySettings HierarchySettings;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>VMCompileSettings</summary>
	public FRigVMCompileSettings VMCompileSettings;
	///<summary>PythonLogSettings</summary>
	public FControlRigPythonSettings PythonLogSettings;
	///<summary>Model_DEPRECATED</summary>
	public URigVMGraph Model_DEPRECATED;
	///<summary>FunctionLibrary_DEPRECATED</summary>
	public URigVMFunctionLibrary FunctionLibrary_DEPRECATED;
	///<summary>RigVMClient</summary>
	public FRigVMClient RigVMClient;
	///<summary>Asset searchable information about exposed public functions on this rig</summary>
	public TArray<FControlRigPublicFunctionData> PublicFunctions_DEPRECATED;
	///<summary>Asset searchable information about exposed public functions on this rig</summary>
	public TArray<FRigVMGraphFunctionHeader> PublicGraphFunctions;
	///<summary>Asset searchable information function references in this rig</summary>
	public TArray<FRigVMReferenceNodeData> FunctionReferenceNodeData;
	///<summary>TemplateModel</summary>
	public URigVMGraph TemplateModel;
	///<summary>TemplateController</summary>
	public URigVMController TemplateController;
	///<summary>PinToOperandMap</summary>
	public TMap<string,FRigVMOperand> PinToOperandMap;
	///<summary>GetCurrentlyOpenRigBlueprints</summary>
	public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints() { return default; }
	///<summary>GetControlRigClass</summary>
	public  UClass GetControlRigClass() { return default; }
	///<summary>CreateControlRig</summary>
	public  UControlRig CreateControlRig() { return default; }
	///<summary>GetAvailableRigUnits</summary>
	public static TArray<UStruct> GetAvailableRigUnits() { return default; }
	///<summary>GetMemberVariables</summary>
	public  TArray<FRigVMGraphVariableDescription> GetMemberVariables() { return default; }
	///<summary>AddMemberVariable</summary>
	public  string AddMemberVariable(string InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
	///<summary>RemoveMemberVariable</summary>
	public  bool RemoveMemberVariable(string InName) { return default; }
	///<summary>RenameMemberVariable</summary>
	public  bool RenameMemberVariable(string InOldName,string InNewName) { return default; }
	///<summary>ChangeMemberVariableType</summary>
	public  bool ChangeMemberVariableType(string InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
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
	public  URigHierarchyController GetHierarchyController() { return default; }
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
	///<summary>The event names this control rig blueprint contains</summary>
	public TArray<string> SupportedEventNames;
	///<summary>If set to true, this control rig has animatable controls</summary>
	public bool bExposesAnimatableControls;
	///<summary>bAutoRecompileVM</summary>
	public bool bAutoRecompileVM;
	///<summary>bVMRecompilationRequired</summary>
	public bool bVMRecompilationRequired;
	///<summary>bIsCompiling</summary>
	public bool bIsCompiling;
	///<summary>VMRecompilationBracket</summary>
	public int VMRecompilationBracket;
	///<summary>SuspendNotifications</summary>
	public  void SuspendNotifications(bool bSuspendNotifs) {}
	///<summary>Validator</summary>
	public UControlRigValidator Validator;
	///<summary>DebugBoneRadius</summary>
	public float DebugBoneRadius;
}
