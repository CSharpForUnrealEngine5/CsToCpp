#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for detailing collision automated test data.</summary>
[CppInclude("Tests/FbxAutomationCommon.h")]
public partial struct FFbxTestPlanExpectedResult {
	public EFBXExpectedResultPreset ExpectedPresetsType;
	public TArray<int> ExpectedPresetsDataInteger;
	public TArray<float> ExpectedPresetsDataFloat;
	public TArray<double> ExpectedPresetsDataDouble;
	public TArray<string> ExpectedPresetsDataString;
}
