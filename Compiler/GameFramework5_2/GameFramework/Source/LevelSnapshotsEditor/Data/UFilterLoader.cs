#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles saving and loading of UDisjunctiveNormalFormFilter.</summary>
[CppInclude("Data/FilterLoader.h")]
public partial class UFilterLoader : UObject {
	///<summary>Set once user either has used RequestSaveAs or SetPickedAsset.</summary>
	public FSoftObjectPath AssetLastSavedOrLoaded;
	///<summary>AssetBeingEdited</summary>
	public ULevelSnapshotsFilterPreset AssetBeingEdited;
}
