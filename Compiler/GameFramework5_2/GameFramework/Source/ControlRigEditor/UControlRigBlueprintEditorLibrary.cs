#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprintEditorLibrary.h")]
public partial class UControlRigBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// ControlRigBlueprintEditorLibrary
	public void CastToControlRigBlueprint(UObject Object,ECastToControlRigBlueprintCases Branches,UObject AsControlRigBlueprint) {}
	public void SetPreviewMesh(UObject InRigBlueprint,UObject PreviewMesh,bool bMarkAsDirty/*=true*/) {}
	public UObject GetPreviewMesh(UObject InRigBlueprint) { return default; }
	public void RecompileVM(UObject InRigBlueprint) {}
	public void RecompileVMIfRequired(UObject InRigBlueprint) {}
	public void RequestAutoVMRecompilation(UObject InRigBlueprint) {}
	public void RequestControlRigInit(UObject InRigBlueprint) {}
	public UObject GetModel(UObject InRigBlueprint) { return default; }
	public UObject GetController(UObject InRigBlueprint) { return default; }
	public TArray<UObject> GetCurrentlyOpenRigBlueprints() { return default; }
	public TArray<UObject> GetAvailableRigUnits() { return default; }
	public UObject GetHierarchy(UObject InRigBlueprint) { return default; }
	public UObject GetHierarchyController(UObject InRigBlueprint) { return default; }
}
