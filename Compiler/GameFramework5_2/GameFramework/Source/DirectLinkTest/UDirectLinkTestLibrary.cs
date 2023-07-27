#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkTestLibrary.h")]
public partial class UDirectLinkTestLibrary : UBlueprintFunctionLibrary {
// DirectLinkTestLibrary
	public static bool TestParameters() { return default; }
	public static bool StartReceiver() { return default; }
	public static bool SetupReceiver() { return default; }
	public static bool StopReceiver() { return default; }
	public static bool StartSender() { return default; }
	public static bool SetupSender() { return default; }
	public static bool StopSender() { return default; }
	public static bool SendScene(string InFilePath) { return default; }
	public static bool DumpReceivedScene() { return default; }
	public static int MakeEndpoint(string NiceName,bool bVerbose/*=true*/) { return default; }
	public static bool DeleteEndpoint(int EndpointId) { return default; }
	public static bool AddPublicSource(int EndpointId,string SourceName) { return default; }
	public static bool AddPublicDestination(int EndpointId,string DestName) { return default; }
	public static bool DeleteAllEndpoint() { return default; }
}
