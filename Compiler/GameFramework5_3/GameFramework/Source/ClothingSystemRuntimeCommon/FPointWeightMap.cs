namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A mask is simply some storage for a physical mesh parameter painted onto clothing.</summary>
[CppInclude("PointWeightMap.h")]
public partial struct FPointWeightMap {
	public TArray<float> Values;
	public FName Name;
	public byte CurrentTarget;
	public bool bEnabled;
}
