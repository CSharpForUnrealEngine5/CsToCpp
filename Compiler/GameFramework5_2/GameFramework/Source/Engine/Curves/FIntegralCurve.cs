#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Curves/IntegralCurve.h")]
///<summary>An integral curve, which holds the key time and the key value</summary>
public partial struct FIntegralCurve {
// IntegralCurve
	public TArray<FIntegralKey> Keys;
	public int DefaultValue;
	public bool bUseDefaultValueBeforeFirstKey;
}
