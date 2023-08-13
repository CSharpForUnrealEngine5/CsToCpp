namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dynamic data for camera</summary>
[CppInclude("Roles/LiveLinkCameraTypes.h")]
public partial struct FLiveLinkCameraFrameData {
	public float FieldOfView;
	public float AspectRatio;
	public float FocalLength;
	public float Aperture;
	public float FocusDistance;
	public ELiveLinkCameraProjectionMode ProjectionMode;
}
