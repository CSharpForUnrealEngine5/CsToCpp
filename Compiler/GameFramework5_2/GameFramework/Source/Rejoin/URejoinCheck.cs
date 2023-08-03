#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class responsible for maintaining the status/availability of a session already in progress for a client to join</summary>
[CppInclude("RejoinCheck.h")]
public partial class URejoinCheck : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Rejoin status</summary>
	public ERejoinStatus LastKnownStatus;
	///<summary>Flag set during a possible brief period where the user hit rejoin but the check was already in flight</summary>
	public bool bRejoinAfterCheck;
	///<summary>Is a rejoin attempt in progress, prevents reentry</summary>
	public bool bAttemptingRejoin;
}
