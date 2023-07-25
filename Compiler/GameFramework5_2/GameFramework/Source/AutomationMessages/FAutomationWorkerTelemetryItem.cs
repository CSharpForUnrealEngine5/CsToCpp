#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that contains telemetry data point.</summary>
public partial struct FAutomationWorkerTelemetryItem {
// AutomationWorkerTelemetryItem
	public string DataPoint;
	public double Measurement;
	public string Context;
}
