#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeInfo.h")]
public partial class ULandscapeInfo : UObject {
// LandscapeInfo
	public TWeakObjectPtr<ALandscape> LandscapeActor;
	public FGuid LandscapeGuid;
	public int ComponentSizeQuads;
	public int SubsectionSizeQuads;
	public int ComponentNumSubsections;
	public FVector DrawScale;
	public TArray<FLandscapeInfoLayerSettings> Layers;
	public TArray<TWeakObjectPtr<ALandscapeStreamingProxy>> StreamingProxies;
	public TArray<object /*SplineActors*/> SplineActors;
}
