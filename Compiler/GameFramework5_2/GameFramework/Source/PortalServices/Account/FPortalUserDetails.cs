namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The basic data for the last or currently signed-in user.</summary>
[CppInclude("Account/IPortalUser.h")]
public partial struct FPortalUserDetails {
	public FText DisplayName;
	public FText Email;
	public FText RealName;
	public bool IsSignedIn;
}
