#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCServer.h")]
public partial class UOSCServer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets whether or not to loopback if ReceiveIPAddress provided is multicast.</summary>
	public  bool GetMulticastLoopback() { return default; }
	///<summary>Returns whether server is actively listening to incoming messages.</summary>
	public  bool IsActive() { return default; }
	///<summary>Sets the IP address and port to listen for OSC data.</summary>
	public  void Listen() {}
	///<summary>Set the address and port of server. Fails if server is currently active.</summary>
	public  bool SetAddress(string ReceiveIPAddress,int Port) { return default; }
	///<summary>Set whether or not to loopback if ReceiveIPAddress provided is multicast.</summary>
	public  void SetMulticastLoopback(bool bMulticastLoopback) {}
	///<summary>Stop and tidy up network socket.</summary>
	public  void Stop() {}
	///<summary>Event that gets called when an OSC message is received.</summary>
	public FOSCReceivedMessageEvent OnOscMessageReceived;
	///<summary>Event that gets called when an OSC bundle is received.</summary>
	public FOSCReceivedBundleEvent OnOscBundleReceived;
	///<summary>When set to true, server will only process received</summary>
	public  void SetAllowlistClientsEnabled(bool bEnabled) {}
	///<summary>Adds client to allowlist of clients to listen for.</summary>
	public  void AddAllowlistedClient(string IPAddress) {}
	///<summary>Removes allowlisted client to listen for.</summary>
	public  void RemoveAllowlistedClient(string IPAddress) {}
	///<summary>Clears client allowlist to listen for.</summary>
	public  void ClearAllowlistedClients() {}
	///<summary>Returns the IP for the server if connected as a string.</summary>
	public  string GetIpAddress(bool bIncludePort) { return default; }
	///<summary>Returns the port for the server if connected.</summary>
	public  int GetPort() { return default; }
	///<summary>Returns set of allowlisted clients.</summary>
	public  TSet<string> GetAllowlistedClients() { return default; }
	///<summary>Adds event to dispatch when OSCAddressPattern is matched.</summary>
	public  void BindEventToOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	///<summary>Unbinds specific event from OSCAddress pattern.</summary>
	public  void UnbindEventFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	///<summary>Removes OSCAddressPattern from sending dispatch events.</summary>
	public  void UnbindAllEventsFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern) {}
	///<summary>Removes all events from OSCAddressPatterns to dispatch.</summary>
	public  void UnbindAllEventsFromOnOSCAddressPatternMatching() {}
	///<summary>Returns set of OSCAddressPatterns currently listening for matches to dispatch.</summary>
	public  TArray<FOSCAddress> GetBoundOSCAddressPatterns() { return default; }
	///<summary>Set whether server instance can be ticked in-editor (editor only and available to blueprint</summary>
	public  void SetTickInEditor(bool bInTickInEditor) {}
}
