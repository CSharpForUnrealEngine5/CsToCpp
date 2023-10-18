namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/MaterialFactoryNew.h")]
public partial class UMaterialFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>An initial texture to place in the newly created material</summary>
	public UTexture InitialTexture;
}
