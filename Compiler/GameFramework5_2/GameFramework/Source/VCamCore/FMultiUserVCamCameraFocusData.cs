namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamMultiUser.h")]
public partial struct FMultiUserVCamCameraFocusData {
	public float ManualFocusDistance;
	public float FocusSmoothingInterpSpeed;
	public bool bSmoothFocusChanges;
	public string ActorToTrack;
	public FVector RelativeOffset;
	public ECameraFocusMethod FocusMethod;
	public bool bDrawDebugFocusPlane;
}
