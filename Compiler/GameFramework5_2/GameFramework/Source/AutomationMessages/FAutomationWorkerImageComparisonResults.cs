#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is sent in containing a screen shot run during performance test.</summary>
public partial struct FAutomationWorkerImageComparisonResults {
// AutomationWorkerImageComparisonResults
	public FGuid UniqueId;
	public bool bNew;
	public bool bSimilar;
	public double MaxLocalDifference;
	public double GlobalDifference;
	public string ErrorMessage;
}
