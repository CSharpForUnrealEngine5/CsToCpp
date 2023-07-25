#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/LevelSnapshotsEditorData.h")]
///<summary>Stores all data shared across the editor's UI.</summary>
public partial class ULevelSnapshotsEditorData : UObject {
// LevelSnapshotsEditorData
	public UFavoriteFilterContainer FavoriteFilters;
	public ULevelSnapshotsFilterPreset UserDefinedFilters;
	public UFilterLoader FilterLoader;
	public bool bIsFilterDirty;
	public bool bIsApplyingSnapshot;
	public UFilteredResults FilterResults;
	public ULevelSnapshot ActiveSnapshot;
	public UNegatableFilter EditedFilter;
}
