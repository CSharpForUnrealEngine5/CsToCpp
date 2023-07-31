#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for granting service access to a remote user.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceAuthGrant {
	public string UserName;
	public string UserToGrant;
}
