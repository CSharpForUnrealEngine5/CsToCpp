#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRTrackingRefComponent.h")]
public partial class UDEPRECATED_USteamVRTrackingReferences : UActorComponent {
// USteamVRTrackingReferences
	public FComponentTrackingActivatedSignature OnTrackedDeviceActivated;
	public FComponentTrackingDeactivatedSignature OnTrackedDeviceDeactivated;
	public bool ShowTrackingReferences(UObject TrackingReferenceMesh) { return default; }
	public void HideTrackingReferences() {}
	public float ActiveDevicePollFrequency;
	public FVector TrackingReferenceScale;
	public TArray<UStaticMeshComponent> TrackingReferences;
}
