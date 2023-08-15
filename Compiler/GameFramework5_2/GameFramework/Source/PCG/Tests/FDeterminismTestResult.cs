namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismTestsCommon.h")]
public partial struct FDeterminismTestResult {
	public FName TestResultTitle;
	public string TestResultName;
	public int Seed;
	public EPCGDataType DataTypesTested;
	public TMap<FName,EDeterminismLevel> TestResults;
	public TArray<string> AdditionalDetails;
	public bool bFlagRaised;
}
