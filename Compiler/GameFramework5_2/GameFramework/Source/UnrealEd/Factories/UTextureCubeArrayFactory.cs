#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating volume texture</summary>
[CppInclude("Factories/TextureCubeArrayFactory.h")]
public partial class UTextureCubeArrayFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>InitialTextures</summary>
	public TArray<UTextureCube> InitialTextures;
}
