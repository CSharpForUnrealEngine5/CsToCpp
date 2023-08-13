namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Account/IPortalUser.h")]
public partial struct FPortalUserIsEntitledToItemResult {
	public string ItemId;
	public bool IsEntitled;
	public EEntitlementCacheLevelRetrieved RetrievedFromCacheLevel;
}
