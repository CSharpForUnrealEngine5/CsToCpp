namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismTestsCommon.h")]
public partial struct FDeterminismTestResult {
	public string TestResultTitle;
	public string TestResultName;
	public int Seed;
	public EPCGDataType DataTypesTested;
	public TMap<string,EDeterminismLevel> TestResults;
	public TArray<string> AdditionalDetails;
	public bool bFlagRaised;
}
