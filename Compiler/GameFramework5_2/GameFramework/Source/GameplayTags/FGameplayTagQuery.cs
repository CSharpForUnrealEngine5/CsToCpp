#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An FGameplayTagQuery is a logical query that can be run against an FGameplayTagContainer.  A query that succeeds is said to &quot;match&quot;.</summary>
[CppInclude("GameplayTagContainer.h")]
public partial struct FGameplayTagQuery {
	public int TokenStreamVersion;
	public TArray<FGameplayTag> TagDictionary;
	public TArray<byte> QueryTokenStream;
	public string UserDescription;
	public string AutoDescription;
}
