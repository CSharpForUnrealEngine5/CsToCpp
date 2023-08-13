namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure used to collect New Config options from the user</summary>
[CppInclude("SwitchboardTypes.h")]
public partial struct FSwitchboardNewConfigUserOptions {
	public string ConfigName;
	public FDisplayClusterRootActorReference DCRA;
	public int NumEditorDevices;
	public bool bUseLocalhost;
	public bool bAutoConnect;
}
