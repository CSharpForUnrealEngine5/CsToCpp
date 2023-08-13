namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeaconClient.h")]
///<summary>State of a connection.</summary>
public enum EBeaconConnectionState {
	Invalid=0,
	Closed=1,
	Pending=2,
	Open=3,
}
