namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for providing actor modification functionality via collections.</summary>
[CppInclude("Graph/MoviePipelineRenderLayerSubsystem.h")]
public partial class UMoviePipelineCollectionModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a collection to the existing set of collections in this modifier.</summary>
	public void AddCollection(UMoviePipelineCollection Collection) {}
	///<summary>Overwrites the existing collections with the provided array of collections.</summary>
	public void SetCollections(TArray<UMoviePipelineCollection> InCollections) {}
	///<summary>GetCollections</summary>
	public TArray<UMoviePipelineCollection> GetCollections() { return default; }
	///<summary>SetIsInverted</summary>
	public void SetIsInverted(bool bIsInverted) {}
	///<summary>IsInverted</summary>
	public bool IsInverted() { return default; }
	///<summary>The collections which this modifier will operate on.</summary>
	public TArray<UMoviePipelineCollection> Collections;
	///<summary>Whether an inverted collection of actors should be used.</summary>
	public bool bUseInvertedActors;
}
