namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subclass URemeshMeshToolProperties just so we can set default values for some properties. Setting these values in the</summary>
[CppInclude("ProjectToTargetTool.h")]
public partial class UProjectToTargetToolProperties : URemeshMeshToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>bWorldSpace</summary>
	public bool bWorldSpace;
	///<summary>bParallel</summary>
	public bool bParallel;
	///<summary>FaceProjectionPassesPerRemeshIteration</summary>
	public int FaceProjectionPassesPerRemeshIteration;
	///<summary>SurfaceProjectionSpeed</summary>
	public float SurfaceProjectionSpeed;
	///<summary>NormalAlignmentSpeed</summary>
	public float NormalAlignmentSpeed;
	///<summary>bSmoothInFillAreas</summary>
	public bool bSmoothInFillAreas;
	///<summary>FillAreaDistanceMultiplier</summary>
	public float FillAreaDistanceMultiplier;
	///<summary>FillAreaSmoothMultiplier</summary>
	public float FillAreaSmoothMultiplier;
}
