#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating SlateBrushAssets</summary>
[CppInclude("Factories/SlateBrushAssetFactory.h")]
public partial class USlateBrushAssetFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>An initial texture to assign to the newly created slate brush</summary>
	public UTexture2D InitialTexture;
}
