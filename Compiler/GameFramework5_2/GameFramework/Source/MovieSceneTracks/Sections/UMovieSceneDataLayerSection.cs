#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneDataLayerSection.h")]
public partial class UMovieSceneDataLayerSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>GetDesiredState</summary>
	public  EDataLayerRuntimeState GetDesiredState() { return default; }
	///<summary>SetDesiredState</summary>
	public  void SetDesiredState(EDataLayerRuntimeState InDesiredState) {}
	///<summary>GetPrerollState</summary>
	public  EDataLayerRuntimeState GetPrerollState() { return default; }
	///<summary>SetPrerollState</summary>
	public  void SetPrerollState(EDataLayerRuntimeState InPrerollState) {}
	///<summary>GetFlushOnUnload</summary>
	public  bool GetFlushOnUnload() { return default; }
	///<summary>SetFlushOnUnload</summary>
	public  void SetFlushOnUnload(bool bFlushOnUnload) {}
	///<summary>GetDataLayerAssets</summary>
	public  TArray<UDataLayerAsset> GetDataLayerAssets() { return default; }
	///<summary>SetDataLayerAssets</summary>
	public  void SetDataLayerAssets(TArray<UDataLayerAsset> InDataLayerAssets) {}
	///<summary>GetDataLayers</summary>
	public  TArray<FActorDataLayer> GetDataLayers() { return default; }
	///<summary>SetDataLayers</summary>
	public  void SetDataLayers(TArray<FActorDataLayer> InDataLayers) {}
	///<summary>DataLayers</summary>
	public TArray<FActorDataLayer> DataLayers;
	///<summary>A list of data layers that should be loaded or unloaded by this section</summary>
	public TArray<UDataLayerAsset> DataLayerAssets;
	///<summary>The desired state for the data layers on this section when the section is actively evaluating.</summary>
	public EDataLayerRuntimeState DesiredState;
	///<summary>The desired state for the data layers on this section when the section is pre or post-rolling.</summary>
	public EDataLayerRuntimeState PrerollState;
	///<summary>Determine if we need to flush level streaming when the data layers unloads.</summary>
	public bool bFlushOnUnload;
}
