#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated, legacy definition kept for backward compatibility only.</summary>
[CppInclude("ClothLODData_Legacy.h")]
public partial struct FClothParameterMask_Legacy {
	public string MaskName;
	public EWeightMapTargetCommon CurrentTarget;
	public float MaxValue_DEPRECATED;
	public float MinValue_DEPRECATED;
	public TArray<float> Values;
	public bool bEnabled;
}
