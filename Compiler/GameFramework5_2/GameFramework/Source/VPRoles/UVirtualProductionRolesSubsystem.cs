#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPRolesSubsystem.h")]
///<summary>Subsystem for common Virtual Production roles operations.</summary>
public partial class UVirtualProductionRolesSubsystem : UEngineSubsystem {
// VirtualProductionRolesSubsystem
	public  void FOnRolesChanged(TArray<string> EnabledRoles) {}
	public  TArray<string> GetActiveRoles() { return default; }
	public  bool HasActiveRole(string Role) { return default; }
	public  string GetActiveRolesString() { return default; }
	public  void SetActiveRoles(TArray<string> Roles) {}
	public  TArray<string> GetAllRoles() { return default; }
	public  bool AddRole(string RoleName) { return default; }
	public  bool RemoveRole(string RoleName) { return default; }
	public FOnRolesChanged OnRolesChangedBP;
}
