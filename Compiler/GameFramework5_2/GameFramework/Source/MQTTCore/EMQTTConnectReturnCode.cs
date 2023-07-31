#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTProtocol.h")]
///<summary>MQTT v3.1.1</summary>
public enum EMQTTConnectReturnCode {
	Accepted=-1,
	RefusedProtocolVersion=-1,
	RefusedIdentifierRejected=-1,
	RefusedServerUnavailable=-1,
	RefusedBadUsernamePassword=-1,
	RefusedNotAuthorized=-1,
	AlreadyConnected=-1,
	InvalidURL=-1,
	SocketError=-1,
}
