#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismTestsCommon.h")]
public partial struct FDeterminismTestResult {
// DeterminismTestResult
	public string TestResultTitle;
	public string TestResultName;
	public int Seed;
	public EPCGDataType DataTypesTested;
	public TMap<string,EDeterminismLevel> TestResults;
	public TArray<string> AdditionalDetails;
	public bool bFlagRaised;
}
