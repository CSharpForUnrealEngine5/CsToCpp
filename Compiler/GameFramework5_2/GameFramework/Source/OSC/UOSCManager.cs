#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCManager.h")]
public partial class UOSCManager : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Creates an OSC Server.  If ReceiveIPAddress left empty (or &#39;0&#39;),</summary>
	public static UOSCServer CreateOSCServer(string ReceiveIPAddress,int Port,bool bMulticastLoopback,bool bStartListening,string ServerName,UObject Outer/*=nullptr*/) { return default; }
	///<summary>Creates an OSC Client.  If SendIPAddress left empty (or &#39;0&#39;), attempts to use</summary>
	public static UOSCClient CreateOSCClient(string SendIPAddress,int Port,string ClientName,UObject Outer/*=nullptr*/) { return default; }
	///<summary>Adds provided message packet to bundle.</summary>
	public static FOSCBundle AddMessageToBundle(FOSCMessage Message,FOSCBundle Bundle) { return default; }
	///<summary>Adds bundle packet to bundle.</summary>
	public static FOSCBundle AddBundleToBundle(FOSCBundle InBundle,FOSCBundle OutBundle) { return default; }
	///<summary>Fills array with child bundles found in bundle.</summary>
	public static TArray<FOSCBundle> GetBundlesFromBundle(FOSCBundle Bundle) { return default; }
	///<summary>Returns message found in bundle at ordered index.</summary>
	public static FOSCMessage GetMessageFromBundle(FOSCBundle Bundle,int Index,bool bSucceeded) { return default; }
	///<summary>Fills array with messages found in bundle.</summary>
	public static TArray<FOSCMessage> GetMessagesFromBundle(FOSCBundle Bundle) { return default; }
	///<summary>Clears provided message of all arguments.</summary>
	public static FOSCMessage ClearMessage(FOSCMessage Message) { return default; }
	///<summary>Clears provided bundle of all internal messages/bundle packets.</summary>
	public static FOSCBundle ClearBundle(FOSCBundle Bundle) { return default; }
	///<summary>Adds float value to end of OSCMessage</summary>
	public static FOSCMessage AddFloat(FOSCMessage Message,float Value) { return default; }
	///<summary>Adds Int32 value to end of OSCMessage</summary>
	public static FOSCMessage AddInt32(FOSCMessage Message,int Value) { return default; }
	///<summary>Adds Int64 value to end of OSCMessage</summary>
	public static FOSCMessage AddInt64(FOSCMessage Message,long Value) { return default; }
	///<summary>Adds address (packed as string) value to end of OSCMessage</summary>
	public static FOSCMessage AddAddress(FOSCMessage Message,FOSCAddress Value) { return default; }
	///<summary>Adds string value to end of OSCMessage</summary>
	public static FOSCMessage AddString(FOSCMessage Message,string Value) { return default; }
	///<summary>Adds blob value to end of OSCMessage</summary>
	public static FOSCMessage AddBlob(FOSCMessage Message,TArray<byte> Value) { return default; }
	///<summary>Adds boolean value to end of OSCMessage</summary>
	public static FOSCMessage AddBool(FOSCMessage Message,bool Value) { return default; }
	///<summary>Sets Value to address at provided Index in OSCMessage if in bounds and OSC type matches &#39;String&#39; (Does NOT return address of message, rather</summary>
	public static bool GetAddress(FOSCMessage Message,int Index,FOSCAddress Value) { return default; }
	///<summary>Returns all strings that are valid address paths in order received from OSCMessage (Does NOT include address of message, just</summary>
	public static void GetAllAddresses(FOSCMessage Message,TArray<FOSCAddress> Values) {}
	///<summary>Set Value to float at provided Index in OSCMessage if in bounds and type matches</summary>
	public static bool GetFloat(FOSCMessage Message,int Index,float Value) { return default; }
	///<summary>Returns all float values in order of received from OSCMessage</summary>
	public static void GetAllFloats(FOSCMessage Message,TArray<float> Values) {}
	///<summary>Set Value to integer at provided Index in OSCMessage if in bounds and type matches</summary>
	public static bool GetInt32(FOSCMessage Message,int Index,int Value) { return default; }
	///<summary>Returns all integer values in order of received from OSCMessage</summary>
	public static void GetAllInt32s(FOSCMessage Message,TArray<int> Values) {}
	///<summary>Set Value to Int64 at provided Index in OSCMessage if in bounds and type matches</summary>
	public static bool GetInt64(FOSCMessage Message,int Index,long Value) { return default; }
	///<summary>Returns all Int64 values in order of received from OSCMessage</summary>
	public static void GetAllInt64s(FOSCMessage Message,TArray<long> Values) {}
	///<summary>Set Value to string at provided Index in OSCMessage if in bounds and type matches</summary>
	public static bool GetString(FOSCMessage Message,int Index,string Value) { return default; }
	///<summary>Returns all string values in order of received from OSCMessage</summary>
	public static void GetAllStrings(FOSCMessage Message,TArray<string> Values) {}
	///<summary>Sets Value to boolean at provided Index from OSCMessage if in bounds and type matches</summary>
	public static bool GetBool(FOSCMessage Message,int Index,bool Value) { return default; }
	///<summary>Returns all boolean values in order of received from OSCMessage</summary>
	public static void GetAllBools(FOSCMessage Message,TArray<bool> Values) {}
	///<summary>Sets Value to blob at provided Index from OSCMessage if in bounds and type matches</summary>
	public static bool GetBlob(FOSCMessage Message,int Index,TArray<byte> Value) { return default; }
	///<summary>Returns whether OSC Address is valid path</summary>
	public static bool OSCAddressIsValidPath(FOSCAddress Address) { return default; }
	///<summary>Returns whether OSC Address is valid pattern to match against</summary>
	public static bool OSCAddressIsValidPattern(FOSCAddress Address) { return default; }
	///<summary>Converts string to OSC Address</summary>
	public static FOSCAddress ConvertStringToOSCAddress(string String) { return default; }
	///<summary>Returns if address pattern matches the provided address path.</summary>
	public static bool OSCAddressPathMatchesPattern(FOSCAddress Pattern,FOSCAddress Path) { return default; }
	///<summary>Finds an object with the given OSC Address in path form, where containers correspond to path folders and the the address method to the object&#39;s name.</summary>
	public static UObject FindObjectAtOSCAddress(FOSCAddress Address) { return default; }
	///<summary>Converts object path to OSC Address, converting folders to address containers and the object&#39;s name to the address method.</summary>
	public static FOSCAddress OSCAddressFromObjectPath(UObject Object) { return default; }
	///<summary>Converts object path string to OSC Address, converting folders to address containers and the object&#39;s name to the address method.</summary>
	public static FOSCAddress OSCAddressFromObjectPathString(string PathName) { return default; }
	///<summary>Converts OSC Address to an object path.</summary>
	public static string ObjectPathFromOSCAddress(FOSCAddress Address) { return default; }
	///<summary>Pushes container onto address&#39; ordered array of containers</summary>
	public static FOSCAddress OSCAddressPushContainer(FOSCAddress Address,string Container) { return default; }
	///<summary>Pushes container onto address&#39; ordered array of containers</summary>
	public static FOSCAddress OSCAddressPushContainers(FOSCAddress Address,TArray<string> Containers) { return default; }
	///<summary>Pops container from ordered array of containers. If no containers, returns empty string</summary>
	public static string OSCAddressPopContainer(FOSCAddress Address) { return default; }
	///<summary>Pops container from ordered array of containers. If NumContainers is greater than or equal to the number of containers in address, returns all containers.</summary>
	public static TArray<string> OSCAddressPopContainers(FOSCAddress Address,int NumContainers) { return default; }
	///<summary>Remove containers from ordered array of containers at index up to count of containers.</summary>
	public static FOSCAddress OSCAddressRemoveContainers(FOSCAddress Address,int Index,int Count) { return default; }
	///<summary>Returns copy of message&#39;s OSC Address</summary>
	public static FOSCAddress GetOSCMessageAddress(FOSCMessage Message) { return default; }
	///<summary>Sets the OSC Address of the provided message</summary>
	public static FOSCMessage SetOSCMessageAddress(FOSCMessage Message,FOSCAddress Address) { return default; }
	///<summary>Returns the OSC Address container at the provided &#39;Index.&#39; Returns empty string if index is out-of-bounds.</summary>
	public static string GetOSCAddressContainer(FOSCAddress Address,int Index) { return default; }
	///<summary>Builds referenced array of address of containers in order</summary>
	public static TArray<string> GetOSCAddressContainers(FOSCAddress Address) { return default; }
	///<summary>Returns full path of OSC address in the form &#39;/Container1/Container2/Method&#39;</summary>
	public static string GetOSCAddressContainerPath(FOSCAddress Address) { return default; }
	///<summary>Returns full path of OSC address in the form &#39;/Container1/Container2&#39;</summary>
	public static string GetOSCAddressFullPath(FOSCAddress Address) { return default; }
	///<summary>Returns method name of OSC Address provided</summary>
	public static string GetOSCAddressMethod(FOSCAddress Address) { return default; }
	///<summary>Clears containers of OSC Address provided</summary>
	public static FOSCAddress ClearOSCAddressContainers(FOSCAddress Address) { return default; }
	///<summary>Sets the method name of the OSC Address provided</summary>
	public static FOSCAddress SetOSCAddressMethod(FOSCAddress Address,string Method) { return default; }
}
