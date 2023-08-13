namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Static data for Camera data.</summary>
[CppInclude("Roles/LiveLinkCameraTypes.h")]
public partial struct FLiveLinkCameraStaticData {
	public bool bIsFieldOfViewSupported;
	public bool bIsAspectRatioSupported;
	public bool bIsFocalLengthSupported;
	public bool bIsProjectionModeSupported;
	public float FilmBackWidth;
	public float FilmBackHeight;
	public bool bIsApertureSupported;
	public bool bIsFocusDistanceSupported;
	public bool bIsDepthOfFieldSupported;
}
