#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithCineCameraActorTemplate.h")]
public partial struct FDatasmithCameraLookatTrackingSettingsTemplate {
	public bool bEnableLookAtTracking;
	public bool bAllowRoll;
	public TSoftObjectPtr<AActor> ActorToTrack;
}
