#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Connection status for Concert client sessions</summary>
public enum EConcertConnectionStatus {
	Connecting=0,
	Connected=1,
	Disconnecting=2,
	Disconnected=3,
}
