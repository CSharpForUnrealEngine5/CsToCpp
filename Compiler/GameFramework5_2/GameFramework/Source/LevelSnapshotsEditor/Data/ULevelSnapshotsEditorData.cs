#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores all data shared across the editor&#39;s UI.</summary>
[CppInclude("Data/LevelSnapshotsEditorData.h")]
public partial class ULevelSnapshotsEditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FavoriteFilters</summary>
	public UFavoriteFilterContainer FavoriteFilters;
	///<summary>Stores user-defined filters in chain of ORs of ANDs.</summary>
	public ULevelSnapshotsFilterPreset UserDefinedFilters;
	///<summary>Handles save &amp; load requests for exchanging UserDefinedFilters.</summary>
	public UFilterLoader FilterLoader;
	///<summary>Used for determining whether the filter state has changed since it was last refreshed.</summary>
	public bool bIsFilterDirty;
	///<summary>Whether ActiveSnapshot is currently being restored. Does not allow changing the active snapshot while true.</summary>
	public bool bIsApplyingSnapshot;
	///<summary>Converts UserDefinedFilters into ULevelSnapshotsSelectionSet display in results view.</summary>
	public UFilteredResults FilterResults;
	///<summary>Snapshot selected by user</summary>
	public ULevelSnapshot ActiveSnapshot;
	///<summary>Filter visible in details panel</summary>
	public UNegatableFilter EditedFilter;
}
