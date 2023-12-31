namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionAntialiasedTextureMask.h")]
public partial class UMaterialExpressionAntialiasedTextureMask : UMaterialExpressionTextureSampleParameter2D {
	public static UClass StaticClass() {return default;}
	///<summary>Threshold</summary>
	public float Threshold;
	///<summary>Channel</summary>
	public ETextureColorChannel Channel;
}
