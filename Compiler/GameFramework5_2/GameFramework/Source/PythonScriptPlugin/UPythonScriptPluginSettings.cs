#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configure the Python plug-in.</summary>
[CppInclude("PythonScriptPluginSettings.h")]
public partial class UPythonScriptPluginSettings : UDeveloperSettings {
	///<summary>Array of Python scripts to run at start-up (run before the first Tick after the Engine has initialized).</summary>
	public TArray<string> StartupScripts;
	///<summary>Array of additional paths to add to the Python system paths.</summary>
	public TArray<FDirectoryPath> AdditionalPaths;
	///<summary>Should the embedded interpreter be run in isolation mode. In isolation, the standard PYTHON* environment variables (PYTHONPATH,</summary>
	public bool bIsolateInterpreterEnvironment;
	///<summary>Should Developer Mode be enabled on the Python interpreter *for all users of the project*</summary>
	public bool bDeveloperMode;
	///<summary>Should remote Python execution be enabled?</summary>
	public bool bRemoteExecution;
	///<summary>The multicast group endpoint (in the form of IP_ADDRESS:PORT_NUMBER) that the UDP multicast socket should join</summary>
	public string RemoteExecutionMulticastGroupEndpoint;
	///<summary>The adapter address that the UDP multicast socket should bind to, or 0.0.0.0 to bind to all adapters</summary>
	public string RemoteExecutionMulticastBindAddress;
	///<summary>Size of the send buffer for the remote endpoint connection</summary>
	public int RemoteExecutionSendBufferSizeBytes;
	///<summary>Size of the receive buffer for the remote endpoint connection</summary>
	public int RemoteExecutionReceiveBufferSizeBytes;
	///<summary>The TTL that the UDP multicast socket should use (0 is limited to the local host, 1 is limited to the local subnet)</summary>
	public byte RemoteExecutionMulticastTtl;
}
