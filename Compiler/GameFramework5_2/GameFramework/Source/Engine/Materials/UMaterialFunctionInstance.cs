#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialFunctionInstance.h")]
///<summary>A material function instance defines parameter overrides for a parent material function.</summary>
public partial class UMaterialFunctionInstance : UMaterialFunctionInterface {
// MaterialFunctionInstance
	public UMaterialFunctionInterface Parent;
	public UMaterialFunctionInterface Base;
	public TArray<FScalarParameterValue> ScalarParameterValues;
	public TArray<FVectorParameterValue> VectorParameterValues;
	public TArray<FDoubleVectorParameterValue> DoubleVectorParameterValues;
	public TArray<FTextureParameterValue> TextureParameterValues;
	public TArray<FFontParameterValue> FontParameterValues;
	public TArray<FStaticSwitchParameter> StaticSwitchParameterValues;
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameterValues;
	public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
	public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues;
	public UMaterialInstanceConstant PreviewMaterial;
}
