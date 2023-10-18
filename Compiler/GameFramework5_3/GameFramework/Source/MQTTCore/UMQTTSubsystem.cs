namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides persistent access to clients</summary>
[CppInclude("MQTTSubsystem.h")]
public partial class UMQTTSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GetOrCreateClient_WithProjectURL</summary>
	public static UMQTTClientObject GetOrCreateClient_WithProjectURL(UObject InParent) { return default; }
	///<summary>GetOrCreateClient</summary>
	public static UMQTTClientObject GetOrCreateClient(UObject InParent,FMQTTURL InURL) { return default; }
	///<summary>GetPayloadString</summary>
	public static string GetPayloadString(FMQTTClientMessage InClientMessage) { return default; }
	///<summary>GetPayloadJson</summary>
	public static bool GetPayloadJson(UObject InParent,FMQTTClientMessage InClientMessage,FJsonObjectWrapper OutJson) { return default; }
	///<summary>Clients</summary>
	public TMap<FGuid,UMQTTClientObject> Clients;
}
