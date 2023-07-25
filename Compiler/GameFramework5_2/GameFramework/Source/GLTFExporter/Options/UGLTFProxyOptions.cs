#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Options/GLTFProxyOptions.h")]
public partial class UGLTFProxyOptions : UObject {
// GLTFProxyOptions
	public bool bBakeMaterialInputs;
	public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize;
	public byte DefaultMaterialBakeFilter;
	public byte DefaultMaterialBakeTiling;
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings;
	public void ResetToDefault() {}
}
