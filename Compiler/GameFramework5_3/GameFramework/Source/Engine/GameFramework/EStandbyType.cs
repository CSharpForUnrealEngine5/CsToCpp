namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameNetworkManager.h")]
///<summary>Describes which standby detection event occured so the game can take appropriate action.</summary>
public enum EStandbyType {
	STDBY_Rx=0,
	STDBY_Tx=1,
	STDBY_BadPing=2,
	STDBY_MAX=3,
}
