namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSparseVolumeTextureBase.h")]
public partial class UMaterialExpressionSparseVolumeTextureBase : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The Sparse Virtual Texture to sample.</summary>
	public USparseVolumeTexture SparseVolumeTexture;
}
