#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialOverrideNanite.h")]
///<summary>Storage for nanite material override.</summary>
public partial struct FMaterialOverrideNanite {
// MaterialOverrideNanite
	public TSoftObjectPtr<UMaterialInterface> OverrideMaterialRef;
	public bool bEnableOverride;
	public UMaterialInterface OverrideMaterial;
}
