#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationDatabase.h")]
///<summary>/</summary>
public partial class UConversationDatabase : UPrimaryDataAsset {
// ConversationDatabase
	public int CompilerVersion;
	public TMap<FGuid,UConversationNode> ReachableNodeMap;
	public TArray<FConversationEntryList> EntryTags;
	public FGameplayTagContainer ExitTags;
	public TArray<FGuid> InternalNodeIds;
	public TArray<FGuid> LinkedToNodeIds;
	public TArray<FCommonDialogueBankParticipant> Speakers;
	public TMap<FGuid,UConversationNode> FullNodeMap;
	public TArray<UEdGraph> SourceGraphs;
	public TArray<FEditedDocumentInfo> LastEditedDocuments;
}
