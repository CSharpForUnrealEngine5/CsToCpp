#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamMultiUser.h")]
public partial struct FMultiUserVCamCameraFocusData {
// MultiUserVCamCameraFocusData
	public float ManualFocusDistance;
	public float FocusSmoothingInterpSpeed;
	public bool bSmoothFocusChanges;
	public string ActorToTrack;
	public FVector RelativeOffset;
	public ECameraFocusMethod FocusMethod;
	public bool bDrawDebugFocusPlane;
}
