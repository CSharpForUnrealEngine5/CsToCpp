#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCManager.h")]
public partial class UOSCManager : UBlueprintFunctionLibrary {
// OSCManager
	public UObject CreateOSCServer(string ReceiveIPAddress,int Port,bool bMulticastLoopback,bool bStartListening,string ServerName,UObject Outer/*=nullptr*/) { return default; }
	public UObject CreateOSCClient(string SendIPAddress,int Port,string ClientName,UObject Outer/*=nullptr*/) { return default; }
	public FOSCBundle AddMessageToBundle(FOSCMessage Message,FOSCBundle Bundle) { return default; }
	public FOSCBundle AddBundleToBundle(FOSCBundle InBundle,FOSCBundle OutBundle) { return default; }
	public TArray<FOSCBundle> GetBundlesFromBundle(FOSCBundle Bundle) { return default; }
	public FOSCMessage GetMessageFromBundle(FOSCBundle Bundle,int Index,bool bSucceeded) { return default; }
	public TArray<FOSCMessage> GetMessagesFromBundle(FOSCBundle Bundle) { return default; }
	public FOSCMessage ClearMessage(FOSCMessage Message) { return default; }
	public FOSCBundle ClearBundle(FOSCBundle Bundle) { return default; }
	public FOSCMessage AddFloat(FOSCMessage Message,float Value) { return default; }
	public FOSCMessage AddInt32(FOSCMessage Message,int Value) { return default; }
	public FOSCMessage AddInt64(FOSCMessage Message,long Value) { return default; }
	public FOSCMessage AddAddress(FOSCMessage Message,FOSCAddress Value) { return default; }
	public FOSCMessage AddString(FOSCMessage Message,string Value) { return default; }
	public FOSCMessage AddBlob(FOSCMessage Message,TArray<byte> Value) { return default; }
	public FOSCMessage AddBool(FOSCMessage Message,bool Value) { return default; }
	public bool GetAddress(FOSCMessage Message,int Index,FOSCAddress Value) { return default; }
	public void GetAllAddresses(FOSCMessage Message,TArray<FOSCAddress> Values) {}
	public bool GetFloat(FOSCMessage Message,int Index,float Value) { return default; }
	public void GetAllFloats(FOSCMessage Message,TArray<float> Values) {}
	public bool GetInt32(FOSCMessage Message,int Index,int Value) { return default; }
	public void GetAllInt32s(FOSCMessage Message,TArray<int> Values) {}
	public bool GetInt64(FOSCMessage Message,int Index,long Value) { return default; }
	public void GetAllInt64s(FOSCMessage Message,TArray<long> Values) {}
	public bool GetString(FOSCMessage Message,int Index,string Value) { return default; }
	public void GetAllStrings(FOSCMessage Message,TArray<string> Values) {}
	public bool GetBool(FOSCMessage Message,int Index,bool Value) { return default; }
	public void GetAllBools(FOSCMessage Message,TArray<bool> Values) {}
	public bool GetBlob(FOSCMessage Message,int Index,TArray<byte> Value) { return default; }
	public bool OSCAddressIsValidPath(FOSCAddress Address) { return default; }
	public bool OSCAddressIsValidPattern(FOSCAddress Address) { return default; }
	public FOSCAddress ConvertStringToOSCAddress(string String) { return default; }
	public bool OSCAddressPathMatchesPattern(FOSCAddress Pattern,FOSCAddress Path) { return default; }
	public UObject FindObjectAtOSCAddress(FOSCAddress Address) { return default; }
	public FOSCAddress OSCAddressFromObjectPath(UObject Object) { return default; }
	public FOSCAddress OSCAddressFromObjectPathString(string PathName) { return default; }
	public string ObjectPathFromOSCAddress(FOSCAddress Address) { return default; }
	public FOSCAddress OSCAddressPushContainer(FOSCAddress Address,string Container) { return default; }
	public FOSCAddress OSCAddressPushContainers(FOSCAddress Address,TArray<string> Containers) { return default; }
	public string OSCAddressPopContainer(FOSCAddress Address) { return default; }
	public TArray<string> OSCAddressPopContainers(FOSCAddress Address,int NumContainers) { return default; }
	public FOSCAddress OSCAddressRemoveContainers(FOSCAddress Address,int Index,int Count) { return default; }
	public FOSCAddress GetOSCMessageAddress(FOSCMessage Message) { return default; }
	public FOSCMessage SetOSCMessageAddress(FOSCMessage Message,FOSCAddress Address) { return default; }
	public string GetOSCAddressContainer(FOSCAddress Address,int Index) { return default; }
	public TArray<string> GetOSCAddressContainers(FOSCAddress Address) { return default; }
	public string GetOSCAddressContainerPath(FOSCAddress Address) { return default; }
	public string GetOSCAddressFullPath(FOSCAddress Address) { return default; }
	public string GetOSCAddressMethod(FOSCAddress Address) { return default; }
	public FOSCAddress ClearOSCAddressContainers(FOSCAddress Address) { return default; }
	public FOSCAddress SetOSCAddressMethod(FOSCAddress Address,string Method) { return default; }
}
