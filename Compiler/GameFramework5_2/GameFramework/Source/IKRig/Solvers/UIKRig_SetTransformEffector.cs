namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_SetTransform.h")]
public partial class UIKRig_SetTransformEffector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, Goal will drive the translation of the target bone. Default is true.</summary>
	public bool bEnablePosition;
	///<summary>If true, Goal will drive the rotation of the target bone. Default is true.</summary>
	public bool bEnableRotation;
	///<summary>Blend the effector on/off. Range is 0-1. Default is 1.0.</summary>
	public float Alpha;
}
