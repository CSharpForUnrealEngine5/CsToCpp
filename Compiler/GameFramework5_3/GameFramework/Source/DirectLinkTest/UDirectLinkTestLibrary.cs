namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkTestLibrary.h")]
public partial class UDirectLinkTestLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>TestParameters</summary>
	public static bool TestParameters() { return default; }
	///<summary>StartReceiver</summary>
	public static bool StartReceiver() { return default; }
	///<summary>SetupReceiver</summary>
	public static bool SetupReceiver() { return default; }
	///<summary>StopReceiver</summary>
	public static bool StopReceiver() { return default; }
	///<summary>StartSender</summary>
	public static bool StartSender() { return default; }
	///<summary>SetupSender</summary>
	public static bool SetupSender() { return default; }
	///<summary>StopSender</summary>
	public static bool StopSender() { return default; }
	///<summary>SendScene</summary>
	public static bool SendScene(string InFilePath) { return default; }
	///<summary>DumpReceivedScene</summary>
	public static bool DumpReceivedScene() { return default; }
	///<summary>MakeEndpoint</summary>
	public static int MakeEndpoint(string NiceName,bool bVerbose/*=true*/) { return default; }
	///<summary>DeleteEndpoint</summary>
	public static bool DeleteEndpoint(int EndpointId) { return default; }
	///<summary>AddPublicSource</summary>
	public static bool AddPublicSource(int EndpointId,string SourceName) { return default; }
	///<summary>AddPublicDestination</summary>
	public static bool AddPublicDestination(int EndpointId,string DestName) { return default; }
	///<summary>DeleteAllEndpoint</summary>
	public static bool DeleteAllEndpoint() { return default; }
}
