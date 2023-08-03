#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTClientObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FOnConnectDelegate</summary>
	public  void FOnConnectDelegate(EMQTTConnectReturnCode ReturnCode) {}
	///<summary>FOnDisconnectDelegate</summary>
	public  void FOnDisconnectDelegate() {}
	///<summary>FOnPublishDelegate</summary>
	public  void FOnPublishDelegate() {}
	///<summary>FOnSubscribeDelegate</summary>
	public  void FOnSubscribeDelegate(EMQTTSubscribeReturnCode ReturnCode) {}
	///<summary>FOnUnsubscribeDelegate</summary>
	public  void FOnUnsubscribeDelegate() {}
	///<summary>FOnMessageDelegate</summary>
	public  void FOnMessageDelegate(FMQTTClientMessage Message) {}
	///<summary>Connect</summary>
	public  void Connect(FOnConnectDelegate InOnConnect) {}
	///<summary>Disconnect</summary>
	public  void Disconnect(FOnDisconnectDelegate InOnDisconnect) {}
	///<summary>OutMessageId can be used to match this request with the callback response.</summary>
	public  void Publish(string InTopic,TArray<byte> InPayload,EMQTTQualityOfService InQoS/*=EMQTTQualityOfService.Once*/,bool bInRetain/*=false*/) {}
	///<summary>OutMessageId can be used to match this request with the callback response.</summary>
	public  UMQTTSubscriptionObject Subscribe(string InTopic,EMQTTQualityOfService InQoS/*=EMQTTQualityOfService.Once*/) { return default; }
	///<summary>OutMessageId can be used to match this request with the callback response.</summary>
	public  TArray<UMQTTSubscriptionObject> SubscribeMany(TArray<string> InTopics,TArray<EMQTTQualityOfService> InQoS) { return default; }
	///<summary>OutMessageId can be used to match this request with the callback response.</summary>
	public  void Unsubscribe(string InTopic) {}
	///<summary>GetClientId</summary>
	public  string GetClientId() { return default; }
	///<summary>URL for this client.</summary>
	public  FMQTTURL GetURL() { return default; }
	///<summary>OnConnectDelegate</summary>
	public FOnConnectDelegate OnConnectDelegate;
	///<summary>OnDisconnectDelegate</summary>
	public FOnDisconnectDelegate OnDisconnectDelegate;
	///<summary>OnMessageDelegate</summary>
	public FOnMessageDelegate OnMessageDelegate;
	///<summary>Subscriptions</summary>
	public TArray<UMQTTSubscriptionObject> Subscriptions;
}
