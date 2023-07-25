#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_GameplayTags.h")]
///<summary>EnvQueryTest_GameplayTags attempts to cast items to IGameplayTagAssetInterface and test their tags with TagQueryToMatch.</summary>
public partial class UEnvQueryTest_GameplayTags : UEnvQueryTest {
// EnvQueryTest_GameplayTags
	public FGameplayTagQuery TagQueryToMatch;
	public bool bRejectIncompatibleItems;
	public bool bUpdatedToUseQuery;
	public EGameplayContainerMatchType TagsToMatch;
	public FGameplayTagContainer GameplayTags;
}
