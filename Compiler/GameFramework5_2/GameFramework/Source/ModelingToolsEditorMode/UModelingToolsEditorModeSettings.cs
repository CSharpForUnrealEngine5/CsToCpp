namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Modeling Tools Editor Mode plug-in.</summary>
[CppInclude("ModelingToolsEditorModeSettings.h")]
public partial class UModelingToolsEditorModeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Enable/Disable the options to emit Dynamic Mesh Actors in Modeling Mode Tools</summary>
	public bool bEnableDynamicMeshActors;
	///<summary>Where should Assets auto-generated by Modeling Tools be stored by default</summary>
	public EModelingModeAssetGenerationLocation AssetGenerationLocation;
	///<summary>How should Assets auto-generated by Modeling Tools be handled in terms of saving, naming, etc</summary>
	public EModelingModeAssetGenerationBehavior AssetGenerationMode;
	///<summary>What type of Mesh Object should Output Type Setting default to in Modeling Mode Tools (takes effect after Editor restart)</summary>
	public EModelingModeDefaultMeshObjectType DefaultMeshObjectType;
	///<summary>Assets auto-generated by Modeling Tools are stored at this path, relative to the parent path defined by the Location. Set to an empty string to disable.</summary>
	public string AutoGeneratedAssetPath;
	///<summary>If true, Auto-Generated Assets created in an unsaved Level will be stored relative to top-level folder, otherwise they will be stored in /Temp and cannot be saved until they are explicitly moved to a permanent location</summary>
	public bool bStoreUnsavedLevelAssetsInTopLevelGameFolder;
	///<summary>If true, Autogenerated Assets are stored in per-user folders below the Autogen path</summary>
	public bool bUsePerUserAutogenSubfolder;
	///<summary>Overrides the user name used for per-user folders below the Autogen path. This might be necessary to resolve issues with source control, for example. Note that the per-user folder name might not contain the name exactly as provided.</summary>
	public string AutogenSubfolderUserNameOverride;
	///<summary>If true, Autogenerated Assets have a short random string generated and appended to their name</summary>
	public bool bAppendRandomStringToName;
	///<summary>If true, the standard UE Editor Gizmo Mode (ie selected via the Level Editor Viewport toggle) will be used to configure the Modeling Gizmo, otherwise a Combined Gizmo will always be used. It may be necessary to exit and re-enter Modeling Mode after changing this setting.</summary>
	public bool bRespectLevelEditorGizmoMode;
	///<summary>old preference for mesh selection system that will be disabled in 5.3</summary>
	public bool bEnablePersistentSelections;
	///<summary>UPROPERTY(config, EditAnywhere, Category = &quot;Modeling Mode|Selection&quot;, meta = (DisplayName=&quot;Enable Mesh Selection UI&quot;))</summary>
	public bool bEnableMeshSelections;
	///<summary>Assets auto-generated by Modeling Tools are stored at this path when in restrictive mode, relative to the package folder path.</summary>
	public string RestrictiveModeAutoGeneratedAssetPath;
	///<summary>Toggle Absolute World Grid Position snapping</summary>
	public bool bEnableAbsoluteWorldSnapping;
}
