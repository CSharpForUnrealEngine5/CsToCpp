namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An interface object for any clothing asset the engine can use.</summary>
[CppInclude("ClothingAssetBase.h")]
public partial class UClothingAssetBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If this asset was imported from a file, this will be the original path</summary>
	public string ImportedFilePath;
	///<summary>Guid to identify this asset. Will be embedded into chunks that are created using this asset</summary>
	public FGuid AssetGuid;
}
