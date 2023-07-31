#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineSessionClient.h")]
public partial class UOnlineSessionClient : UOnlineSession {
	///<summary>Is this join from an invite</summary>
	public bool bIsFromInvite;
	///<summary>Have we started returning to main menu already</summary>
	public bool bHandlingDisconnect;
}
