#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USDImporter and defaultconfig here so this ends up at DefaultUSDImporter.ini in the editor, and is sent to the</summary>
[CppInclude("USDProjectSettings.h")]
public partial class UUsdProjectSettings : UDeveloperSettings {
	///<summary>Additional paths to check for USD plugins</summary>
	public TArray<FDirectoryPath> AdditionalPluginDirectories;
	///<summary>Material purposes to show on drop-downs in addition to the standard &quot;preview&quot; and &quot;full&quot;</summary>
	public TArray<string> AdditionalMaterialPurposes;
	///<summary>USD Asset Cache to use for USD Stage Actors that don&#39;t have any asset cache specified.</summary>
	public FSoftObjectPath DefaultAssetCache;
	///<summary>bShowCreateDefaultAssetCacheDialog</summary>
	public bool bShowCreateDefaultAssetCacheDialog;
	///<summary>bShowConfirmationWhenClearingLayers</summary>
	public bool bShowConfirmationWhenClearingLayers;
	///<summary>bShowConfirmationWhenMutingDirtyLayers</summary>
	public bool bShowConfirmationWhenMutingDirtyLayers;
	///<summary>Whether to show the warning dialog when authoring opinions that could have no effect on the composed stage</summary>
	public bool bShowOverriddenOpinionsWarning;
	///<summary>Whether to show a warning whenever the &quot;Duplicate All Local Layer Specs&quot; option is picked, and the duplicated</summary>
	public bool bShowWarningOnIncompleteDuplication;
	///<summary>Whether to show the warning dialog when authoring a transform track directly to a camera component</summary>
	public bool bShowTransformTrackOnCameraComponentWarning;
	///<summary>Whether to display the pop up dialog asking what to do about dirty USD layers when saving the UE level</summary>
	public EUsdSaveDialogBehavior ShowSaveLayersDialogWhenSaving;
	///<summary>Whether to display the pop up dialog asking what to do about dirty USD layers when closing USD stages</summary>
	public EUsdSaveDialogBehavior ShowSaveLayersDialogWhenClosing;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTwoSidedMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentTwoSidedMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceVTMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentVTMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTwoSidedVTMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentTwoSidedVTMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferenceDisplayColorMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferenceDisplayColorAndOpacityMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferenceDisplayColorTwoSidedMaterial;
	///<summary>What material to use as reference material when creating material instances from USD materials.</summary>
	public FSoftObjectPath ReferenceDisplayColorAndOpacityTwoSidedMaterial;
}
