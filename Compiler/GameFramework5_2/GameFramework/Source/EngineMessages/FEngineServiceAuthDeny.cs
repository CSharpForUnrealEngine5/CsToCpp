#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for denying service access to a remote user.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceAuthDeny {
	public string UserName;
	public string UserToDeny;
}
