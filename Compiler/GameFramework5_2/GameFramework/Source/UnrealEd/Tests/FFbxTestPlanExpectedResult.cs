#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/FbxAutomationCommon.h")]
///<summary>Container for detailing collision automated test data.</summary>
public partial struct FFbxTestPlanExpectedResult {
// FbxTestPlanExpectedResult
	public EFBXExpectedResultPreset ExpectedPresetsType;
	public TArray<int> ExpectedPresetsDataInteger;
	public TArray<float> ExpectedPresetsDataFloat;
	public TArray<double> ExpectedPresetsDataDouble;
	public TArray<string> ExpectedPresetsDataString;
}
