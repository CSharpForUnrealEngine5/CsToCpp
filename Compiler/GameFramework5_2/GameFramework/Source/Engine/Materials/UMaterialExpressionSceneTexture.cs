#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSceneTexture.h")]
public partial class UMaterialExpressionSceneTexture : UMaterialExpression {
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Which scene texture (screen aligned texture) we want to make a lookup into</summary>
	public ESceneTextureId SceneTextureId;
	///<summary>Whether to use point sampled texture lookup (default) or using [bi-linear] filtered (can be slower, avoid faceted lock with distortions), some SceneTextures cannot be filtered</summary>
	public bool bFiltered;
}
