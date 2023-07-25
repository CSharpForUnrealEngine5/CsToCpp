#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTSubscriptionObject : UObject {
// MQTTSubscriptionObject
	public void FOnMessageDelegate(FMQTTClientMessage Message) {}
	public void SetOnMessageHandler(FOnMessageDelegate OnMessageCallback) {}
	public bool IsValid() { return default; }
	public FOnMessageDelegate OnMessageDelegate;
}
