namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Storage for nanite material override.</summary>
[CppInclude("Materials/MaterialOverrideNanite.h")]
public partial struct FMaterialOverrideNanite {
	public TSoftObjectPtr<UMaterialInterface> OverrideMaterialRef;
	public bool bEnableOverride;
	public UMaterialInterface OverrideMaterial;
}
