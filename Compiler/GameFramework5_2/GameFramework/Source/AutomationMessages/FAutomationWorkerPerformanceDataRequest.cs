namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message to request the performance data for this hardware.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerPerformanceDataRequest {
	public string Platform;
	public string Hardware;
	public string TestName;
	public TArray<double> DataPoints;
}
