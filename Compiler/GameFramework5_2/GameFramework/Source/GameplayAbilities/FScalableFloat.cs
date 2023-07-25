#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScalableFloat.h")]
///<summary>Generic numerical value in the form Value * Curve[Level]</summary>
public partial struct FScalableFloat {
// ScalableFloat
	public float Value;
	public FCurveTableRowHandle Curve;
	public FDataRegistryType RegistryType;
}
