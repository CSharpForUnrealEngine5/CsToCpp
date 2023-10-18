namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The primary means of controlling render layers in MRQ. Render layers can be added/registered with the subsystem, then</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineRenderLayerSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Get this subsystem for a specific world. Handy for use from Python.</summary>
	public static UMoviePipelineRenderLayerSubsystem GetFromWorld(UWorld World) { return default; }
	///<summary>Clear out all tracked render layers and collections.</summary>
	public void Reset() {}
	///<summary>Adds a render layer to the system, which can later be made active by SetActiveRenderLayer*(). Returns true</summary>
	public bool AddRenderLayer(UMoviePipelineRenderLayer RenderLayer) { return default; }
	///<summary>GetRenderLayers</summary>
	public TArray<UMoviePipelineRenderLayer> GetRenderLayers() { return default; }
	///<summary>RemoveRenderLayer</summary>
	public void RemoveRenderLayer(string RenderLayerName) {}
	///<summary>GetActiveRenderLayer</summary>
	public UMoviePipelineRenderLayer GetActiveRenderLayer() { return default; }
	///<summary>Previews the layer with the given name. The layer needs to have been registered with AddRenderLayer().</summary>
	public void SetActiveRenderLayerByName(string RenderLayerName) {}
	///<summary>Previews the given layer. The layer does not need to have been registered with AddRenderLayer().</summary>
	public void SetActiveRenderLayerByObj(UMoviePipelineRenderLayer RenderLayer) {}
	///<summary>ClearActiveRenderLayer</summary>
	public void ClearActiveRenderLayer() {}
	///<summary>PreviewCollection</summary>
	public void PreviewCollection(UMoviePipelineCollection Collection) {}
	///<summary>ClearCollectionPreview</summary>
	public void ClearCollectionPreview() {}
	///<summary>PreviewModifier</summary>
	public void PreviewModifier(UMoviePipelineCollectionModifier Modifier) {}
	///<summary>ClearModifierPreview</summary>
	public void ClearModifierPreview() {}
	///<summary>Render layers which have been added/registered with the subsystem. These can be found by name.</summary>
	public TArray<UMoviePipelineRenderLayer> RenderLayers;
	///<summary>The render layer that is currently being viewed/previewed.</summary>
	public UMoviePipelineRenderLayer ActiveRenderLayer;
	///<summary>The collection that is currently being viewed/previewed.</summary>
	public UMoviePipelineCollection ActiveCollection;
	///<summary>The modifier that is currently being viewed/previewed.</summary>
	public UMoviePipelineCollectionModifier ActiveModifier;
	///<summary>A render layer dedicated to visualizing collections and modifiers.</summary>
	public UMoviePipelineRenderLayer VisualizationRenderLayer;
	///<summary>Empty collection used for visualization purposes (in conjunction w/ the viz render layer).</summary>
	public UMoviePipelineCollection VisualizationEmptyCollection;
	///<summary>A modifier used for visualization purposes (to hide the entire world).</summary>
	public UMoviePipelineVisibilityModifier VisualizationModifier_HideWorld;
	///<summary>A modifier used for visualization purposes (to show collections used with the modifier).</summary>
	public UMoviePipelineVisibilityModifier VisualizationModifier_VisibleCollections;
}
