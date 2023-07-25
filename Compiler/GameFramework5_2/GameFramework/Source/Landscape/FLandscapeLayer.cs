#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Landscape.h")]
public partial struct FLandscapeLayer {
// LandscapeLayer
	public FGuid Guid;
	public string Name;
	public bool bVisible;
	public bool bLocked;
	public float HeightmapAlpha;
	public float WeightmapAlpha;
	public byte BlendMode;
	public TArray<FLandscapeLayerBrush> Brushes;
	public TMap<ULandscapeLayerInfoObject,bool> WeightmapLayerAllocationBlend;
}
