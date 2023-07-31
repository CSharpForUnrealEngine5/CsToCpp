#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Tile Struct which holds an array of remaining Options and its Shannon Entropy value</summary>
[CppInclude("WaveFunctionCollapseModel.h")]
public partial struct FWaveFunctionCollapseTile {
	public float ShannonEntropy;
	public TArray<FWaveFunctionCollapseOption> RemainingOptions;
}
