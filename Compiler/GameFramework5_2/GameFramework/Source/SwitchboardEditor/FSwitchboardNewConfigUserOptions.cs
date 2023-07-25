#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchboardTypes.h")]
///<summary>Structure used to collect New Config options from the user</summary>
public partial struct FSwitchboardNewConfigUserOptions {
// SwitchboardNewConfigUserOptions
	public string ConfigName;
	public FDisplayClusterRootActorReference DCRA;
	public int NumEditorDevices;
	public bool bUseLocalhost;
	public bool bAutoConnect;
}
