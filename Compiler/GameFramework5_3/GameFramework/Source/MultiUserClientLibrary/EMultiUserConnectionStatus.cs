namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
///<summary>Connection status for Multi-User client sessions</summary>
public enum EMultiUserConnectionStatus {
	Connecting=0,
	Connected=1,
	Disconnecting=2,
	Disconnected=3,
}
