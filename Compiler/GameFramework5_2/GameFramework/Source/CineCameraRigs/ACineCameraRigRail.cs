namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraRigRail.h")]
public partial class ACineCameraRigRail : ACameraRig_Rail {
	public static UClass StaticClass() {return default;}
	///<summary>Returns CineSplineComponent</summary>
	public UCineSplineComponent GetCineSplineComponent() { return default; }
	///<summary>Use AbsolutePosition metadata to parameterize the spline</summary>
	public bool bUseAbsolutePosition;
	///<summary>Custom parameter to drive current position</summary>
	public float AbsolutePositionOnRail;
	///<summary>Use PointRotation metadata for attachment orientation. If false, attachment orientation is based on the spline curvature</summary>
	public bool bUsePointRotation;
	///<summary>Material assigned to spline component mesh</summary>
	public UMaterialInterface SplineMeshMaterial;
	///<summary>Material Instance Dynamic created for the spline mesh</summary>
	public TArray<UMaterialInstanceDynamic> SplineMeshMIDs;
	///<summary>Texture that can be set to SplineMeshMIDs</summary>
	public UTexture2D SplineMeshTexture;
	///<summary>Determines if camera mount inherits LocationX</summary>
	public bool bAttachLocationX;
	///<summary>Determines if camera mount inherits LocationY</summary>
	public bool bAttachLocationY;
	///<summary>Determines if camera mount inherits LocationZ</summary>
	public bool bAttachLocationZ;
	///<summary>Determines if camera mount inherits RotationX</summary>
	public bool bAttachRotationX;
	///<summary>Determines if camera mount inherits RotationY</summary>
	public bool bAttachRotationY;
	///<summary>Determines if camera mount inherits RotationZ</summary>
	public bool bAttachRotationZ;
	///<summary>Determines if it can drive focal length on the attached actors</summary>
	public bool bInheritFocalLength;
	///<summary>Determines if it can drive aperture on the attached actors</summary>
	public bool bInheritAperture;
	///<summary>Determines if it can drive focus distance on the attached actors</summary>
	public bool bInheritFocusDistance;
	///<summary>Set spline mesh material</summary>
	public void SetSplineMeshMaterial(UMaterialInterface InMaterial) {}
	///<summary>Set texture used in the spline mesh material</summary>
	public void SetSplineMeshTexture(UTexture2D InTexture) {}
	///<summary>Calculate internal velocity at the given position</summary>
	public FVector GetVelocityAtPosition(float InPosition,float delta/*=0.001f*/) { return default; }
}
