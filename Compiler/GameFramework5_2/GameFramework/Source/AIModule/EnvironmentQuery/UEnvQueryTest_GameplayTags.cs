#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>EnvQueryTest_GameplayTags attempts to cast items to IGameplayTagAssetInterface and test their tags with TagQueryToMatch.</summary>
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_GameplayTags.h")]
public partial class UEnvQueryTest_GameplayTags : UEnvQueryTest {
	public static UClass StaticClass() {return default;}
	///<summary>TagQueryToMatch</summary>
	public FGameplayTagQuery TagQueryToMatch;
	///<summary>This controls how to treat actors that do not implement IGameplayTagAssetInterface.</summary>
	public bool bRejectIncompatibleItems;
	///<summary>Used to determine whether the file format needs to be updated to move data into TagQueryToMatch or not.</summary>
	public bool bUpdatedToUseQuery;
	///<summary>Deprecated property.  Used only to load old data into TagQueryToMatch.</summary>
	public EGameplayContainerMatchType TagsToMatch;
	///<summary>Deprecated property.  Used only to load old data into TagQueryToMatch.</summary>
	public FGameplayTagContainer GameplayTags;
}
