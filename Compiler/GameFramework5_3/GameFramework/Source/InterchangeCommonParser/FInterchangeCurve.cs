namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct contains only the key data, this is only used to pass animation data from interchange worker process translators to factories.</summary>
[CppInclude("InterchangeCommonAnimationPayload.h")]
public partial struct FInterchangeCurve {
	public TArray<FInterchangeCurveKey> Keys;
}
