#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementSelectionInterface.h")]
public partial class UTypedElementSelectionInterface : UInterface {
	///<summary>Test to see whether the given element is currently considered selected.</summary>
	public  bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementIsSelectedOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be selected.</summary>
	public  bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be deselected.</summary>
	public  bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to select the given element.</summary>
	public  bool SelectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to deselect the given element.</summary>
	public  bool DeselectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether selection modifiers (Ctrl or Shift) are allowed while selecting this element.</summary>
	public  bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet) { return default; }
	///<summary>Given an element, return the element that should actually perform a selection operation.</summary>
	public  FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InCurrentSelection,ETypedElementSelectionMethod InSelectionMethod) { return default; }
}
