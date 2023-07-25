#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementCommonActions.h")]
///<summary>A utility to handle higher-level common actions, but default via UTypedElementWorldInterface,</summary>
public partial class UTypedElementCommonActions : UObject {
// TypedElementCommonActions
	public bool DeleteSelectedElements(UObject SelectionSet,UObject World,FTypedElementDeletionOptions DeletionOptions) { return default; }
	public bool CopySelectedElements(UObject SelectionSet) { return default; }
	public bool CopySelectedElementsToString(UObject SelectionSet,string OutputString) { return default; }
	public bool DeleteNormalizedElements(FScriptTypedElementListProxy ElementList,UObject World,UObject InSelectionSet,FTypedElementDeletionOptions DeletionOptions) { return default; }
	public TArray<FScriptTypedElementHandle> K2_DuplicateSelectedElements(UObject SelectionSet,UObject World,FVector LocationOffset) { return default; }
	public TArray<FScriptTypedElementHandle> DuplicateNormalizedElements(FScriptTypedElementListProxy ElementList,UObject World,FVector LocationOffset) { return default; }
	public bool CopyNormalizedElements(FScriptTypedElementListProxy ElementList) { return default; }
	public bool CopyNormalizedElementsToString(FScriptTypedElementListProxy ElementList,string OutputString) { return default; }
	public TArray<FScriptTypedElementHandle> K2_PasteElements(UObject SelectionSet,UObject World,FTypedElementPasteOptions PasteOption) { return default; }
	public TArray<FScriptTypedElementHandle> PasteElementsFromString(UObject SelectionSet,UObject World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
	public TArray<FScriptTypedElementHandle> K2_PasteNormalizedElements(FScriptTypedElementListProxy ElementList,UObject World,FTypedElementPasteOptions PasteOption) { return default; }
	public TArray<FScriptTypedElementHandle> PasteNormalizedElementsFromString(FScriptTypedElementListProxy ElementList,UObject World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
}
