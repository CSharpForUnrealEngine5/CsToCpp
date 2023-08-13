namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTClientObject.h")]
public partial class UMQTTSubscriptionObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FOnMessageDelegate</summary>
	public void FOnMessageDelegate(FMQTTClientMessage Message) {}
	///<summary>SetOnMessageHandler</summary>
	public void SetOnMessageHandler(FOnMessageDelegate OnMessageCallback) {}
	///<summary>IsValid</summary>
	public bool IsValid() { return default; }
	///<summary>OnMessageDelegate</summary>
	public FOnMessageDelegate OnMessageDelegate;
}
