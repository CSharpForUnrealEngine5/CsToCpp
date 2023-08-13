namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message for terminating an application running on the device.</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceServiceTerminateLaunchedProcess {
	public string Variant;
	public string AppID;
}
