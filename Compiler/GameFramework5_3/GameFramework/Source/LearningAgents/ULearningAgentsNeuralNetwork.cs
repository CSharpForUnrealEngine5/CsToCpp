namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A neural network data asset.</summary>
[CppInclude("LearningAgentsNeuralNetwork.h")]
public partial class ULearningAgentsNeuralNetwork : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Resets this network asset to be empty.</summary>
	public void ResetNetwork() {}
	///<summary>Load this network from a snapshot.</summary>
	public void LoadNetworkFromSnapshot(FFilePath File) {}
	///<summary>Save this network into a snapshot.</summary>
	public void SaveNetworkToSnapshot(FFilePath File) {}
	///<summary>Copy another asset&#39;s network weights into this network. Network sizes must match.</summary>
	public void LoadNetworkFromAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Copy this network&#39;s weights to another asset. Network sizes must match.</summary>
	public void SaveNetworkToAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
}
