#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>This function first defines a radial integer field equal to Interior-value inside a sphere / Exterior-value outside. This field will be used alongside the particle input value and the mask condition to compute the particle output value.</summary>
public partial class URadialIntMask : UFieldNodeInt {
// RadialIntMask
	public  URadialIntMask SetRadialIntMask(float Radius,FVector Position,int InteriorValue,int ExteriorValue,ESetMaskConditionType SetMaskConditionIn) { return default; }
	public float Radius;
	public FVector Position;
	public int InteriorValue;
	public int ExteriorValue;
	public ESetMaskConditionType SetMaskCondition;
}
