namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for granting service access to a remote user.</summary>
[CppInclude("EngineServiceMessages.h")]
public partial struct FEngineServiceAuthGrant {
	public string UserName;
	public string UserToGrant;
}
