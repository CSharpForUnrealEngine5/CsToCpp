#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraActor.h")]
///<summary>A CameraActor is a camera viewpoint that can be placed in a level.</summary>
public partial class ACameraActor : AActor {
// CameraActor
	public byte AutoActivateForPlayer;
	public UCameraComponent CameraComponent;
	public USceneComponent SceneComponent;
	public int GetAutoActivatePlayerIndex() { return default; }
	public bool bConstrainAspectRatio_DEPRECATED;
	public float AspectRatio_DEPRECATED;
	public float FOVAngle_DEPRECATED;
	public float PostProcessBlendWeight_DEPRECATED;
	public FPostProcessSettings PostProcessSettings_DEPRECATED;
}
