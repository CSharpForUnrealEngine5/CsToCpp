namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeBlueprintBrushBase.h")]
public partial class ALandscapeBlueprintBrushBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>OwningLandscape</summary>
	public ALandscape OwningLandscape;
	///<summary>UpdateOnPropertyChange</summary>
	public bool UpdateOnPropertyChange;
	///<summary>AffectHeightmap</summary>
	public bool AffectHeightmap;
	///<summary>AffectWeightmap</summary>
	public bool AffectWeightmap;
	///<summary>AffectedWeightmapLayers</summary>
	public TArray<FName> AffectedWeightmapLayers;
	///<summary>bIsVisible</summary>
	public bool bIsVisible;
	///<summary>Render</summary>
	public UTextureRenderTarget2D Render(bool InIsHeightmap,UTextureRenderTarget2D InCombinedResult,FName InWeightmapLayerName) { return default; }
	///<summary>Initialize</summary>
	public void Initialize(FTransform InLandscapeTransform,FIntPoint InLandscapeSize,FIntPoint InLandscapeRenderTargetSize) {}
	///<summary>RequestLandscapeUpdate</summary>
	public void RequestLandscapeUpdate(bool bInUserTriggered/*=false*/) {}
	///<summary>GetBlueprintRenderDependencies</summary>
	public void GetBlueprintRenderDependencies(TArray<UObject> OutStreamableAssets) {}
}
