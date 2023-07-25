#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyComponent.h")]
public partial struct FUnderwaterPostProcessSettings {
// UnderwaterPostProcessSettings
	public bool bEnabled;
	public float Priority;
	public float BlendRadius;
	public float BlendWeight;
	public FPostProcessSettings PostProcessSettings;
	public UMaterialInterface UnderwaterPostProcessMaterial_DEPRECATED;
}
