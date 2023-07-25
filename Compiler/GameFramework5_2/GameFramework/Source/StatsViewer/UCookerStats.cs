#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CookerStats.h")]
///<summary>Statistics for a cooked asset.</summary>
public partial class UCookerStats : UObject {
// CookerStats
	public TArray<TWeakObjectPtr<UObject>> Assets;
	public float SizeBefore;
	public float SizeAfter;
	public string Path;
}
