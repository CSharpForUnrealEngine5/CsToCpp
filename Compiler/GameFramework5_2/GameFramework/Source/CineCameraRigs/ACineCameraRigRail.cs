#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CineCameraRigRail.h")]
public partial class ACineCameraRigRail : ACameraRig_Rail {
// CineCameraRigRail
	public  UCineSplineComponent GetCineSplineComponent() { return default; }
	public bool bUseAbsolutePosition;
	public float AbsolutePositionOnRail;
	public bool bUsePointRotation;
	public UMaterialInterface SplineMeshMaterial;
	public TArray<UMaterialInstanceDynamic> SplineMeshMIDs;
	public UTexture2D SplineMeshTexture;
	public bool bAttachLocationX;
	public bool bAttachLocationY;
	public bool bAttachLocationZ;
	public bool bAttachRotationX;
	public bool bAttachRotationY;
	public bool bAttachRotationZ;
	public bool bInheritFocalLength;
	public bool bInheritAperture;
	public bool bInheritFocusDistance;
	public  void SetSplineMeshMaterial(UMaterialInterface InMaterial) {}
	public  void SetSplineMeshTexture(UTexture2D InTexture) {}
	public  FVector GetVelocityAtPosition(float InPosition,float delta/*=0.001f*/) { return default; }
}
