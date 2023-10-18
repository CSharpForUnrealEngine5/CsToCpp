namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeInfo.h")]
public partial class ULandscapeInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LandscapeActor</summary>
	public TWeakObjectPtr<ALandscape> LandscapeActor;
	///<summary>LandscapeGuid</summary>
	public FGuid LandscapeGuid;
	///<summary>ComponentSizeQuads</summary>
	public int ComponentSizeQuads;
	///<summary>SubsectionSizeQuads</summary>
	public int SubsectionSizeQuads;
	///<summary>ComponentNumSubsections</summary>
	public int ComponentNumSubsections;
	///<summary>DrawScale</summary>
	public FVector DrawScale;
	///<summary>Layers</summary>
	public TArray<FLandscapeInfoLayerSettings> Layers;
	///<summary>RegionSizeInComponents</summary>
	public int RegionSizeInComponents;
	///<summary>StreamingProxies</summary>
	public TArray<TWeakObjectPtr<ALandscapeStreamingProxy>> StreamingProxies;
	///<summary>SORTED list of all actors implementing the spline interface that are registered with this landscape info</summary>
	public TArray<object /*SplineActors*/> SplineActors;
}
