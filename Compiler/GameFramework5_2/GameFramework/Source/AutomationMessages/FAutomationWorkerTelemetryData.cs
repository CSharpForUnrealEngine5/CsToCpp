#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that contains telemetry data.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerTelemetryData {
	public string Storage;
	public string Configuration;
	public string Platform;
	public string TestName;
	public TArray<FAutomationWorkerTelemetryItem> Items;
}
