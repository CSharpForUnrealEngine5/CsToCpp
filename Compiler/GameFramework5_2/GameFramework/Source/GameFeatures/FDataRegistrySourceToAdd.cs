#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureAction_DataRegistrySource.h")]
///<summary>Defines which source assets to add and conditions for adding</summary>
public partial struct FDataRegistrySourceToAdd {
// DataRegistrySourceToAdd
	public string RegistryToAddTo;
	public int AssetPriority;
	public bool bClientSource;
	public bool bServerSource;
	public TSoftObjectPtr<UDataTable> DataTableToAdd;
	public TSoftObjectPtr<UCurveTable> CurveTableToAdd;
}
