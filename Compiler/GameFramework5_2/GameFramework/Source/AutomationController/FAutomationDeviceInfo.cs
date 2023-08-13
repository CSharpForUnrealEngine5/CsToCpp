namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Hold information about the Device</summary>
[CppInclude("AutomationDeviceClusterManager.h")]
public partial struct FAutomationDeviceInfo {
	public string DeviceName;
	public string Instance;
	public string Platform;
	public string OSVersion;
	public string Model;
	public string GPU;
	public string CPUModel;
	public uint RAMInGB;
	public string RenderMode;
	public string RHI;
	public string AppInstanceLog;
}
