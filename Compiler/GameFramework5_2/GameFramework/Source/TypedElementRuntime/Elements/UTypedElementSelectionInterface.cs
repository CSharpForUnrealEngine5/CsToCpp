namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementSelectionInterface.h")]
public partial class UTypedElementSelectionInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Test to see whether the given element is currently considered selected.</summary>
	public virtual bool IsElementSelected(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementIsSelectedOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be selected.</summary>
	public virtual bool CanSelectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether the given element can be deselected.</summary>
	public virtual bool CanDeselectElement(FScriptTypedElementHandle InElementHandle,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to select the given element.</summary>
	public virtual bool SelectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Attempt to deselect the given element.</summary>
	public virtual bool DeselectElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet,FTypedElementSelectionOptions InSelectionOptions) { return default; }
	///<summary>Test to see whether selection modifiers (Ctrl or Shift) are allowed while selecting this element.</summary>
	public virtual bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InSelectionSet) { return default; }
	///<summary>Given an element, return the element that should actually perform a selection operation.</summary>
	public virtual FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle,FScriptTypedElementListProxy InCurrentSelection,ETypedElementSelectionMethod InSelectionMethod) { return default; }
}
