#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Landscape.h")]
public partial struct FLandscapeLayer {
	public FGuid Guid;
	public string Name;
	public bool bVisible;
	public bool bLocked;
	public float HeightmapAlpha;
	public float WeightmapAlpha;
	public ELandscapeBlendMode BlendMode;
	public TArray<FLandscapeLayerBrush> Brushes;
	public TMap<ULandscapeLayerInfoObject,bool> WeightmapLayerAllocationBlend;
}
