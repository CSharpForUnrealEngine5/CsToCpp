#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A mask is simply some storage for a physical mesh parameter painted onto clothing.</summary>
[CppInclude("PointWeightMap.h")]
public partial struct FPointWeightMap {
	public TArray<float> Values;
	public string Name;
	public byte CurrentTarget;
	public bool bEnabled;
}
