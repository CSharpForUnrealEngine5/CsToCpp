#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that contains telemetry data.</summary>
public partial struct FAutomationWorkerTelemetryData {
// AutomationWorkerTelemetryData
	public string Storage;
	public string Configuration;
	public string Platform;
	public string TestName;
	public TArray<FAutomationWorkerTelemetryItem> Items;
}
