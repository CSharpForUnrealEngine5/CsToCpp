namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Account/IPortalUser.h")]
///<summary>Used to delineate which cache an entitlement check result was retrieved from.</summary>
public enum EEntitlementCacheLevelRetrieved {
	None=0,
	Memory=1,
	Disk=2,
}
