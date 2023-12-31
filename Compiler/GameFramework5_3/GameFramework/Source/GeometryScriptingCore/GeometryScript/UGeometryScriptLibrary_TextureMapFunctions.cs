namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/TextureMapFunctions.h")]
public partial class UGeometryScriptLibrary_TextureMapFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Samples the given TextureMap at the list of UV positions and returns the color at each position in ColorList output.</summary>
	public static void SampleTexture2DAtUVPositions(FGeometryScriptUVList UVList,UTexture2D Texture,FGeometryScriptSampleTextureOptions SampleOptions,FGeometryScriptColorList ColorList,UGeometryScriptDebug Debug/*=nullptr*/) {}
	///<summary>Sample the the given TextureMap at the list of UV positions and return the color at each position in ColorList output.</summary>
	public static void SampleTextureRenderTarget2DAtUVPositions(FGeometryScriptUVList UVList,UTextureRenderTarget2D Texture,FGeometryScriptSampleTextureOptions SampleOptions,FGeometryScriptColorList ColorList,UGeometryScriptDebug Debug/*=nullptr*/) {}
}
