#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Model of WFC constraints.</summary>
[CppInclude("WaveFunctionCollapseModel.h")]
public partial class UWaveFunctionCollapseModel : UDataAsset {
	///<summary>Grid Tile Size in cm^3</summary>
	public float TileSize;
	///<summary>Constraints</summary>
	public TMap<FWaveFunctionCollapseOption,FWaveFunctionCollapseAdjacencyToOptionsMap> Constraints;
	///<summary>SpawnExclusion</summary>
	public TArray<FSoftObjectPath> SpawnExclusion;
	///<summary>Create a constraint</summary>
	public  void AddConstraint(FWaveFunctionCollapseOption KeyOption,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption AdjacentOption) {}
	///<summary>Get all options for a given key option in a given adjacency</summary>
	public  FWaveFunctionCollapseOptions GetOptions(FWaveFunctionCollapseOption KeyOption,EWaveFunctionCollapseAdjacency Adjacency) { return default; }
	///<summary>Set the weights of key objects based on their contribution values</summary>
	public  void SetWeightsFromContributions() {}
	///<summary>Set the weights of key objects to a given value</summary>
	public  void SetAllWeights(float Weight) {}
	///<summary>Set the contribution values of key objects to a given value</summary>
	public  void SetAllContributions(int Contribution) {}
	///<summary>Set the contribution value of a key object to a given value</summary>
	public  void SetOptionContribution(FWaveFunctionCollapseOption Option,int Contribution) {}
	///<summary>Get the weight value of an option</summary>
	public  float GetOptionWeight(FWaveFunctionCollapseOption Option) { return default; }
	///<summary>Get the contribution value of an option</summary>
	public  int GetOptionContribution(FWaveFunctionCollapseOption Option) { return default; }
	///<summary>Get the total count of constraints in this model</summary>
	public  int GetConstraintCount() { return default; }
	///<summary>Swap meshes in the model with other meshes based on a map.</summary>
	public  void SwapMeshes(TMap<UStaticMesh,UStaticMesh> SourceToTargetMeshMap) {}
}
