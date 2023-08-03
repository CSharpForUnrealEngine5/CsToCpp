#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCClient.h")]
public partial class UOSCClient : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the OSC Client IP address and port.</summary>
	public  void GetSendIPAddress(string IPAddress,int Port) {}
	///<summary>Sets the OSC Client IP address and port. Returns whether</summary>
	public  bool SetSendIPAddress(string IPAddress,int Port) { return default; }
	///<summary>Send OSC message to  a specific address.</summary>
	public  void SendOSCMessage(FOSCMessage Message) {}
	///<summary>Send OSC Bundle over the network.</summary>
	public  void SendOSCBundle(FOSCBundle Bundle) {}
}
