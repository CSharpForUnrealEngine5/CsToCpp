#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchboardTypes.h")]
///<summary>Structure that holds the parameters to the sb_script_new_config.py script that will be passed to Switchboard when auto-creating a new config.</summary>
public partial struct FSwitchboardScriptArguments {
// SwitchboardScriptArguments
	public string ConfigName;
	public string EngineDir;
	public string ProjectPath;
	public string Map;
	public string DisplayClusterConfigPath;
	public int NumEditorDevices;
	public bool bUseLocalhost;
	public bool bAutoConnect;
	public bool bAutoDeleteScriptArgsFile;
}
