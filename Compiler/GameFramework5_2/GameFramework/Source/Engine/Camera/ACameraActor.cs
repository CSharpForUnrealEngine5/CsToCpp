#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A CameraActor is a camera viewpoint that can be placed in a level.</summary>
[CppInclude("Camera/CameraActor.h")]
public partial class ACameraActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies which player controller, if any, should automatically use this Camera when the controller is active.</summary>
	public EAutoReceiveInput AutoActivateForPlayer;
	///<summary>The camera component for this camera</summary>
	public UCameraComponent CameraComponent;
	///<summary>SceneComponent</summary>
	public USceneComponent SceneComponent;
	///<summary>Returns index of the player for whom we auto-activate, or INDEX_NONE (-1) if disabled.</summary>
	public  int GetAutoActivatePlayerIndex() { return default; }
	///<summary>bConstrainAspectRatio_DEPRECATED</summary>
	public bool bConstrainAspectRatio_DEPRECATED;
	///<summary>AspectRatio_DEPRECATED</summary>
	public float AspectRatio_DEPRECATED;
	///<summary>FOVAngle_DEPRECATED</summary>
	public float FOVAngle_DEPRECATED;
	///<summary>PostProcessBlendWeight_DEPRECATED</summary>
	public float PostProcessBlendWeight_DEPRECATED;
	///<summary>PostProcessSettings_DEPRECATED</summary>
	public FPostProcessSettings PostProcessSettings_DEPRECATED;
}
