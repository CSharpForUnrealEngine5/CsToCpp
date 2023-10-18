namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides a means of assembling modifiers together to generate a desired view of a scene.</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineRenderLayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetRenderLayerName</summary>
	public string GetRenderLayerName() { return default; }
	///<summary>SetRenderLayerName</summary>
	public void SetRenderLayerName(string NewName) {}
	///<summary>GetCollectionByName</summary>
	public UMoviePipelineCollection GetCollectionByName(string Name) { return default; }
	///<summary>AddModifier</summary>
	public void AddModifier(UMoviePipelineCollectionModifier Modifier) {}
	///<summary>GetModifiers</summary>
	public TArray<UMoviePipelineCollectionModifier> GetModifiers() { return default; }
	///<summary>RemoveModifier</summary>
	public void RemoveModifier(UMoviePipelineCollectionModifier Modifier) {}
	///<summary>Preview</summary>
	public void Preview(UWorld World) {}
	///<summary>UndoPreview</summary>
	public void UndoPreview(UWorld World) {}
	///<summary>The name of this render layer.</summary>
	public string RenderLayerName;
	///<summary>The modifiers that are active when this render layer is active.</summary>
	public TArray<UMoviePipelineCollectionModifier> Modifiers;
}
