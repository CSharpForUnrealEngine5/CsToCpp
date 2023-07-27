#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterZoneActor.h")]
public partial class AWaterZone : AActor {
// WaterZone
	public UTextureRenderTarget2D WaterInfoTexture;
	public  void ForceUpdateWaterInfoTexture() {}
	public TArray<TWeakObjectPtr<UWaterBodyComponent>> OwnedWaterBodies;
	public FIntPoint RenderTargetResolution;
	public UWaterMeshComponent WaterMesh;
	public FVector2D ZoneExtent;
	public float CaptureZOffset;
	public bool bHalfPrecisionTexture;
	public int VelocityBlurRadius;
	public FVector TessellatedWaterMeshExtent;
	public uint NonTessellatedLODSectionScale;
	public int OverlapPriority;
	public bool bEnableNonTessellatedLODMesh;
	public UBoxComponent BoundsComponent;
	public TArray<TWeakObjectPtr<AWaterBody>> SelectedWaterBodies;
	public UBillboardComponent ActorIcon;
	public UTexture2D WaterVelocityTexture_DEPRECATED;
}
