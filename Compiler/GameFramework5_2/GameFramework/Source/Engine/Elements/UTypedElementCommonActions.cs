#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementCommonActions.h")]
///<summary>A utility to handle higher-level common actions, but default via UTypedElementWorldInterface,</summary>
public partial class UTypedElementCommonActions : UObject {
// TypedElementCommonActions
	public  bool DeleteSelectedElements(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementDeletionOptions DeletionOptions) { return default; }
	public  bool CopySelectedElements(UTypedElementSelectionSet SelectionSet) { return default; }
	public  bool CopySelectedElementsToString(UTypedElementSelectionSet SelectionSet,string OutputString) { return default; }
	public  bool DeleteNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,UTypedElementSelectionSet InSelectionSet,FTypedElementDeletionOptions DeletionOptions) { return default; }
	public  TArray<FScriptTypedElementHandle> K2_DuplicateSelectedElements(UTypedElementSelectionSet SelectionSet,UWorld World,FVector LocationOffset) { return default; }
	public  TArray<FScriptTypedElementHandle> DuplicateNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,FVector LocationOffset) { return default; }
	public  bool CopyNormalizedElements(FScriptTypedElementListProxy ElementList) { return default; }
	public  bool CopyNormalizedElementsToString(FScriptTypedElementListProxy ElementList,string OutputString) { return default; }
	public  TArray<FScriptTypedElementHandle> K2_PasteElements(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementPasteOptions PasteOption) { return default; }
	public  TArray<FScriptTypedElementHandle> PasteElementsFromString(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
	public  TArray<FScriptTypedElementHandle> K2_PasteNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,FTypedElementPasteOptions PasteOption) { return default; }
	public  TArray<FScriptTypedElementHandle> PasteNormalizedElementsFromString(FScriptTypedElementListProxy ElementList,UWorld World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
}
