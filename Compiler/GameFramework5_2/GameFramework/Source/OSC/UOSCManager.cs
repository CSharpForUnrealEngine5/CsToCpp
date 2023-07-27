#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCManager.h")]
public partial class UOSCManager : UBlueprintFunctionLibrary {
// OSCManager
	public static UOSCServer CreateOSCServer(string ReceiveIPAddress,int Port,bool bMulticastLoopback,bool bStartListening,string ServerName,UObject Outer/*=nullptr*/) { return default; }
	public static UOSCClient CreateOSCClient(string SendIPAddress,int Port,string ClientName,UObject Outer/*=nullptr*/) { return default; }
	public static FOSCBundle AddMessageToBundle(FOSCMessage Message,FOSCBundle Bundle) { return default; }
	public static FOSCBundle AddBundleToBundle(FOSCBundle InBundle,FOSCBundle OutBundle) { return default; }
	public static TArray<FOSCBundle> GetBundlesFromBundle(FOSCBundle Bundle) { return default; }
	public static FOSCMessage GetMessageFromBundle(FOSCBundle Bundle,int Index,bool bSucceeded) { return default; }
	public static TArray<FOSCMessage> GetMessagesFromBundle(FOSCBundle Bundle) { return default; }
	public static FOSCMessage ClearMessage(FOSCMessage Message) { return default; }
	public static FOSCBundle ClearBundle(FOSCBundle Bundle) { return default; }
	public static FOSCMessage AddFloat(FOSCMessage Message,float Value) { return default; }
	public static FOSCMessage AddInt32(FOSCMessage Message,int Value) { return default; }
	public static FOSCMessage AddInt64(FOSCMessage Message,long Value) { return default; }
	public static FOSCMessage AddAddress(FOSCMessage Message,FOSCAddress Value) { return default; }
	public static FOSCMessage AddString(FOSCMessage Message,string Value) { return default; }
	public static FOSCMessage AddBlob(FOSCMessage Message,TArray<byte> Value) { return default; }
	public static FOSCMessage AddBool(FOSCMessage Message,bool Value) { return default; }
	public static bool GetAddress(FOSCMessage Message,int Index,FOSCAddress Value) { return default; }
	public static void GetAllAddresses(FOSCMessage Message,TArray<FOSCAddress> Values) {}
	public static bool GetFloat(FOSCMessage Message,int Index,float Value) { return default; }
	public static void GetAllFloats(FOSCMessage Message,TArray<float> Values) {}
	public static bool GetInt32(FOSCMessage Message,int Index,int Value) { return default; }
	public static void GetAllInt32s(FOSCMessage Message,TArray<int> Values) {}
	public static bool GetInt64(FOSCMessage Message,int Index,long Value) { return default; }
	public static void GetAllInt64s(FOSCMessage Message,TArray<long> Values) {}
	public static bool GetString(FOSCMessage Message,int Index,string Value) { return default; }
	public static void GetAllStrings(FOSCMessage Message,TArray<string> Values) {}
	public static bool GetBool(FOSCMessage Message,int Index,bool Value) { return default; }
	public static void GetAllBools(FOSCMessage Message,TArray<bool> Values) {}
	public static bool GetBlob(FOSCMessage Message,int Index,TArray<byte> Value) { return default; }
	public static bool OSCAddressIsValidPath(FOSCAddress Address) { return default; }
	public static bool OSCAddressIsValidPattern(FOSCAddress Address) { return default; }
	public static FOSCAddress ConvertStringToOSCAddress(string String) { return default; }
	public static bool OSCAddressPathMatchesPattern(FOSCAddress Pattern,FOSCAddress Path) { return default; }
	public static UObject FindObjectAtOSCAddress(FOSCAddress Address) { return default; }
	public static FOSCAddress OSCAddressFromObjectPath(UObject Object) { return default; }
	public static FOSCAddress OSCAddressFromObjectPathString(string PathName) { return default; }
	public static string ObjectPathFromOSCAddress(FOSCAddress Address) { return default; }
	public static FOSCAddress OSCAddressPushContainer(FOSCAddress Address,string Container) { return default; }
	public static FOSCAddress OSCAddressPushContainers(FOSCAddress Address,TArray<string> Containers) { return default; }
	public static string OSCAddressPopContainer(FOSCAddress Address) { return default; }
	public static TArray<string> OSCAddressPopContainers(FOSCAddress Address,int NumContainers) { return default; }
	public static FOSCAddress OSCAddressRemoveContainers(FOSCAddress Address,int Index,int Count) { return default; }
	public static FOSCAddress GetOSCMessageAddress(FOSCMessage Message) { return default; }
	public static FOSCMessage SetOSCMessageAddress(FOSCMessage Message,FOSCAddress Address) { return default; }
	public static string GetOSCAddressContainer(FOSCAddress Address,int Index) { return default; }
	public static TArray<string> GetOSCAddressContainers(FOSCAddress Address) { return default; }
	public static string GetOSCAddressContainerPath(FOSCAddress Address) { return default; }
	public static string GetOSCAddressFullPath(FOSCAddress Address) { return default; }
	public static string GetOSCAddressMethod(FOSCAddress Address) { return default; }
	public static FOSCAddress ClearOSCAddressContainers(FOSCAddress Address) { return default; }
	public static FOSCAddress SetOSCAddressMethod(FOSCAddress Address,string Method) { return default; }
}
