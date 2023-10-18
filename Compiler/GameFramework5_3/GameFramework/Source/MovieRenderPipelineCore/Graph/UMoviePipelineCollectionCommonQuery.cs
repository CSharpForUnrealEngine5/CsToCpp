namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides common actor querying functionality (names, tags, components, etc). These individual sub-queries can be</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineCollectionCommonQuery : UMoviePipelineCollectionQuery {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Add other common query operations (level, etc)</summary>
	public void SetActorNames(TArray<string> InActorNames) {}
	///<summary>SetTags</summary>
	public void SetTags(TArray<FName> InTags) {}
	///<summary>SetComponentTypes</summary>
	public void SetComponentTypes(TArray<UClass> InComponentTypes) {}
	///<summary>SetQueryMode</summary>
	public void SetQueryMode(EMoviePipelineCollectionCommonQueryMode InQueryMode) {}
	///<summary>DoesActorMatchQuery</summary>
	public virtual bool DoesActorMatchQuery(AActor Actor) { return default; }
	///<summary>ComponentTypes</summary>
	public TArray<UClass> ComponentTypes;
	///<summary>QueryMode</summary>
	public EMoviePipelineCollectionCommonQueryMode QueryMode;
	///<summary>ActorNames</summary>
	public TArray<string> ActorNames;
	///<summary>Tags</summary>
	public TArray<FName> Tags;
}
