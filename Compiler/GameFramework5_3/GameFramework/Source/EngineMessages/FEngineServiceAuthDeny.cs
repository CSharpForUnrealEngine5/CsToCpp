namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for denying service access to a remote user.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceAuthDeny {
	public string UserName;
	public string UserToDeny;
}
