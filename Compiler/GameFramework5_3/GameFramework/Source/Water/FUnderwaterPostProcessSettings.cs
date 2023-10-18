namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyComponent.h")]
public partial struct FUnderwaterPostProcessSettings {
	public bool bEnabled;
	public float Priority;
	public float BlendRadius;
	public float BlendWeight;
	public FPostProcessSettings PostProcessSettings;
	public UMaterialInterface UnderwaterPostProcessMaterial_DEPRECATED;
}
