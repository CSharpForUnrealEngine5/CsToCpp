#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExternalTextureMaterialExpression.h")]
///<summary>Implements a node sampling from the ARKit Passthrough external textures.</summary>
public partial class UDEPRECATED_MaterialExpressionARKitPassthroughCamera : UMaterialExpression {
// MaterialExpressionARKitPassthroughCamera
	public FExpressionInput Coordinates;
	public uint ConstCoordinate;
	public EARKitTextureType TextureType;
}
