namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to perform a numerical comparison of the poses</summary>
[CppInclude("Validation/ControlRigNumericalValidationPass.h")]
public partial class UControlRigNumericalValidationPass : UControlRigValidationPass {
	public static UClass StaticClass() {return default;}
	///<summary>If set to true the pass will validate the poses of all bones</summary>
	public bool bCheckControls;
	///<summary>If set to true the pass will validate the poses of all bones</summary>
	public bool bCheckBones;
	///<summary>If set to true the pass will validate the values of all curves</summary>
	public bool bCheckCurves;
	///<summary>The threshold under which we&#39;ll ignore a precision issue in the pass</summary>
	public float TranslationPrecision;
	///<summary>The threshold under which we&#39;ll ignore a precision issue in the pass (in degrees)</summary>
	public float RotationPrecision;
	///<summary>The threshold under which we&#39;ll ignore a precision issue in the pass</summary>
	public float ScalePrecision;
	///<summary>The threshold under which we&#39;ll ignore a precision issue in the pass</summary>
	public float CurvePrecision;
	///<summary>EventNameA</summary>
	public FName EventNameA;
	///<summary>EventNameB</summary>
	public FName EventNameB;
	///<summary>Pose</summary>
	public FRigPose Pose;
}
