namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material expression for sampling from a runtime virtual texture.</summary>
[CppInclude("Materials/MaterialExpressionSparseVolumeTextureSample.h")]
public partial class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>3D texture coordinate used to sample the sparse volume texture.</summary>
	public FExpressionInput Coordinates;
	///<summary>The Sparse Virtual Texture to sample.</summary>
	public USparseVolumeTexture SparseVolumeTexture;
}
