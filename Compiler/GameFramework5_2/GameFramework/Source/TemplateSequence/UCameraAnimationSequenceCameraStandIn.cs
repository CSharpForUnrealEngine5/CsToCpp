#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A dummy class that we give to a sequence in lieu of an actual camera actor.</summary>
[CppInclude("CameraAnimationSequencePlayer.h")]
public partial class UCameraAnimationSequenceCameraStandIn : UObject {
	///<summary>Camera component properties</summary>
	public float FieldOfView;
	///<summary>bConstrainAspectRatio</summary>
	public bool bConstrainAspectRatio;
	///<summary>AspectRatio</summary>
	public float AspectRatio;
	///<summary>PostProcessSettings</summary>
	public FPostProcessSettings PostProcessSettings;
	///<summary>PostProcessBlendWeight</summary>
	public float PostProcessBlendWeight;
	///<summary>Cine camera component properties</summary>
	public FCameraFilmbackSettings Filmback;
	///<summary>LensSettings</summary>
	public FCameraLensSettings LensSettings;
	///<summary>FocusSettings</summary>
	public FCameraFocusSettings FocusSettings;
	///<summary>CurrentFocalLength</summary>
	public float CurrentFocalLength;
	///<summary>CurrentAperture</summary>
	public float CurrentAperture;
	///<summary>CurrentFocusDistance</summary>
	public float CurrentFocusDistance;
}
