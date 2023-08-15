namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_FBIKSolver.h")]
public partial class UIKRig_FBIKBoneSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The bone these settings are applied to.</summary>
	public FName Bone;
	///<summary>Range is 0 to 1 (Default is 0). At higher values, the bone will resist rotating (forcing other bones to compensate).</summary>
	public float RotationStiffness;
	///<summary>Range is 0 to 1 (Default is 0). At higher values, the bone will resist translational motion (forcing other bones to compensate).</summary>
	public float PositionStiffness;
	///<summary>Limit the rotation angle of the bone on the X axis.</summary>
	public EPBIKLimitType X;
	///<summary>Range is -180 to 0 (Default is 0). Degrees of rotation in the negative X direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MinX;
	///<summary>Range is 0 to 180 (Default is 0). Degrees of rotation in the positive X direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MaxX;
	///<summary>Limit the rotation angle of the bone on the Y axis.</summary>
	public EPBIKLimitType Y;
	///<summary>Range is -180 to 0 (Default is 0). Degrees of rotation in the negative Y direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MinY;
	///<summary>Range is 0 to 180 (Default is 0). Degrees of rotation in the positive Y direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MaxY;
	///<summary>Limit the rotation angle of the bone on the Z axis.</summary>
	public EPBIKLimitType Z;
	///<summary>Range is -180 to 0 (Default is 0). Degrees of rotation in the negative Z direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MinZ;
	///<summary>Range is 0 to 180 (Default is 0). Degrees of rotation in the positive Z direction to allow when joint is in &quot;Limited&quot; mode.</summary>
	public float MaxZ;
	///<summary>When true, this bone will &quot;prefer&quot; to rotate in the direction specified by the Preferred Angles when the chain it belongs to is compressed.</summary>
	public bool bUsePreferredAngles;
	///<summary>The local Euler angles (in degrees) used to rotate this bone when the chain it belongs to is squashed.</summary>
	public FVector PreferredAngles;
}
