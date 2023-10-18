namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMBlueprint.h")]
public partial class URigVMBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>RecompileVM</summary>
	public void RecompileVM() {}
	///<summary>RecompileVMIfRequired</summary>
	public void RecompileVMIfRequired() {}
	///<summary>RequestAutoVMRecompilation</summary>
	public void RequestAutoVMRecompilation() {}
	///<summary>SetAutoVMRecompile</summary>
	public void SetAutoVMRecompile(bool bAutoRecompile) {}
	///<summary>GetAutoVMRecompile</summary>
	public bool GetAutoVMRecompile() { return default; }
	///<summary>RequestRigVMInit</summary>
	public void RequestRigVMInit() {}
	///<summary>GetModel</summary>
	public URigVMGraph GetModel(UEdGraph InEdGraph/*=nullptr*/) { return default; }
	///<summary>GetDefaultModel</summary>
	public URigVMGraph GetDefaultModel() { return default; }
	///<summary>GetAllModels</summary>
	public TArray<URigVMGraph> GetAllModels() { return default; }
	///<summary>GetLocalFunctionLibrary</summary>
	public URigVMFunctionLibrary GetLocalFunctionLibrary() { return default; }
	///<summary>AddModel</summary>
	public URigVMGraph AddModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveModel</summary>
	public bool RemoveModel(string InName/*=TEXT("Rig Graph")*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>GetFocusedModel</summary>
	public URigVMGraph GetFocusedModel() { return default; }
	///<summary>GetController</summary>
	public URigVMController GetController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	///<summary>GetControllerByName</summary>
	public URigVMController GetControllerByName(string InGraphName/*=TEXT("")*/) { return default; }
	///<summary>GetOrCreateController</summary>
	public URigVMController GetOrCreateController(URigVMGraph InGraph/*=nullptr*/) { return default; }
	///<summary>GeneratePythonCommands</summary>
	public virtual TArray<string> GeneratePythonCommands(string InNewBlueprintName) { return default; }
	///<summary>FunctionLibraryEdGraph</summary>
	public URigVMEdGraph FunctionLibraryEdGraph;
	///<summary>RigGraphDisplaySettings</summary>
	public FRigVMEdGraphDisplaySettings RigGraphDisplaySettings;
	///<summary>VMRuntimeSettings</summary>
	public FRigVMRuntimeSettings VMRuntimeSettings;
	///<summary>VMCompileSettings</summary>
	public FRigVMCompileSettings VMCompileSettings;
	///<summary>PythonLogSettings</summary>
	public FRigVMPythonSettings PythonLogSettings;
	///<summary>Model_DEPRECATED</summary>
	public URigVMGraph Model_DEPRECATED;
	///<summary>FunctionLibrary_DEPRECATED</summary>
	public URigVMFunctionLibrary FunctionLibrary_DEPRECATED;
	///<summary>RigVMClient</summary>
	public FRigVMClient RigVMClient;
	///<summary>ReferencedObjectPathsStored</summary>
	public bool ReferencedObjectPathsStored;
	///<summary>ReferencedObjectPaths</summary>
	public TArray<FSoftObjectPath> ReferencedObjectPaths;
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
	///<summary>GetRigVMHostClass</summary>
	public UClass GetRigVMHostClass() { return default; }
	///<summary>CreateRigVMHost</summary>
	public URigVMHost CreateRigVMHost() { return default; }
	///<summary>GetAvailableRigVMStructs</summary>
	public virtual TArray<UStruct> GetAvailableRigVMStructs() { return default; }
	///<summary>GetMemberVariables</summary>
	public TArray<FRigVMGraphVariableDescription> GetMemberVariables() { return default; }
	///<summary>AddMemberVariable</summary>
	public FName AddMemberVariable(FName InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
	///<summary>RemoveMemberVariable</summary>
	public bool RemoveMemberVariable(FName InName) { return default; }
	///<summary>RenameMemberVariable</summary>
	public bool RenameMemberVariable(FName InOldName,FName InNewName) { return default; }
	///<summary>ChangeMemberVariableType</summary>
	public bool ChangeMemberVariableType(FName InName,string InCPPType,bool bIsPublic/*=false*/,bool bIsReadOnly/*=false*/,string InDefaultValue/*=TEXT("")*/) { return default; }
	///<summary>The event names this rigvm blueprint contains</summary>
	public TArray<FName> SupportedEventNames;
	///<summary>bAutoRecompileVM</summary>
	public bool bAutoRecompileVM;
	///<summary>bVMRecompilationRequired</summary>
	public bool bVMRecompilationRequired;
	///<summary>bIsCompiling</summary>
	public bool bIsCompiling;
	///<summary>VMRecompilationBracket</summary>
	public int VMRecompilationBracket;
	///<summary>SuspendNotifications</summary>
	public void SuspendNotifications(bool bSuspendNotifs) {}
}
