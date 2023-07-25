#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterLaunchEditorProjectSettings.h")]
public partial class UDisplayClusterLaunchEditorProjectSettings : UObject {
// DisplayClusterLaunchEditorProjectSettings
	public bool bCloseEditorOnLaunch;
	public bool bConnectToMultiUser;
	public string ExplicitSessionName;
	public bool bEnableUnrealInsights;
	public bool bEnableStatNamedEvents;
	public FDirectoryPath ExplicitTraceFileSaveDirectory;
	public FSoftObjectPath ConsoleVariablesPreset;
	public TSet<string> AdditionalConsoleVariables;
	public TSet<string> AdditionalConsoleCommands;
	public TSet<string> CommandLineArguments;
	public string LogFileName;
	public TArray<FDisplayClusterLaunchLoggingConstruct> Logging;
}
