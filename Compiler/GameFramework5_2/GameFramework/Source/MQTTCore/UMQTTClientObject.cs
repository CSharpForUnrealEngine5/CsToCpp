#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTClientObject : UObject {
// MQTTClientObject
	public  void FOnConnectDelegate(EMQTTConnectReturnCode ReturnCode) {}
	public  void FOnDisconnectDelegate() {}
	public  void FOnPublishDelegate() {}
	public  void FOnSubscribeDelegate(EMQTTSubscribeReturnCode ReturnCode) {}
	public  void FOnUnsubscribeDelegate() {}
	public  void FOnMessageDelegate(FMQTTClientMessage Message) {}
	public  void Connect(FOnConnectDelegate InOnConnect) {}
	public  void Disconnect(FOnDisconnectDelegate InOnDisconnect) {}
	public  void Publish(string InTopic,TArray<byte> InPayload,EMQTTQualityOfService InQoS/*=EMQTTQualityOfService.Once*/,bool bInRetain/*=false*/) {}
	public  UMQTTSubscriptionObject Subscribe(string InTopic,EMQTTQualityOfService InQoS/*=EMQTTQualityOfService.Once*/) { return default; }
	public  TArray<UMQTTSubscriptionObject> SubscribeMany(TArray<string> InTopics,TArray<EMQTTQualityOfService> InQoS) { return default; }
	public  void Unsubscribe(string InTopic) {}
	public  string GetClientId() { return default; }
	public  FMQTTURL GetURL() { return default; }
	public FOnConnectDelegate OnConnectDelegate;
	public FOnDisconnectDelegate OnDisconnectDelegate;
	public FOnMessageDelegate OnMessageDelegate;
	public TArray<UMQTTSubscriptionObject> Subscriptions;
}
