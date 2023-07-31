#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions for the scripting of Typed Elements that use both a selection set and a element list</summary>
[CppInclude("Elements/Framework/TypedElementSelectionSetLibrary.h")]
public partial class UTypedElementSelectionSetLibrary : UObject {
	///<summary>Attempt to select the given elements.</summary>
	public static bool SelectElementsFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	///<summary>Attempt to deselect the given elements.</summary>
	public static bool DeselectElementsFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	///<summary>Attempt to make the selection the given elements.</summary>
	public static bool SetSelectionFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	///<summary>Get a normalized version of this selection set that can be used to perform operations like gizmo manipulation, deletion, copying, etc.</summary>
	public static FScriptTypedElementListProxy GetNormalizedSelection(UTypedElementSelectionSet SelectionSet,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
	///<summary>Get a normalized version of the given element list that can be used to perform operations like gizmo manipulation, deletion, copying, etc.</summary>
	public static FScriptTypedElementListProxy GetNormalizedElementList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
}
