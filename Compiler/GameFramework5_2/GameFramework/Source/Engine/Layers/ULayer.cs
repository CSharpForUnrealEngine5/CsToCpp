#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/Layer.h")]
public partial class ULayer : UObject {
// Layer
	public string LayerName;
	public bool bIsVisible;
	public TArray<FLayerActorStats> ActorStats;
}
