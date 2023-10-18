namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithCineCameraActorTemplate.h")]
public partial struct FDatasmithCameraLookatTrackingSettingsTemplate {
	public bool bEnableLookAtTracking;
	public bool bAllowRoll;
	public TSoftObjectPtr<AActor> ActorToTrack;
}
