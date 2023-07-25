#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PythonScriptPluginSettings.h")]
///<summary>Configure the Python plug-in.</summary>
public partial class UPythonScriptPluginSettings : UDeveloperSettings {
// PythonScriptPluginSettings
	public TArray<string> StartupScripts;
	public TArray<FDirectoryPath> AdditionalPaths;
	public bool bIsolateInterpreterEnvironment;
	public bool bDeveloperMode;
	public bool bRemoteExecution;
	public string RemoteExecutionMulticastGroupEndpoint;
	public string RemoteExecutionMulticastBindAddress;
	public int RemoteExecutionSendBufferSizeBytes;
	public int RemoteExecutionReceiveBufferSizeBytes;
	public byte RemoteExecutionMulticastTtl;
}
