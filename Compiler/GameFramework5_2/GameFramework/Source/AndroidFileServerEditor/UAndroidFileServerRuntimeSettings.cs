#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidFileServerRuntimeSettings.h")]
public partial class UAndroidFileServerRuntimeSettings : UObject {
// AndroidFileServerRuntimeSettings
	public bool bEnablePlugin;
	public bool bAllowNetworkConnection;
	public string SecurityToken;
	public bool bIncludeInShipping;
	public bool bAllowExternalStartInShipping;
	public bool bCompileAFSProject;
	public bool bUseCompression;
	public bool bLogFiles;
	public bool bReportStats;
	public EAFSConnectionType ConnectionType;
	public bool bUseManualIPAddress;
	public string ManualIPAddress;
}
