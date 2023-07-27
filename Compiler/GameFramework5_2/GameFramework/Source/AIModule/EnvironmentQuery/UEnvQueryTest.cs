#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTest.h")]
public partial class UEnvQueryTest : UEnvQueryNode {
// EnvQueryTest
	public int TestOrder;
	public EEnvTestPurpose TestPurpose;
	public string TestComment;
	public EEnvTestFilterOperator MultipleContextFilterOp;
	public EEnvTestScoreOperator MultipleContextScoreOp;
	public EEnvTestFilterType FilterType;
	public FAIDataProviderBoolValue BoolValue;
	public FAIDataProviderFloatValue FloatValueMin;
	public FAIDataProviderFloatValue FloatValueMax;
	public EEnvTestScoreEquation ScoringEquation;
	public EEnvQueryTestClamping ClampMinType;
	public EEnvQueryTestClamping ClampMaxType;
	public EEQSNormalizationType NormalizationType;
	public FAIDataProviderFloatValue ScoreClampMin;
	public FAIDataProviderFloatValue ScoreClampMax;
	public FAIDataProviderFloatValue ScoringFactor;
	public FAIDataProviderFloatValue ReferenceValue;
	public bool bDefineReferenceValue;
	public bool bWorkOnFloatValues;
}
