namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/Texture2dFactoryNew.h")]
public partial class UTexture2DFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>width of new texture</summary>
	public int Width;
	///<summary>height of new texture</summary>
	public int Height;
}
