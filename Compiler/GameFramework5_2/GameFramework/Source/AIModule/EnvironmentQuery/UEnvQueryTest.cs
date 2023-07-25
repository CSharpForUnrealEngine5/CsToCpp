#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTest.h")]
public partial class UEnvQueryTest : UEnvQueryNode {
// EnvQueryTest
	public int TestOrder;
	public byte TestPurpose;
	public string TestComment;
	public byte MultipleContextFilterOp;
	public byte MultipleContextScoreOp;
	public byte FilterType;
	public FAIDataProviderBoolValue BoolValue;
	public FAIDataProviderFloatValue FloatValueMin;
	public FAIDataProviderFloatValue FloatValueMax;
	public byte ScoringEquation;
	public byte ClampMinType;
	public byte ClampMaxType;
	public EEQSNormalizationType NormalizationType;
	public FAIDataProviderFloatValue ScoreClampMin;
	public FAIDataProviderFloatValue ScoreClampMax;
	public FAIDataProviderFloatValue ScoringFactor;
	public FAIDataProviderFloatValue ReferenceValue;
	public bool bDefineReferenceValue;
	public bool bWorkOnFloatValues;
}
