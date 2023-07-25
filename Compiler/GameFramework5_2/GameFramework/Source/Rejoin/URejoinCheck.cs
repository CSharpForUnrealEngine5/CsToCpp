#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RejoinCheck.h")]
///<summary>Class responsible for maintaining the status/availability of a session already in progress for a client to join</summary>
public partial class URejoinCheck : UObject {
// RejoinCheck
	public ERejoinStatus LastKnownStatus;
	public bool bRejoinAfterCheck;
	public bool bAttemptingRejoin;
}
