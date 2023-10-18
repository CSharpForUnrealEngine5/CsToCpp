namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Landscape.h")]
public partial struct FLandscapeLayer {
	public FGuid Guid;
	public FName Name;
	public bool bVisible;
	public bool bLocked;
	public float HeightmapAlpha;
	public float WeightmapAlpha;
	public ELandscapeBlendMode BlendMode;
	public TArray<FLandscapeLayerBrush> Brushes;
	public TMap<ULandscapeLayerInfoObject,bool> WeightmapLayerAllocationBlend;
}
