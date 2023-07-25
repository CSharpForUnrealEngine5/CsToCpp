#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothLODData_Legacy.h")]
///<summary>Deprecated, legacy definition kept for backward compatibility only.</summary>
public partial struct FClothParameterMask_Legacy {
// ClothParameterMask_Legacy
	public string MaskName;
	public EWeightMapTargetCommon CurrentTarget;
	public float MaxValue_DEPRECATED;
	public float MinValue_DEPRECATED;
	public TArray<float> Values;
	public bool bEnabled;
}
