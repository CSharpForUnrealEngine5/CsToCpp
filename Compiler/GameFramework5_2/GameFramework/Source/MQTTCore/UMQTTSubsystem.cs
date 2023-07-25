#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTSubsystem.h")]
///<summary>Provides persistent access to clients</summary>
public partial class UMQTTSubsystem : UEngineSubsystem {
// MQTTSubsystem
	public UObject GetOrCreateClient_WithProjectURL(UObject InParent) { return default; }
	public UObject GetOrCreateClient(UObject InParent,FMQTTURL InURL) { return default; }
	public string GetPayloadString(FMQTTClientMessage InClientMessage) { return default; }
	public bool GetPayloadJson(UObject InParent,FMQTTClientMessage InClientMessage,FJsonObjectWrapper OutJson) { return default; }
	public TMap<FGuid,UMQTTClientObject> Clients;
}
