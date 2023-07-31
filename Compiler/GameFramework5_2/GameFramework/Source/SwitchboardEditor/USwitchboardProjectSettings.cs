#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchboardProjectSettings.h")]
public partial class USwitchboardProjectSettings : UObject {
	///<summary>The OSC listener for Switchboard. An OSC server can be started on launch via the Virtual Production Editor section of the Project Settings. Switchboard uses port 8000 by default, but this can be configured in your Switchboard config settings.</summary>
	public FSoftObjectPath SwitchboardOSCListener;
	///<summary>Get Project Settings object for Switchboard</summary>
	public static USwitchboardProjectSettings GetSwitchboardProjectSettings() { return default; }
}
