#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that contains telemetry data point.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerTelemetryItem {
	public string DataPoint;
	public double Measurement;
	public string Context;
}
