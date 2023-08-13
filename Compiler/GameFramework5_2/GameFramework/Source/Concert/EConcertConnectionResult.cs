namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Connection Result for Concert client session</summary>
public enum EConcertConnectionResult {
	None=0,
	ConnectionAccepted=1,
	ConnectionRefused=2,
	AlreadyConnected=3,
}
