#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTSubsystem.h")]
///<summary>Provides persistent access to clients</summary>
public partial class UMQTTSubsystem : UEngineSubsystem {
// MQTTSubsystem
	public static UMQTTClientObject GetOrCreateClient_WithProjectURL(UObject InParent) { return default; }
	public static UMQTTClientObject GetOrCreateClient(UObject InParent,FMQTTURL InURL) { return default; }
	public static string GetPayloadString(FMQTTClientMessage InClientMessage) { return default; }
	public static bool GetPayloadJson(UObject InParent,FMQTTClientMessage InClientMessage,FJsonObjectWrapper OutJson) { return default; }
	public TMap<FGuid,UMQTTClientObject> Clients;
}
