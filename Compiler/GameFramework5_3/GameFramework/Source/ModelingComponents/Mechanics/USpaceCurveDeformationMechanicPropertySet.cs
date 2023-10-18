namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/SpaceCurveDeformationMechanic.h")]
public partial class USpaceCurveDeformationMechanicPropertySet : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>TransformMode</summary>
	public ESpaceCurveControlPointTransformMode TransformMode;
	///<summary>TransformOrigin</summary>
	public ESpaceCurveControlPointOriginMode TransformOrigin;
	///<summary>Softness</summary>
	public float Softness;
	///<summary>SoftFalloff</summary>
	public ESpaceCurveControlPointFalloffType SoftFalloff;
}
