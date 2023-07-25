#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkTestLibrary.h")]
public partial class UDirectLinkTestLibrary : UBlueprintFunctionLibrary {
// DirectLinkTestLibrary
	public bool TestParameters() { return default; }
	public bool StartReceiver() { return default; }
	public bool SetupReceiver() { return default; }
	public bool StopReceiver() { return default; }
	public bool StartSender() { return default; }
	public bool SetupSender() { return default; }
	public bool StopSender() { return default; }
	public bool SendScene(string InFilePath) { return default; }
	public bool DumpReceivedScene() { return default; }
	public int MakeEndpoint(string NiceName,bool bVerbose/*=true*/) { return default; }
	public bool DeleteEndpoint(int EndpointId) { return default; }
	public bool AddPublicSource(int EndpointId,string SourceName) { return default; }
	public bool AddPublicDestination(int EndpointId,string DestName) { return default; }
	public bool DeleteAllEndpoint() { return default; }
}
