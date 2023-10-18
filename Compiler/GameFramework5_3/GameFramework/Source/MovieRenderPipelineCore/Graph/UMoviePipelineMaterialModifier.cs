namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Modifies actor materials.</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineMaterialModifier : UMoviePipelineCollectionModifier {
	public static UClass StaticClass() {return default;}
	///<summary>SetMaterial</summary>
	public void SetMaterial(TSoftObjectPtr<UMaterialInterface> InMaterial) {}
	///<summary>ApplyModifier</summary>
	public virtual void ApplyModifier(UWorld World) {}
	///<summary>UndoModifier</summary>
	public virtual void UndoModifier() {}
	///<summary>MaterialToApply</summary>
	public TSoftObjectPtr<UMaterialInterface> MaterialToApply;
}
