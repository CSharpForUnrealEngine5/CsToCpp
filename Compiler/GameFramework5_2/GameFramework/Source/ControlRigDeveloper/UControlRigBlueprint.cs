#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprint.h")]
public partial class UControlRigBlueprint : UBlueprint {
// ControlRigBlueprint
	public  void SetPreviewMesh(USkeletalMesh PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	public  USkeletalMesh GetPreviewMesh() { return default; }
	public  void RecompileVM() {}
	public  void RecompileVMIfRequired() {}
	public  void RequestAutoVMRecompilation() {}
	public  void SetAutoVMRecompile(bool bAutoRecompile) {}
	public  void RequestControlRigInit() {}
	public  URigVMGraph GetModel(UEdGraph InEdGraph/*=nullptr*/) { return default; }
	public  URigVMGraph GetDefaultModel() { return default; }
	public  TArray<URigVMGraph> GetAllModels() { return default; }
	public  URigVMFunctionLibrary GetLocalFunctionLibrary() { return default; }
	public  URigVMGraph AddModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	public  bool RemoveModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	public  URigVMController GetController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	public  URigVMController GetControllerByName(string InGraphName/*=TEXT("")*/) { return default; }
	public  URigVMController GetOrCreateController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	public  TArray<string> GeneratePythonCommands(string InNewBlueprintName) { return default; }
	public UControlRigGraph FunctionLibraryEdGraph;
	public FRigGraphDisplaySettings RigGraphDisplaySettings;
	public FRigHierarchySettings HierarchySettings;
	public FRigVMRuntimeSettings VMRuntimeSettings;
	public FRigVMCompileSettings VMCompileSettings;
	public FControlRigPythonSettings PythonLogSettings;
	public URigVMGraph Model_DEPRECATED;
	public URigVMFunctionLibrary FunctionLibrary_DEPRECATED;
	public FRigVMClient RigVMClient;
	public TArray<FControlRigPublicFunctionData> PublicFunctions_DEPRECATED;
	public TArray<FRigVMGraphFunctionHeader> PublicGraphFunctions;
	public TArray<FRigVMReferenceNodeData> FunctionReferenceNodeData;
	public URigVMGraph TemplateModel;
	public URigVMController TemplateController;
	public TMap<string,FRigVMOperand> PinToOperandMap;
	public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints() { return default; }
	public  UClass GetControlRigClass() { return default; }
	public  UControlRig CreateControlRig() { return default; }
	public static TArray<UStruct> GetAvailableRigUnits() { return default; }
	public  TArray<FRigVMGraphVariableDescription> GetMemberVariables() { return default; }
	public  string AddMemberVariable(string InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
	public  bool RemoveMemberVariable(string InName) { return default; }
	public  bool RenameMemberVariable(string InOldName,string InNewName) { return default; }
	public  bool ChangeMemberVariableType(string InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	public FRigVMStatistics Statistics_DEPRECATED;
	public FRigVMDrawContainer DrawContainer;
	public FRigInfluenceMapPerEvent Influences;
	public FRigHierarchyContainer HierarchyContainer_DEPRECATED;
	public URigHierarchy Hierarchy;
	public  URigHierarchyController GetHierarchyController() { return default; }
	public bool bSupportsInversion;
	public bool bSupportsControls;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TSoftObjectPtr<UObject> SourceHierarchyImport;
	public TSoftObjectPtr<UObject> SourceCurveImport;
	public TArray<string> SupportedEventNames;
	public bool bExposesAnimatableControls;
	public bool bAutoRecompileVM;
	public bool bVMRecompilationRequired;
	public bool bIsCompiling;
	public int VMRecompilationBracket;
	public  void SuspendNotifications(bool bSuspendNotifs) {}
	public UControlRigValidator Validator;
	public float DebugBoneRadius;
}
