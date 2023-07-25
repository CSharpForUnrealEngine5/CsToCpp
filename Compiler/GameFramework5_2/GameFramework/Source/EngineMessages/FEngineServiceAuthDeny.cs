#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EngineServiceMessages.h")]
///<summary>Implements a message for denying service access to a remote user.</summary>
public partial struct FEngineServiceAuthDeny {
// EngineServiceAuthDeny
	public string UserName;
	public string UserToDeny;
}
