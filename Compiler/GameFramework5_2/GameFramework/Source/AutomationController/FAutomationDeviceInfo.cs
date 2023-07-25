#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationDeviceClusterManager.h")]
///<summary>Hold information about the Device</summary>
public partial struct FAutomationDeviceInfo {
// AutomationDeviceInfo
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
