#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
///<summary>Stores information about which weightmap texture and channel each layer is stored</summary>
public partial struct FWeightmapLayerAllocationInfo {
// WeightmapLayerAllocationInfo
	public ULandscapeLayerInfoObject LayerInfo;
	public byte WeightmapTextureIndex;
	public byte WeightmapTextureChannel;
}
