#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSparseVolumeTextureSample.h")]
///<summary>Material expression for sampling from a runtime virtual texture.</summary>
public partial class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpression {
// MaterialExpressionSparseVolumeTextureSample
	public FExpressionInput Coordinates;
	public USparseVolumeTexture SparseVolumeTexture;
}
