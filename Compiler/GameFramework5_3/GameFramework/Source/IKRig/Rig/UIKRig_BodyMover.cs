namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/Solvers/IKRig_BodyMover.h")]
public partial class UIKRig_BodyMover : UIKRigSolver {
	public static UClass StaticClass() {return default;}
	///<summary>The target bone to move with the effectors.</summary>
	public FName RootBone;
	///<summary>Blend the translational effect of this solver on/off. Range is 0-1. Default is 1.0.</summary>
	public float PositionAlpha;
	///<summary>Multiply the POSITIVE X translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionPositiveX;
	///<summary>Multiply the NEGATIVE X translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionNegativeX;
	///<summary>Multiply the POSITIVE Y translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionPositiveY;
	///<summary>Multiply the NEGATIVE Y translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionNegativeY;
	///<summary>Multiply the POSITIVE Z translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionPositiveZ;
	///<summary>Multiply the NEGATIVE Z translation. Range is 0-1. Default is 1.0.</summary>
	public float PositionNegativeZ;
	///<summary>Blend the total rotational effect on/off. Range is 0-1. Default is 1.0.</summary>
	public float RotationAlpha;
	///<summary>Blend the X-axis rotational effect on/off. Range is 0-1. Default is 1.0.</summary>
	public float RotateXAlpha;
	///<summary>Blend the Y-axis rotational effect on/off. Range is 0-1. Default is 1.0.</summary>
	public float RotateYAlpha;
	///<summary>Blend the Z-axis rotational effect on/off. Range is 0-1. Default is 1.0.</summary>
	public float RotateZAlpha;
	///<summary>Effectors</summary>
	public TArray<UIKRig_BodyMoverEffector> Effectors;
}
