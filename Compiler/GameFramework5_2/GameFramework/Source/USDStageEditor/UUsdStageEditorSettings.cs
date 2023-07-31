#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageEditorSettings.h")]
public partial class UUsdStageEditorSettings : UObject {
	///<summary>Whether our prim selection in SUSDStageTreeView is kept synchronized with the viewport selection</summary>
	public bool bSelectionSynced;
	///<summary>Whether to automatically set a layer as edit target when isolating it</summary>
	public bool bIsolateLayerSyncedWithEditTarget;
}
