namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is sent in containing a screen shot run during performance test.</summary>
[CppInclude("AutomationWorkerMessages.h")]
public partial struct FAutomationWorkerImageComparisonResults {
	public FGuid UniqueId;
	public bool bNew;
	public bool bSimilar;
	public double MaxLocalDifference;
	public double GlobalDifference;
	public string ErrorMessage;
}
