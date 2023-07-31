#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureProperty.h")]
public partial class UMaterialExpressionTextureProperty : UMaterialExpression {
	///<summary>Texture Object to access the property from.</summary>
	public FExpressionInput TextureObject;
	///<summary>Texture property to be accessed</summary>
	public EMaterialExposedTextureProperty Property;
}
