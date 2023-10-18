namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a collection of actors via provided queries.</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineCollection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetMatchingActors</summary>
	public TArray<AActor> GetMatchingActors(UWorld World,bool bInvertResult/*=false*/) { return default; }
	///<summary>AddQuery</summary>
	public void AddQuery(UMoviePipelineCollectionQuery Query) {}
	///<summary>SetCollectionName</summary>
	public void SetCollectionName(string InName) {}
	///<summary>GetCollectionName</summary>
	public string GetCollectionName() { return default; }
	///<summary>CollectionName</summary>
	public string CollectionName;
	///<summary>Queries</summary>
	public TArray<UMoviePipelineCollectionQuery> Queries;
}
