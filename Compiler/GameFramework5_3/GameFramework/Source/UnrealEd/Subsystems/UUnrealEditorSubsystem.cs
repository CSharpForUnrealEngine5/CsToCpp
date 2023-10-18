namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUnrealEditorSubsystem</summary>
[CppInclude("Subsystems/UnrealEditorSubsystem.h")]
public partial class UUnrealEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Gets information about the camera position for the primary level editor viewport.  In non-editor builds, these will be zeroed</summary>
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) { return default; }
	///<summary>Sets information about the camera position for the primary level editor viewport.</summary>
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	///<summary>Find the World in the world editor. It can then be used as WorldContext by other libraries like GameplayStatics.</summary>
	public UWorld GetEditorWorld() { return default; }
	///<summary>GetGameWorld</summary>
	public UWorld GetGameWorld() { return default; }
}
