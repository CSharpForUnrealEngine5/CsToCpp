namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The specialized neural network for the MLDeformerModel.</summary>
[CppInclude("NearestNeighborOptimizedNetwork.h")]
public partial class UNearestNeighborOptimizedNetwork : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Clear the network, getting rid of all layers.</summary>
	public virtual void Empty() {}
	///<summary>Add a network layer.</summary>
	public UNearestNeighborNetworkLayer AddLayer(int LayerType) { return default; }
	///<summary>The network layers</summary>
	public TArray<UNearestNeighborNetworkLayer> Layers;
}
