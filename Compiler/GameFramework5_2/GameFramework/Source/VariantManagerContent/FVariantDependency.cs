namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Variant.h")]
public partial struct FVariantDependency {
	public TSoftObjectPtr<UVariantSet> VariantSet;
	public TSoftObjectPtr<UVariant> Variant;
	public bool bEnabled;
}
