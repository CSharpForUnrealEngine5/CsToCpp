#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material function instance defines parameter overrides for a parent material function.</summary>
[CppInclude("Materials/MaterialFunctionInstance.h")]
public partial class UMaterialFunctionInstance : UMaterialFunctionInterface {
	///<summary>Parent function.</summary>
	public UMaterialFunctionInterface Parent;
	///<summary>Base function.</summary>
	public UMaterialFunctionInterface Base;
	///<summary>Scalar parameters.</summary>
	public TArray<FScalarParameterValue> ScalarParameterValues;
	///<summary>Vector parameters.</summary>
	public TArray<FVectorParameterValue> VectorParameterValues;
	///<summary>DoubleVector parameters.</summary>
	public TArray<FDoubleVectorParameterValue> DoubleVectorParameterValues;
	///<summary>Texture parameters.</summary>
	public TArray<FTextureParameterValue> TextureParameterValues;
	///<summary>Font parameters.</summary>
	public TArray<FFontParameterValue> FontParameterValues;
	///<summary>Static switch parameters.</summary>
	public TArray<FStaticSwitchParameter> StaticSwitchParameterValues;
	///<summary>Static component mask parameters.</summary>
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameterValues;
	///<summary>Runtime virtual texture parameters.</summary>
	public TArray<FRuntimeVirtualTextureParameterValue> RuntimeVirtualTextureParameterValues;
	///<summary>Sparse volume texture parameters.</summary>
	public TArray<FSparseVolumeTextureParameterValue> SparseVolumeTextureParameterValues;
	///<summary>PreviewMaterial</summary>
	public UMaterialInstanceConstant PreviewMaterial;
}
