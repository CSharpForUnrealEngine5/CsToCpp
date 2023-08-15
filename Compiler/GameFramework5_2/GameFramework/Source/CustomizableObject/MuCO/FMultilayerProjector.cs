namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multilayer Projector Helper. Eases the management of Layers and Virtual Layers.</summary>
[CppInclude("MuCO/MultilayerProjector.h")]
public partial struct FMultilayerProjector {
	public FName ParamName;
	public TMap<FName,int> VirtualLayersMapping;
	public TMap<FName,int> VirtualLayersOrder;
	public TMap<FName,FMultilayerProjectorLayer> DisableVirtualLayers;
}
