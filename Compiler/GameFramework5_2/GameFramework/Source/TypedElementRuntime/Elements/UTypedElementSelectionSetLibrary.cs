#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementSelectionSetLibrary.h")]
///<summary>Library of functions for the scripting of Typed Elements that use both a selection set and a element list</summary>
public partial class UTypedElementSelectionSetLibrary : UObject {
// TypedElementSelectionSetLibrary
	public bool SelectElementsFromList(UObject SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public bool DeselectElementsFromList(UObject SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public bool SetSelectionFromList(UObject SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionOptions SelectionOptions) { return default; }
	public FScriptTypedElementListProxy GetNormalizedSelection(UObject SelectionSet,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
	public FScriptTypedElementListProxy GetNormalizedElementList(UObject SelectionSet,FScriptTypedElementListProxy ElementList,FTypedElementSelectionNormalizationOptions NormalizationOptions) { return default; }
}
