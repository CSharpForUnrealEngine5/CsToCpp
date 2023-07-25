#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Variant.h")]
public partial struct FVariantDependency {
// VariantDependency
	public TSoftObjectPtr<UVariantSet> VariantSet;
	public TSoftObjectPtr<UVariant> Variant;
	public bool bEnabled;
}
