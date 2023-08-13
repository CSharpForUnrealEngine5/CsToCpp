namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines which source assets to add and conditions for adding</summary>
[CppInclude("GameFeatureAction_DataRegistrySource.h")]
public partial struct FDataRegistrySourceToAdd {
	public string RegistryToAddTo;
	public int AssetPriority;
	public bool bClientSource;
	public bool bServerSource;
	public TSoftObjectPtr<UDataTable> DataTableToAdd;
	public TSoftObjectPtr<UCurveTable> CurveTableToAdd;
}
