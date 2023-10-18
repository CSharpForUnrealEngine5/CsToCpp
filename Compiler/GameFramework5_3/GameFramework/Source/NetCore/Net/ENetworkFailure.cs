namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Core/Connection/NetEnums.h")]
///<summary>Types of network failures broadcast from the engine</summary>
[CppEnumInNamespace]
public enum ENetworkFailure {
	NetDriverAlreadyExists=0,
	NetDriverCreateFailure=1,
	NetDriverListenFailure=2,
	ConnectionLost=3,
	ConnectionTimeout=4,
	FailureReceived=5,
	OutdatedClient=6,
	OutdatedServer=7,
	PendingConnectionFailure=8,
	NetGuidMismatch=9,
	NetChecksumMismatch=10,
}
