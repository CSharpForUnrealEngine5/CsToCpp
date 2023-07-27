#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprintEditorLibrary.h")]
public partial class UControlRigBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// ControlRigBlueprintEditorLibrary
	public static void CastToControlRigBlueprint(UObject Object,ECastToControlRigBlueprintCases Branches,UControlRigBlueprint AsControlRigBlueprint) {}
	public static void SetPreviewMesh(UControlRigBlueprint InRigBlueprint,USkeletalMesh PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	public static USkeletalMesh GetPreviewMesh(UControlRigBlueprint InRigBlueprint) { return default; }
	public static void RecompileVM(UControlRigBlueprint InRigBlueprint) {}
	public static void RecompileVMIfRequired(UControlRigBlueprint InRigBlueprint) {}
	public static void RequestAutoVMRecompilation(UControlRigBlueprint InRigBlueprint) {}
	public static void RequestControlRigInit(UControlRigBlueprint InRigBlueprint) {}
	public static URigVMGraph GetModel(UControlRigBlueprint InRigBlueprint) { return default; }
	public static URigVMController GetController(UControlRigBlueprint InRigBlueprint) { return default; }
	public static TArray<UControlRigBlueprint> GetCurrentlyOpenRigBlueprints() { return default; }
	public static TArray<UStruct> GetAvailableRigUnits() { return default; }
	public static URigHierarchy GetHierarchy(UControlRigBlueprint InRigBlueprint) { return default; }
	public static URigHierarchyController GetHierarchyController(UControlRigBlueprint InRigBlueprint) { return default; }
}
