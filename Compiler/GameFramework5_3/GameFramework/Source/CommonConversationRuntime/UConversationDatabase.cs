namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>/</summary>
[CppInclude("ConversationDatabase.h")]
public partial class UConversationDatabase : UPrimaryDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Compiled: Entry points</summary>
	public int CompilerVersion;
	///<summary>Compiled: Reachable nodes</summary>
	public TMap<FGuid,UConversationNode> ReachableNodeMap;
	///<summary>Compiled: Entry points</summary>
	public TArray<FConversationEntryList> EntryTags;
	///<summary>Compiled:</summary>
	public FGameplayTagContainer ExitTags;
	///<summary>Compiled:</summary>
	public TArray<FGuid> InternalNodeIds;
	///<summary>Compiled:</summary>
	public TArray<FGuid> LinkedToNodeIds;
	///<summary>List of participant slots</summary>
	public TArray<FCommonDialogueBankParticipant> Speakers;
	///<summary>All nodes</summary>
	public TMap<FGuid,UConversationNode> FullNodeMap;
	///<summary>&#39;Source code&#39; graphs (of type UConversationGraph)</summary>
	public TArray<UEdGraph> SourceGraphs;
	///<summary>Info about the graphs we last edited</summary>
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
}
