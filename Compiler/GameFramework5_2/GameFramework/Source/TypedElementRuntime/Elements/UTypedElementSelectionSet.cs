#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper around an element list that ensures mutation goes via the selection</summary>
[CppInclude("Elements/Framework/TypedElementSelectionSet.h")]
public partial class UTypedElementSelectionSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Clear the current selection.</summary>
	public  bool ClearSelection(FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Get the number of selected elements.</summary>
	public  int GetNumSelectedElements() { return default; }
	///<summary>Test whether there selected elements, optionally filtering to elements that implement the given interface.</summary>
	public  bool HasSelectedElements(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	///<summary>Count the number of selected elements, optionally filtering to elements that implement the given interface.</summary>
	public  int CountSelectedElements(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	///<summary>Test whether there are any selected objects.</summary>
	public  bool HasSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	///<summary>Count the number of selected objects.</summary>
	public  int CountSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	///<summary>Get the array of selected objects from the currently selected elements.</summary>
	public  TArray<UObject> GetSelectedObjects(UClass InRequiredClass/*=nullptr*/) { return default; }
	///<summary>Get the first selected object of the given type.</summary>
	public  UObject GetTopSelectedObject(UClass InRequiredClass/*=nullptr*/) { return default; }
	///<summary>Get the last selected object of the given type.</summary>
	public  UObject GetBottomSelectedObject(UClass InRequiredClass/*=nullptr*/) { return default; }
	///<summary>Serializes the current selection set.</summary>
	public  FTypedElementSelectionSetState GetCurrentSelectionState() { return default; }
	///<summary>Restores the selection set from the given state.</summary>
	public  void RestoreSelectionState(FTypedElementSelectionSetState InSelectionState) {}
	///<summary>Test to see whether the given element is currently considered selected.</summary>
	public  bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FTypedElementIsSelectedOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be selected.</summary>
	public  bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be deselected.</summary>
	public  bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to select the given element.</summary>
	public  bool SelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to select the given elements.</summary>
	public  bool SelectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to deselect the given element.</summary>
	public  bool DeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to deselect the given elements.</summary>
	public  bool DeselectElements(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to make the selection the given elements.</summary>
	public  bool SetSelection(TArray<FScriptTypedElementHandle> InElementHandles,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether selection modifiers (Ctrl or Shift) are allowed while selecting this element.</summary>
	public  bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Given an element, return the element that should actually perform a selection operation.</summary>
	public  FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,ETypedElementSelectionMethod InSelectionMethod) { return default; }
	///<summary>Get the handle of every selected element, optionally filtering to elements that implement the given interface.</summary>
	public  TArray<FScriptTypedElementHandle> K2_GetSelectedElementHandles(UClass InBaseInterfaceType/*=nullptr*/) { return default; }
	///<summary>FOnPreChangeDynamic</summary>
	public  void FOnPreChangeDynamic(UTypedElementSelectionSet SelectionSet) {}
	///<summary>Delegate that is invoked whenever the underlying element list is potentially about to change.</summary>
	public FOnPreChangeDynamic OnPreSelectionChange;
	///<summary>FOnChangeDynamic</summary>
	public  void FOnChangeDynamic(UTypedElementSelectionSet SelectionSet) {}
	///<summary>Delegate that is invoked whenever the underlying element list has been changed.</summary>
	public FOnChangeDynamic OnSelectionChange;
}
