namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem for common Virtual Production roles operations.</summary>
[CppInclude("VPRolesSubsystem.h")]
public partial class UVirtualProductionRolesSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>FOnRolesChanged</summary>
	public void FOnRolesChanged(TArray<string> EnabledRoles) {}
	///<summary>Get the currently active Virtual Production roles.</summary>
	public TArray<string> GetActiveRoles() { return default; }
	///<summary>@return Whether a role is currently active.</summary>
	public bool HasActiveRole(string Role) { return default; }
	///<summary>@return the currently active Virtual Production roles as a comma separated string representation.</summary>
	public string GetActiveRolesString() { return default; }
	///<summary>Set the current Virtual Production roles.</summary>
	public void SetActiveRoles(TArray<string> Roles) {}
	///<summary>Get all available roles that can be set as current.</summary>
	public TArray<string> GetAllRoles() { return default; }
	///<summary>Add a new virtual production role.</summary>
	public bool AddRole(string RoleName) { return default; }
	///<summary>Remove a virtual production role.</summary>
	public bool RemoveRole(string RoleName) { return default; }
	///<summary>Delegate called when the roles are modified, ie. role is added, current roles are replaced, etc.</summary>
	public FOnRolesChanged OnRolesChangedBP;
}
