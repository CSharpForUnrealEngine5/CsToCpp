#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterLaunchEditorProjectSettings.h")]
public partial class UDisplayClusterLaunchEditorProjectSettings : UObject {
	///<summary>If true, the editor will be closed on session launch to optimize session performance.</summary>
	public bool bCloseEditorOnLaunch;
	///<summary>If true, this command will attempt to connect to an existing</summary>
	public bool bConnectToMultiUser;
	///<summary>A specific session name to use when connecting to multi-user if bAutoGenerateSessionName is false.</summary>
	public string ExplicitSessionName;
	///<summary>Whether or not to enable Unreal Insights for this session</summary>
	public bool bEnableUnrealInsights;
	///<summary>Enable support for Stat Named Events in Unreal Insights</summary>
	public bool bEnableStatNamedEvents;
	///<summary>Where to store the Unreal Insights Trace Files.</summary>
	public FDirectoryPath ExplicitTraceFileSaveDirectory;
	///<summary>A Console Variables Asset to always apply to your launches.</summary>
	public FSoftObjectPath ConsoleVariablesPreset;
	///<summary>DPCvars</summary>
	public TSet<string> AdditionalConsoleVariables;
	///<summary>You can specify additional console commands here to be executed after those of the Console Variable Preset are executed.</summary>
	public TSet<string> AdditionalConsoleCommands;
	///<summary>A list of command line arguments to append to the Switchboard command (e.g. messaging, fullscreen, handleensurepercent=0)</summary>
	public TSet<string> CommandLineArguments;
	///<summary>The name of the log file to which to write logs for the launched node.</summary>
	public string LogFileName;
	///<summary>Which logs to include and with which verbosity level</summary>
	public TArray<FDisplayClusterLaunchLoggingConstruct> Logging;
}
