#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidFileServerRuntimeSettings.h")]
public partial class UAndroidFileServerRuntimeSettings : UObject {
	///<summary>Enable Android FileServer for packaged builds and quick launch</summary>
	public bool bEnablePlugin;
	///<summary>Allow FileServer connection using network</summary>
	public bool bAllowNetworkConnection;
	///<summary>Optional security token required to start FileServer (leave empty to disable)</summary>
	public string SecurityToken;
	///<summary>Embed FileServer in Shipping builds</summary>
	public bool bIncludeInShipping;
	///<summary>Allow FileServer to be started in Shipping builds with UnrealAndroidFileTool</summary>
	public bool bAllowExternalStartInShipping;
	///<summary>Compile standalone AFS project</summary>
	public bool bCompileAFSProject;
	///<summary>Enable compression during data transfer</summary>
	public bool bUseCompression;
	///<summary>Log files transferred</summary>
	public bool bLogFiles;
	///<summary>Report transfer rate statistics</summary>
	public bool bReportStats;
	///<summary>How to connect to file server (USB cable, Network, or combined)</summary>
	public EAFSConnectionType ConnectionType;
	///<summary>Use manual IP address instead of automatic query from device (only for single device deploys!)</summary>
	public bool bUseManualIPAddress;
	///<summary>IP address of device to use</summary>
	public string ManualIPAddress;
}
