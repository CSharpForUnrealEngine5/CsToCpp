namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlacementPaletteItem.h")]
public partial class UPlacementPaletteClient : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AssetPath</summary>
	public FSoftObjectPath AssetPath;
	///<summary>ClientGuid</summary>
	public FGuid ClientGuid;
	///<summary>SettingsObject</summary>
	public UInstancedPlacemenClientSettings SettingsObject;
	///<summary>FactoryInterface</summary>
	public object /*FactoryInterface*/ FactoryInterface;
}
