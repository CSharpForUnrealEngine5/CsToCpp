namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientMessage.h")]
public partial struct FMQTTClientMessage {
	public FDateTime TimeStamp;
	public string Topic;
	public TArray<byte> Payload;
	public bool bRetain;
	public EMQTTQualityOfService QoS;
	public string PayloadString;
}
