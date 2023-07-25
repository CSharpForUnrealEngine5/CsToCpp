#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnitTest.h")]
///<summary>The verification status of the current unit test - normally its execution completes immediately after positive/negative verification</summary>
public enum EUnitTestVerification {
	Unverified=0,
	VerifiedNotFixed=1,
	VerifiedFixed=2,
	VerifiedNeedsUpdate=3,
	VerifiedUnreliable=4,
}
