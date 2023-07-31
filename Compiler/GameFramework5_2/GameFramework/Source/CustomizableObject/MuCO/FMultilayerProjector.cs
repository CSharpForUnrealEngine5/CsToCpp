#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multilayer Projector Helper. Eases the management of Layers and Virtual Layers.</summary>
[CppInclude("MuCO/MultilayerProjector.h")]
public partial struct FMultilayerProjector {
	public string ParamName;
	public TMap<string,int> VirtualLayersMapping;
	public TMap<string,int> VirtualLayersOrder;
	public TMap<string,FMultilayerProjectorLayer> DisableVirtualLayers;
}
