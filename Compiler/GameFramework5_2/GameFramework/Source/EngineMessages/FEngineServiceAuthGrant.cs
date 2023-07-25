#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EngineServiceMessages.h")]
///<summary>Implements a message for granting service access to a remote user.</summary>
public partial struct FEngineServiceAuthGrant {
// EngineServiceAuthGrant
	public string UserName;
	public string UserToGrant;
}
