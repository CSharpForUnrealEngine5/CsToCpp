namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MQTT Client Settings</summary>
[CppInclude("MQTTClientSettings.h")]
public partial class UMQTTClientSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultURL</summary>
	public FMQTTURL DefaultURL;
	///<summary>Maximum messages to publish per second.</summary>
	public uint PublishRate;
}
