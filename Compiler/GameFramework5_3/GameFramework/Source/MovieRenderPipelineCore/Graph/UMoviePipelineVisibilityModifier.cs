namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Modifies actor visibility.</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineVisibilityModifier : UMoviePipelineCollectionModifier {
	public static UClass StaticClass() {return default;}
	///<summary>SetHidden</summary>
	public void SetHidden(bool bInIsHidden) {}
	///<summary>IsHidden</summary>
	public bool IsHidden() { return default; }
	///<summary>ApplyModifier</summary>
	public virtual void ApplyModifier(UWorld World) {}
	///<summary>UndoModifier</summary>
	public virtual void UndoModifier() {}
	///<summary>Maps an actor to its original hidden state.</summary>
	public TMap<TSoftObjectPtr<AActor>,bool> ModifiedActors;
	///<summary>bIsHidden</summary>
	public bool bIsHidden;
}
