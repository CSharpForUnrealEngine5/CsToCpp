#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDProjectSettings.h")]
///<summary>USDImporter and defaultconfig here so this ends up at DefaultUSDImporter.ini in the editor, and is sent to the</summary>
public partial class UUsdProjectSettings : UDeveloperSettings {
// UsdProjectSettings
	public TArray<FDirectoryPath> AdditionalPluginDirectories;
	public TArray<string> AdditionalMaterialPurposes;
	public FSoftObjectPath DefaultAssetCache;
	public bool bShowCreateDefaultAssetCacheDialog;
	public bool bShowConfirmationWhenClearingLayers;
	public bool bShowConfirmationWhenMutingDirtyLayers;
	public bool bShowOverriddenOpinionsWarning;
	public bool bShowWarningOnIncompleteDuplication;
	public bool bShowTransformTrackOnCameraComponentWarning;
	public EUsdSaveDialogBehavior ShowSaveLayersDialogWhenSaving;
	public EUsdSaveDialogBehavior ShowSaveLayersDialogWhenClosing;
	public FSoftObjectPath ReferencePreviewSurfaceMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTwoSidedMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentTwoSidedMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceVTMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentVTMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTwoSidedVTMaterial;
	public FSoftObjectPath ReferencePreviewSurfaceTranslucentTwoSidedVTMaterial;
	public FSoftObjectPath ReferenceDisplayColorMaterial;
	public FSoftObjectPath ReferenceDisplayColorAndOpacityMaterial;
	public FSoftObjectPath ReferenceDisplayColorTwoSidedMaterial;
	public FSoftObjectPath ReferenceDisplayColorAndOpacityTwoSidedMaterial;
}
