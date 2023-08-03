#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGEditorSettings.h")]
public partial class UPCGEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default node color</summary>
	public FLinearColor DefaultNodeColor;
	///<summary>Instanced node body tint color</summary>
	public FLinearColor InstancedNodeBodyTintColor;
	///<summary>Color used for input &amp; output nodes</summary>
	public FLinearColor InputOutputNodeColor;
	///<summary>Color used for Difference, Intersection, Projection, Union</summary>
	public FLinearColor SetOperationNodeColor;
	///<summary>Color used for density remap</summary>
	public FLinearColor DensityOperationNodeColor;
	///<summary>Color used for blueprints</summary>
	public FLinearColor BlueprintNodeColor;
	///<summary>Color used for metadata operations</summary>
	public FLinearColor MetadataNodeColor;
	///<summary>Color used for filter-like operations</summary>
	public FLinearColor FilterNodeColor;
	///<summary>Color used for sampler operations</summary>
	public FLinearColor SamplerNodeColor;
	///<summary>Color used for artifact-generating operations</summary>
	public FLinearColor SpawnerNodeColor;
	///<summary>Color used for subgraph-like operations</summary>
	public FLinearColor SubgraphNodeColor;
	///<summary>Color used for Attribute Set operations</summary>
	public FLinearColor ParamDataNodeColor;
	///<summary>Color used for debug operations</summary>
	public FLinearColor DebugNodeColor;
	///<summary>Default pin color</summary>
	public FLinearColor DefaultPinColor;
	///<summary>Color used for spatial data pins</summary>
	public FLinearColor SpatialDataPinColor;
	///<summary>Color used for concrete/simple spatial data pins</summary>
	public FLinearColor ConcreteDataPinColor;
	///<summary>Color used for data pins of type Point</summary>
	public FLinearColor PointDataPinColor;
	///<summary>Color used for data pins of type Spline</summary>
	public FLinearColor PolyLineDataPinColor;
	///<summary>Color used for data pins of type Surface</summary>
	public FLinearColor SurfaceDataPinColor;
	///<summary>Color used for data pins of type Landscape</summary>
	public FLinearColor LandscapeDataPinColor;
	///<summary>Color used for data pins of type Texture</summary>
	public FLinearColor TextureDataPinColor;
	///<summary>Color used for data pins of type Render Target</summary>
	public FLinearColor RenderTargetDataPinColor;
	///<summary>Color used for data pins of type Volume</summary>
	public FLinearColor VolumeDataPinColor;
	///<summary>Color used for data pins of type Primitive</summary>
	public FLinearColor PrimitiveDataPinColor;
	///<summary>Color used for data pins of type Attribute Set</summary>
	public FLinearColor ParamDataPinColor;
	///<summary>Color used for other/unknown data types</summary>
	public FLinearColor UnknownDataPinColor;
	///<summary>User-driven color overrides</summary>
	public TMap<UClass,FLinearColor> OverrideNodeColorByClass;
	///<summary>Specify if we want to jump to definition in case of double click on native PCG Nodes</summary>
	public bool bEnableNavigateToNativeNodes;
}
