namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Storage for nanite material override.</summary>
[CppInclude("Materials/MaterialOverrideNanite.h")]
public partial struct FMaterialOverrideNanite {
	public bool bEnableOverride;
	public UMaterialInterface OverrideMaterialEditor;
	public UMaterialInterface OverrideMaterial;
	public TSoftObjectPtr<UMaterialInterface> OverrideMaterialRef;
}
