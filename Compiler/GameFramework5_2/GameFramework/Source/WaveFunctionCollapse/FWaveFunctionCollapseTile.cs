#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseModel.h")]
///<summary>Base Tile Struct which holds an array of remaining Options and its Shannon Entropy value</summary>
public partial struct FWaveFunctionCollapseTile {
// WaveFunctionCollapseTile
	public float ShannonEntropy;
	public TArray<FWaveFunctionCollapseOption> RemainingOptions;
}
