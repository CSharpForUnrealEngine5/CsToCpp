#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraAnimationSequencePlayer.h")]
///<summary>A dummy class that we give to a sequence in lieu of an actual camera actor.</summary>
public partial class UCameraAnimationSequenceCameraStandIn : UObject {
// CameraAnimationSequenceCameraStandIn
	public float FieldOfView;
	public bool bConstrainAspectRatio;
	public float AspectRatio;
	public FPostProcessSettings PostProcessSettings;
	public float PostProcessBlendWeight;
	public FCameraFilmbackSettings Filmback;
	public FCameraLensSettings LensSettings;
	public FCameraFocusSettings FocusSettings;
	public float CurrentFocalLength;
	public float CurrentAperture;
	public float CurrentFocusDistance;
}
