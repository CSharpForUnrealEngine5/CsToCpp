namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageEditorSettings.h")]
public partial class UUsdStageEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether our prim selection in SUSDStageTreeView is kept synchronized with the viewport selection</summary>
	public bool bSelectionSynced;
	///<summary>Whether to automatically set a layer as edit target when isolating it</summary>
	public bool bIsolateLayerSyncedWithEditTarget;
}
