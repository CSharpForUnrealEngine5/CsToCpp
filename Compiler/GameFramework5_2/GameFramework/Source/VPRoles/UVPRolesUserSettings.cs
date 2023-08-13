namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPRolesSettings.h")]
public partial class UVPRolesUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The machine role(s) in a virtual production context.</summary>
	public FGameplayTagContainer Roles;
	///<summary>The files that contain the available VP Roles.</summary>
	public TSet<string> RoleSources;
	///<summary>Cached available roles since the list isn&#39;t available outside of editor.</summary>
	public TArray<string> CachedRoles;
}
