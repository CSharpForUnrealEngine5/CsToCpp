namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureProperty.h")]
public partial class UMaterialExpressionTextureProperty : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Texture Object to access the property from.</summary>
	public FExpressionInput TextureObject;
	///<summary>Texture property to be accessed</summary>
	public EMaterialExposedTextureProperty Property;
}
