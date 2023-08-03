#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A utility to handle higher-level common actions, but default via UTypedElementWorldInterface,</summary>
[CppInclude("Elements/Framework/TypedElementCommonActions.h")]
public partial class UTypedElementCommonActions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Delete any elements from the given selection set that can be deleted.</summary>
	public  bool DeleteSelectedElements(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementDeletionOptions DeletionOptions) { return default; }
	///<summary>Copy any elements from the given selection set that can be copied into the clipboard</summary>
	public  bool CopySelectedElements(UTypedElementSelectionSet SelectionSet) { return default; }
	///<summary>Copy any elements from the given selection set that can be copied into the string</summary>
	public  bool CopySelectedElementsToString(UTypedElementSelectionSet SelectionSet,string OutputString) { return default; }
	///<summary>Delete any elements from the given list that can be deleted.</summary>
	public  bool DeleteNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,UTypedElementSelectionSet InSelectionSet,FTypedElementDeletionOptions DeletionOptions) { return default; }
	///<summary>Duplicate any elements from the given selection set that can be duplicated.</summary>
	public  TArray<FScriptTypedElementHandle> K2_DuplicateSelectedElements(UTypedElementSelectionSet SelectionSet,UWorld World,FVector LocationOffset) { return default; }
	///<summary>Duplicate any elements from the given list that can be duplicated.</summary>
	public  TArray<FScriptTypedElementHandle> DuplicateNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,FVector LocationOffset) { return default; }
	///<summary>* Copy any elements from the given selection set that can be copied into the clipboard.</summary>
	public  bool CopyNormalizedElements(FScriptTypedElementListProxy ElementList) { return default; }
	///<summary>* Copy any elements from the given selection set that can be copied into the clipboard.</summary>
	public  bool CopyNormalizedElementsToString(FScriptTypedElementListProxy ElementList,string OutputString) { return default; }
	///<summary>Paste any elements from the clipboard</summary>
	public  TArray<FScriptTypedElementHandle> K2_PasteElements(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementPasteOptions PasteOption) { return default; }
	///<summary>Paste any elements from the given string</summary>
	public  TArray<FScriptTypedElementHandle> PasteElementsFromString(UTypedElementSelectionSet SelectionSet,UWorld World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
	///<summary>Paste any elements from the clipboard</summary>
	public  TArray<FScriptTypedElementHandle> K2_PasteNormalizedElements(FScriptTypedElementListProxy ElementList,UWorld World,FTypedElementPasteOptions PasteOption) { return default; }
	///<summary>Paste any elements from the given string</summary>
	public  TArray<FScriptTypedElementHandle> PasteNormalizedElementsFromString(FScriptTypedElementListProxy ElementList,UWorld World,FTypedElementPasteOptions PasteOption,string InputString) { return default; }
}
