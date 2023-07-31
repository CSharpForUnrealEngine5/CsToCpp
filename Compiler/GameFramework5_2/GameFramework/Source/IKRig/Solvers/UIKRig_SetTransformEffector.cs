#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_SetTransform.h")]
public partial class UIKRig_SetTransformEffector : UObject {
	///<summary>If true, Goal will drive the translation of the target bone. Default is true.</summary>
	public bool bEnablePosition;
	///<summary>If true, Goal will drive the rotation of the target bone. Default is true.</summary>
	public bool bEnableRotation;
	///<summary>Blend the effector on/off. Range is 0-1. Default is 1.0.</summary>
	public float Alpha;
}
