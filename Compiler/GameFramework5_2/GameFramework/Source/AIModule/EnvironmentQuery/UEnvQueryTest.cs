#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTest.h")]
public partial class UEnvQueryTest : UEnvQueryNode {
	///<summary>Number of test as defined in data asset</summary>
	public int TestOrder;
	///<summary>The purpose of this test.  Should it be used for filtering possible results, scoring them, or both?</summary>
	public EEnvTestPurpose TestPurpose;
	///<summary>Optional comment or explanation about what this test is for.  Useful when the purpose of tests may not be clear,</summary>
	public string TestComment;
	///<summary>Determines filtering operator when context returns multiple items</summary>
	public EEnvTestFilterOperator MultipleContextFilterOp;
	///<summary>Determines scoring operator when context returns multiple items</summary>
	public EEnvTestScoreOperator MultipleContextScoreOp;
	///<summary>Does this test filter out results that are below a lower limit, above an upper limit, or both?  Or does it just look for a matching value?</summary>
	public EEnvTestFilterType FilterType;
	///<summary>Desired boolean value of the test for scoring to occur or filtering test to pass.</summary>
	public FAIDataProviderBoolValue BoolValue;
	///<summary>Minimum limit (inclusive) of valid values for the raw test value. Lower values will be discarded as invalid.</summary>
	public FAIDataProviderFloatValue FloatValueMin;
	///<summary>Maximum limit (inclusive) of valid values for the raw test value. Higher values will be discarded as invalid.</summary>
	public FAIDataProviderFloatValue FloatValueMax;
	///<summary>The shape of the curve equation to apply to the normalized score before multiplying by factor.</summary>
	public EEnvTestScoreEquation ScoringEquation;
	///<summary>How should the lower bound for normalization of the raw test value before applying the scoring formula be determined?</summary>
	public EEnvQueryTestClamping ClampMinType;
	///<summary>How should the upper bound for normalization of the raw test value before applying the scoring formula be determined?</summary>
	public EEnvQueryTestClamping ClampMaxType;
	///<summary>Specifies how to determine value span used to normalize scores</summary>
	public EEQSNormalizationType NormalizationType;
	///<summary>Minimum value to use to normalize the raw test value before applying scoring formula.</summary>
	public FAIDataProviderFloatValue ScoreClampMin;
	///<summary>Maximum value to use to normalize the raw test value before applying scoring formula.</summary>
	public FAIDataProviderFloatValue ScoreClampMax;
	///<summary>The weight (factor) by which to multiply the normalized score after the scoring equation is applied.</summary>
	public FAIDataProviderFloatValue ScoringFactor;
	///<summary>When specified gets used to normalize test&#39;s results in such a way that the closer a value is to ReferenceValue</summary>
	public FAIDataProviderFloatValue ReferenceValue;
	///<summary>When set to true enables usage of ReferenceValue. It&#39;s false by default</summary>
	public bool bDefineReferenceValue;
	///<summary>When set, test operates on float values (e.g. distance, with AtLeast, UpTo conditions),</summary>
	public bool bWorkOnFloatValues;
}
