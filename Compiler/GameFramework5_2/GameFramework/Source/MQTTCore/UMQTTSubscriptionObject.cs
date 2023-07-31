#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTSubscriptionObject : UObject {
	///<summary>FOnMessageDelegate</summary>
	public  void FOnMessageDelegate(FMQTTClientMessage Message) {}
	///<summary>SetOnMessageHandler</summary>
	public  void SetOnMessageHandler(FOnMessageDelegate OnMessageCallback) {}
	///<summary>IsValid</summary>
	public  bool IsValid() { return default; }
	///<summary>OnMessageDelegate</summary>
	public FOnMessageDelegate OnMessageDelegate;
}
