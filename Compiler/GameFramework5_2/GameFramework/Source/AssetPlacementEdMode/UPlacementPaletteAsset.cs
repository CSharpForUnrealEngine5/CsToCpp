namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlacementPaletteAsset.h")]
public partial class UPlacementPaletteAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PaletteItems</summary>
	public TArray<UPlacementPaletteClient> PaletteItems;
	///<summary>GridGuid</summary>
	public FGuid GridGuid;
}
