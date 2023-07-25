#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationDatabase.h")]
///<summary>There may be multiple databases with the same entrypoint tag, this struct holds</summary>
public partial struct FConversationEntryList {
// ConversationEntryList
	public FGameplayTag EntryTag;
	public TArray<FGuid> DestinationList;
}
