namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent in response to FAutomationWorkerFindWorkers.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerFindWorkersResponse {
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
