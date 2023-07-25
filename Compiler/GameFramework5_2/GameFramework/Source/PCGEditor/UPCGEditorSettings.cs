#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGEditorSettings.h")]
public partial class UPCGEditorSettings : UObject {
// PCGEditorSettings
	public FLinearColor DefaultNodeColor;
	public FLinearColor InstancedNodeBodyTintColor;
	public FLinearColor InputOutputNodeColor;
	public FLinearColor SetOperationNodeColor;
	public FLinearColor DensityOperationNodeColor;
	public FLinearColor BlueprintNodeColor;
	public FLinearColor MetadataNodeColor;
	public FLinearColor FilterNodeColor;
	public FLinearColor SamplerNodeColor;
	public FLinearColor SpawnerNodeColor;
	public FLinearColor SubgraphNodeColor;
	public FLinearColor ParamDataNodeColor;
	public FLinearColor DebugNodeColor;
	public FLinearColor DefaultPinColor;
	public FLinearColor SpatialDataPinColor;
	public FLinearColor ConcreteDataPinColor;
	public FLinearColor PointDataPinColor;
	public FLinearColor PolyLineDataPinColor;
	public FLinearColor SurfaceDataPinColor;
	public FLinearColor LandscapeDataPinColor;
	public FLinearColor TextureDataPinColor;
	public FLinearColor RenderTargetDataPinColor;
	public FLinearColor VolumeDataPinColor;
	public FLinearColor PrimitiveDataPinColor;
	public FLinearColor ParamDataPinColor;
	public FLinearColor UnknownDataPinColor;
	public TMap<UClass,FLinearColor> OverrideNodeColorByClass;
	public bool bEnableNavigateToNativeNodes;
}
