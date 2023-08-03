#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A general network layer that contains a list of parameters. The Run() method should be implemented by child classes</summary>
[CppInclude("NearestNeighborOptimizedNetwork.h")]
public partial class UNearestNeighborNetworkLayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The weight matrix number of inputs (rows).</summary>
	public int NumInputs;
	///<summary>The weight matrix number of outputs (columns).</summary>
	public int NumOutputs;
	///<summary>The parameters of the layer</summary>
	public TArray<FNearestNeighborNetworkParameter> Parameters;
	///<summary>AddParameter</summary>
	public  void AddParameter(TArray<float> Values,TArray<int> Shape) {}
}
