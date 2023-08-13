namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class to load the optimized network from disk.</summary>
[CppInclude("NearestNeighborOptimizedNetworkLoader.h")]
public partial class UNearestNeighborOptimizedNetworkLoader : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>LoadOptimizedNetwork</summary>
	public bool LoadOptimizedNetwork(string OnnxPath) { return default; }
	///<summary>DoesMeetPrerequisites</summary>
	public bool DoesMeetPrerequisites() { return default; }
	///<summary>GetOptimizedNetwork</summary>
	public UNearestNeighborOptimizedNetwork GetOptimizedNetwork() { return default; }
}
