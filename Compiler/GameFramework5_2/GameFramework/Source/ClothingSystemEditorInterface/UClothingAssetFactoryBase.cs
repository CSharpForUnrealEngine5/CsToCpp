namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Clothing asset factories should inherit this interface/uobject to provide functionality</summary>
[CppInclude("ClothingAssetFactoryInterface.h")]
public partial class UClothingAssetFactoryBase : UObject {
	public static UClass StaticClass() {return default;}
}
