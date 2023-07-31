#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An integral curve, which holds the key time and the key value</summary>
[CppInclude("Curves/IntegralCurve.h")]
public partial struct FIntegralCurve {
	public TArray<FIntegralKey> Keys;
	public int DefaultValue;
	public bool bUseDefaultValueBeforeFirstKey;
}
