#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCServer.h")]
public partial class UOSCServer : UObject {
// OSCServer
	public bool GetMulticastLoopback() { return default; }
	public bool IsActive() { return default; }
	public void Listen() {}
	public bool SetAddress(string ReceiveIPAddress,int Port) { return default; }
	public void SetMulticastLoopback(bool bMulticastLoopback) {}
	public void Stop() {}
	public FOSCReceivedMessageEvent OnOscMessageReceived;
	public FOSCReceivedBundleEvent OnOscBundleReceived;
	public void SetAllowlistClientsEnabled(bool bEnabled) {}
	public void AddAllowlistedClient(string IPAddress) {}
	public void RemoveAllowlistedClient(string IPAddress) {}
	public void ClearAllowlistedClients() {}
	public string GetIpAddress(bool bIncludePort) { return default; }
	public int GetPort() { return default; }
	public TSet<string> GetAllowlistedClients() { return default; }
	public void BindEventToOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	public void UnbindEventFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	public void UnbindAllEventsFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern) {}
	public void UnbindAllEventsFromOnOSCAddressPatternMatching() {}
	public TArray<FOSCAddress> GetBoundOSCAddressPatterns() { return default; }
	public void SetTickInEditor(bool bInTickInEditor) {}
}
