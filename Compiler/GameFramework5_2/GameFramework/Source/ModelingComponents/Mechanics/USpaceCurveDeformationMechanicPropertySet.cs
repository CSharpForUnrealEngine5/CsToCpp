#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/SpaceCurveDeformationMechanic.h")]
public partial class USpaceCurveDeformationMechanicPropertySet : UInteractiveToolPropertySet {
// SpaceCurveDeformationMechanicPropertySet
	public ESpaceCurveControlPointTransformMode TransformMode;
	public ESpaceCurveControlPointOriginMode TransformOrigin;
	public float Softness;
	public ESpaceCurveControlPointFalloffType SoftFalloff;
}
