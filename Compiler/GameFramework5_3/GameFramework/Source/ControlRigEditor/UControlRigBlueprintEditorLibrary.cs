namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprintEditorLibrary.h")]
public partial class UControlRigBlueprintEditorLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CastToControlRigBlueprint</summary>
	public static void CastToControlRigBlueprint(UObject Object,ECastToControlRigBlueprintCases Branches,UControlRigBlueprint AsControlRigBlueprint) {}
	///<summary>SetPreviewMesh</summary>
	public static void SetPreviewMesh(UControlRigBlueprint InRigBlueprint,USkeletalMesh PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	///<summary>GetPreviewMesh</summary>
	public static USkeletalMesh GetPreviewMesh(UControlRigBlueprint InRigBlueprint) { return default; }
	///<summary>RecompileVM</summary>
	public static void RecompileVM(UControlRigBlueprint InRigBlueprint) {}
	///<summary>RecompileVMIfRequired</summary>
	public static void RecompileVMIfRequired(UControlRigBlueprint InRigBlueprint) {}
	///<summary>RequestAutoVMRecompilation</summary>
	public static void RequestAutoVMRecompilation(UControlRigBlueprint InRigBlueprint) {}
	///<summary>RequestControlRigInit</summary>
	public static void RequestControlRigInit(UControlRigBlueprint InRigBlueprint) {}
	///<summary>GetModel</summary>
	public static URigVMGraph GetModel(UControlRigBlueprint InRigBlueprint) { return default; }
	///<summary>GetController</summary>
	public static URigVMController GetController(UControlRigBlueprint InRigBlueprint) { return default; }
	///<summary>GetCurrentlyOpenRigBlueprints</summary>
	public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints() { return default; }
	///<summary>GetAvailableRigUnits</summary>
	public static TArray<UStruct> GetAvailableRigUnits() { return default; }
	///<summary>GetHierarchy</summary>
	public static URigHierarchy GetHierarchy(UControlRigBlueprint InRigBlueprint) { return default; }
	///<summary>GetHierarchyController</summary>
	public static URigHierarchyController GetHierarchyController(UControlRigBlueprint InRigBlueprint) { return default; }
	///<summary>SetupAllEditorMenus</summary>
	public static void SetupAllEditorMenus() {}
}
