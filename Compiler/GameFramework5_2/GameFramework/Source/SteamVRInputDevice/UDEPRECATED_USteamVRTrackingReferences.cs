namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRTrackingRefComponent.h")]
public partial class UDEPRECATED_USteamVRTrackingReferences : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>OnTrackedDeviceActivated</summary>
	public FComponentTrackingActivatedSignature OnTrackedDeviceActivated;
	///<summary>OnTrackedDeviceDeactivated</summary>
	public FComponentTrackingDeactivatedSignature OnTrackedDeviceDeactivated;
	///<summary>ShowTrackingReferences</summary>
	public bool ShowTrackingReferences(UStaticMesh TrackingReferenceMesh) { return default; }
	///<summary>HideTrackingReferences</summary>
	public void HideTrackingReferences() {}
	///<summary>ActiveDevicePollFrequency</summary>
	public float ActiveDevicePollFrequency;
	///<summary>TrackingReferenceScale</summary>
	public FVector TrackingReferenceScale;
	///<summary>TrackingReferences</summary>
	public TArray<UStaticMeshComponent> TrackingReferences;
}
