#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>There may be multiple databases with the same entrypoint tag, this struct holds</summary>
[CppInclude("ConversationDatabase.h")]
public partial struct FConversationEntryList {
	public FGameplayTag EntryTag;
	public TArray<FGuid> DestinationList;
}
