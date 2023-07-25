#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTagContainer.h")]
///<summary>An FGameplayTagQuery is a logical query that can be run against an FGameplayTagContainer.  A query that succeeds is said to "match".</summary>
public partial struct FGameplayTagQuery {
// GameplayTagQuery
	public int TokenStreamVersion;
	public TArray<FGameplayTag> TagDictionary;
	public TArray<byte> QueryTokenStream;
	public string UserDescription;
	public string AutoDescription;
}
