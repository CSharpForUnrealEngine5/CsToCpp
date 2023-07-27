#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementSelectionSetLibrary.h")]
///<summary>Library of functions for the scripting of Typed Elements that use both a selection set and a element list</summary>
public partial class UTypedElementSelectionSetLibrary : UObject {
// TypedElementSelectionSetLibrary
	public static bool SelectElementsFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public static bool DeselectElementsFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public static bool SetSelectionFromList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public static FScriptTypedElementListProxy GetNormalizedSelection(UTypedElementSelectionSet SelectionSet,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
	public static FScriptTypedElementListProxy GetNormalizedElementList(UTypedElementSelectionSet SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
}
