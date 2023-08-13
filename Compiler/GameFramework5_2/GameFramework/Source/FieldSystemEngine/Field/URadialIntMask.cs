namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This function first defines a radial integer field equal to Interior-value inside a sphere / Exterior-value outside. This field will be used alongside the particle input value and the mask condition to compute the particle output value.</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class URadialIntMask : UFieldNodeInt {
	public static UClass StaticClass() {return default;}
	///<summary>This function first defines a radial integer field equal to Interior-value inside a sphere / Exterior-value outside. This field will be used alongside the particle input value and the mask condition to compute the particle output value.</summary>
	public URadialIntMask SetRadialIntMask(float Radius,FVector Position,int InteriorValue,int ExteriorValue,ESetMaskConditionType SetMaskConditionIn) { return default; }
	///<summary>Radius of the radial mask field</summary>
	public float Radius;
	///<summary>Center position of the radial mask field</summary>
	public FVector Position;
	///<summary>If the sample distance from the center is less than radius, the intermediate value will be set the interior value</summary>
	public int InteriorValue;
	///<summary>If the sample distance from the center is greater than radius, the intermediate value will be set the exterior value</summary>
	public int ExteriorValue;
	///<summary>If the mask condition is set to always the output value will be the intermediate one. If set to not interior/exterior the output value will be the intermediate one if the input is different from the interior/exterior value</summary>
	public ESetMaskConditionType SetMaskCondition;
}
