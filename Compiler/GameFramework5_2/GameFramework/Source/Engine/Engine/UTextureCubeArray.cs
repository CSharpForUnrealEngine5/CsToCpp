namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureCubeArray.h")]
public partial class UTextureCubeArray : UTexture {
	public static UClass StaticClass() {return default;}
	///<summary>Add Textures</summary>
	public TArray<UTextureCube> SourceTextures;
	///<summary>Is set to true if the source texture was generated from the SourceTextures array</summary>
	public bool bSourceGeneratedFromSourceTexturesArray;
}
