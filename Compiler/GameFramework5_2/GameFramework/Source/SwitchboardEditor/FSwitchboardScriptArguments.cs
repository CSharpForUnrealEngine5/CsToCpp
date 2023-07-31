#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that holds the parameters to the sb_script_new_config.py script that will be passed to Switchboard when auto-creating a new config.</summary>
[CppInclude("SwitchboardTypes.h")]
public partial struct FSwitchboardScriptArguments {
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
