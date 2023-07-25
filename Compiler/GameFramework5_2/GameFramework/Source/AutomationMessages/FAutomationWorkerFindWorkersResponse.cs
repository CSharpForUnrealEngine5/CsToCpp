#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is sent in response to FAutomationWorkerFindWorkers.</summary>
public partial struct FAutomationWorkerFindWorkersResponse {
// AutomationWorkerFindWorkersResponse
	public string DeviceName;
	public string InstanceName;
	public string Platform;
	public string OSVersionName;
	public string ModelName;
	public string GPUName;
	public string CPUModelName;
	public uint RAMInGB;
	public string RenderModeName;
	public FGuid SessionId;
	public string RHIName;
}
