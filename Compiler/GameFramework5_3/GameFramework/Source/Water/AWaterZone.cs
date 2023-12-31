namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterZoneActor.h")]
public partial class AWaterZone : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>WaterInfoTexture</summary>
	public UTextureRenderTarget2D WaterInfoTexture;
	///<summary>ForceUpdateWaterInfoTexture</summary>
	public void ForceUpdateWaterInfoTexture() {}
	///<summary>OwnedWaterBodies</summary>
	public TArray<TWeakObjectPtr<UWaterBodyComponent>> OwnedWaterBodies;
	///<summary>RenderTargetResolution</summary>
	public FIntPoint RenderTargetResolution;
	///<summary>The water mesh component</summary>
	public UWaterMeshComponent WaterMesh;
	///<summary>Width of the zone bounding box</summary>
	public FVector2D ZoneExtent;
	///<summary>Offsets the height above the water zone at which the WaterInfoTexture is rendered. This is applied after computing the maximum Z of all the water bodies within the zone.</summary>
	public float CaptureZOffset;
	///<summary>Determines if the WaterInfoTexture should be 16 or 32 bits per channel</summary>
	public bool bHalfPrecisionTexture;
	///<summary>Radius of the velocity blur in the finalize water info pass</summary>
	public int VelocityBlurRadius;
	///<summary>Higher number is higher priority. If Water Zones overlap and a water body does not have a manual water zone override, this priority will be used when automatically assigning the zone.</summary>
	public int OverlapPriority;
	///<summary>bEnableLocalOnlyTessellation</summary>
	public bool bEnableLocalOnlyTessellation;
	///<summary>LocalTessellationExtent</summary>
	public FVector LocalTessellationExtent;
	///<summary>A manipulatable box for visualizing/editing the water zone bounds</summary>
	public UBoxComponent BoundsComponent;
	///<summary>SelectedWaterBodies</summary>
	public TArray<TWeakObjectPtr<AWaterBody>> SelectedWaterBodies;
	///<summary>ActorIcon</summary>
	public UBillboardComponent ActorIcon;
	///<summary>Deprecated UPROPERTIES</summary>
	public UTexture2D WaterVelocityTexture_DEPRECATED;
	///<summary>TessellatedWaterMeshExtent_DEPRECATED</summary>
	public FVector TessellatedWaterMeshExtent_DEPRECATED;
	///<summary>bEnableNonTesselatedLODMesh_DEPRECATED</summary>
	public bool bEnableNonTesselatedLODMesh_DEPRECATED;
}
