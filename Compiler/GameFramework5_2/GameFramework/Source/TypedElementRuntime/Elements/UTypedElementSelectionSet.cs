#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementSelectionSet.h")]
///<summary>A wrapper around an element list that ensures mutation goes via the selection</summary>
public partial class UTypedElementSelectionSet : UObject {
// TypedElementSelectionSet
	public bool ClearSelection(FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public int GetNumSelectedElements() { return default; }
	public bool HasSelectedElements(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	public int CountSelectedElements(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	public bool HasSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	public int CountSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	public TArray<UObject> GetSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	public UObject GetTopSelectedObject(UClass InRequiredClass/*=nullptr*/) { return default; }
	public UObject GetBottomSelectedObject(UClass InRequiredClass/*=nullptr*/) { return default; }
	public FTypedElementSelectionSetState GetCurrentSelectionState() { return default; }
	public void RestoreSelectionState(FTypedElementSelectionSetState InSelectionState) {}
	public bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FTypedElementIsSelectedOptions InSelectionOptions) { return default; }
	public bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool SelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool SelectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool DeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool DeselectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool SetSelection(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	public bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle) { return default; }
	public FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,ETypedElementSelectionMethod InSelectionMethod) { return default; }
	public TArray<FScriptTypedElementHandle> K2_GetSelectedElementHandles(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	public void FOnPreChangeDynamic(UObject SelectionSet) {}
	public FOnPreChangeDynamic OnPreSelectionChange;
	public void FOnChangeDynamic(UObject SelectionSet) {}
	public FOnChangeDynamic OnSelectionChange;
}
