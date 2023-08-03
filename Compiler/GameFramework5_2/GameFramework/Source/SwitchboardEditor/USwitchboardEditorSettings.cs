#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchboardEditorSettings.h")]
public partial class USwitchboardEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Path to Switchboard&#39;s Python virtual environment, where third-party dependencies are installed.</summary>
	public FDirectoryPath VirtualEnvironmentPath;
	///<summary>Arguments that should be passed to the Switchboard Listener.</summary>
	public string ListenerCommandlineArguments;
	///<summary>Get Editor Settings object for Switchboard</summary>
	public static USwitchboardEditorSettings GetSwitchboardEditorSettings() { return default; }
}
