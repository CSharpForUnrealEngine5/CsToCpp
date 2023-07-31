#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a node sampling from the ARKit Passthrough external textures.</summary>
[CppInclude("ExternalTextureMaterialExpression.h")]
public partial class UDEPRECATED_MaterialExpressionARKitPassthroughCamera : UMaterialExpression {
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Only used if Coordinates is not hooked up</summary>
	public uint ConstCoordinate;
	///<summary>TextureType</summary>
	public EARKitTextureType TextureType;
}
