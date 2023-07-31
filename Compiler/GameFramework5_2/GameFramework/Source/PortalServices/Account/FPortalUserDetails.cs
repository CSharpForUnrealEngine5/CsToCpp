#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The basic data for the last or currently signed-in user.</summary>
[CppInclude("Account/IPortalUser.h")]
public partial struct FPortalUserDetails {
	public string DisplayName;
	public string Email;
	public string RealName;
	public bool IsSignedIn;
}
