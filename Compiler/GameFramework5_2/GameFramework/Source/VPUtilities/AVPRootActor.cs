#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPRootActor.h")]
///<summary>AVPRootActor</summary>
public partial class AVPRootActor : AActor {
// VPRootActor
	public UMeshComponent RealWorldSceneRepresentation;
	public ACineCameraActor CinematicCamera;
	public bool bAreComponentsVisible;
	public UBillboardComponent SpriteComponent;
	public UArrowComponent ArrowComponent;
	public bool bMoveLevelWithActor;
	public  ACineCameraActor GetCineCameraActor() { return default; }
	public  void ToggleComponentsVisibility() {}
	public  void MoveLevelToRootActor() {}
}
