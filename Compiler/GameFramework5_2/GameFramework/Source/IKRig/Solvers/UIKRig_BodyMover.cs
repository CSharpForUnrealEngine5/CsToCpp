#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_BodyMover.h")]
public partial class UIKRig_BodyMover : UIKRigSolver {
// IKRig_BodyMover
	public string RootBone;
	public float PositionAlpha;
	public float PositionPositiveX;
	public float PositionNegativeX;
	public float PositionPositiveY;
	public float PositionNegativeY;
	public float PositionPositiveZ;
	public float PositionNegativeZ;
	public float RotationAlpha;
	public float RotateXAlpha;
	public float RotateYAlpha;
	public float RotateZAlpha;
	public TArray<UIKRig_BodyMoverEffector> Effectors;
}
