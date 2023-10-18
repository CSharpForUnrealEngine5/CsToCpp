namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating volume texture</summary>
[CppInclude("Factories/Texture2DArrayFactory.h")]
public partial class UTexture2DArrayFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>InitialTextures</summary>
	public TArray<UTexture2D> InitialTextures;
}
