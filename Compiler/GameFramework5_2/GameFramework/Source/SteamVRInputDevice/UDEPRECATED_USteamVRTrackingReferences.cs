#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRTrackingRefComponent.h")]
public partial class UDEPRECATED_USteamVRTrackingReferences : UActorComponent {
	///<summary>OnTrackedDeviceActivated</summary>
	public FComponentTrackingActivatedSignature OnTrackedDeviceActivated;
	///<summary>OnTrackedDeviceDeactivated</summary>
	public FComponentTrackingDeactivatedSignature OnTrackedDeviceDeactivated;
	///<summary>ShowTrackingReferences</summary>
	public  bool ShowTrackingReferences(UStaticMesh TrackingReferenceMesh) { return default; }
	///<summary>HideTrackingReferences</summary>
	public  void HideTrackingReferences() {}
	///<summary>ActiveDevicePollFrequency</summary>
	public float ActiveDevicePollFrequency;
	///<summary>TrackingReferenceScale</summary>
	public FVector TrackingReferenceScale;
	///<summary>TrackingReferences</summary>
	public TArray<UStaticMeshComponent> TrackingReferences;
}
