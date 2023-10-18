namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores information about which weightmap texture and channel each layer is stored</summary>
[CppInclude("LandscapeComponent.h")]
public partial struct FWeightmapLayerAllocationInfo {
	public ULandscapeLayerInfoObject LayerInfo;
	public byte WeightmapTextureIndex;
	public byte WeightmapTextureChannel;
}
