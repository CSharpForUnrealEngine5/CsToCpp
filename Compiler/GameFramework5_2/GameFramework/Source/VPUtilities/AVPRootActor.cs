namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AVPRootActor</summary>
[CppInclude("VPRootActor.h")]
public partial class AVPRootActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Actor used to show the size of the scene.</summary>
	public UMeshComponent RealWorldSceneRepresentation;
	///<summary>Actor used to show the size of the scene.</summary>
	public ACineCameraActor CinematicCamera;
	///<summary>bAreComponentsVisible</summary>
	public bool bAreComponentsVisible;
	///<summary>Billboard used to see the scene in the editor</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Arrow used to see the orientation of the scene in the editor</summary>
	public UArrowComponent ArrowComponent;
	///<summary>bMoveLevelWithActor</summary>
	public bool bMoveLevelWithActor;
	///<summary>Get the current camera used by the virtual production.</summary>
	public ACineCameraActor GetCineCameraActor() { return default; }
	///<summary>ToggleComponentsVisibility</summary>
	public void ToggleComponentsVisibility() {}
	///<summary>MoveLevelToRootActor</summary>
	public void MoveLevelToRootActor() {}
}
