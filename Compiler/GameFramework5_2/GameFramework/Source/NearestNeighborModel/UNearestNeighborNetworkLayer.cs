#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborOptimizedNetwork.h")]
///<summary>A general network layer that contains a list of parameters. The Run() method should be implemented by child classes</summary>
public partial class UNearestNeighborNetworkLayer : UObject {
// NearestNeighborNetworkLayer
	public int NumInputs;
	public int NumOutputs;
	public TArray<FNearestNeighborNetworkParameter> Parameters;
	public  void AddParameter(TArray<float> Values,TArray<int> Shape) {}
}
