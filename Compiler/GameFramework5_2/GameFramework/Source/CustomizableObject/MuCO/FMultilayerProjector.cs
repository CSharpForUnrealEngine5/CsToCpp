#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/MultilayerProjector.h")]
///<summary>Multilayer Projector Helper. Eases the management of Layers and Virtual Layers.</summary>
public partial struct FMultilayerProjector {
// MultilayerProjector
	public string ParamName;
	public TMap<string,int> VirtualLayersMapping;
	public TMap<string,int> VirtualLayersOrder;
	public TMap<string,FMultilayerProjectorLayer> DisableVirtualLayers;
}
