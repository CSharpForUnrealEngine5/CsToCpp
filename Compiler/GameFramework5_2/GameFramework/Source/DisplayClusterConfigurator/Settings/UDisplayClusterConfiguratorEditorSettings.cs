#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/DisplayClusterConfiguratorSettings.h")]
public partial class UDisplayClusterConfiguratorEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Camera view location when resetting the camera.</summary>
	public FVector EditorDefaultCameraLocation;
	///<summary>Camera view rotation when resetting the camera.</summary>
	public FRotator EditorDefaultCameraRotation;
	///<summary>Shows the floor in the 3d editor viewport.</summary>
	public bool bEditorShowFloor;
	///<summary>Shows the grid in the 3d editor viewport.</summary>
	public bool bEditorShowGrid;
	///<summary>Displays the world origin at 0, 0, 0</summary>
	public bool bEditorShowWorldOrigin;
	///<summary>Shows the preview in editor</summary>
	public bool bEditorShowPreview;
	///<summary>Shows names of the viewport in 3d space.</summary>
	public bool bEditorShow3DViewportNames;
	///<summary>Export a config automatically on save. Requires a config initially exported.</summary>
	public bool bExportOnSave;
	///<summary>Automatically update assets saved by older versions to the most current version. It is strongly recommended to leave this on.</summary>
	public bool bUpdateAssetsOnStartup;
	///<summary>Display a progress bar when updating assets to a new version.</summary>
	public bool bDisplayAssetUpdateProgress;
	///<summary>The visual scale of the Xform static mesh</summary>
	public float VisXformScale;
	///<summary>Whether to show the Xform static mesh</summary>
	public bool bShowVisXforms;
	///<summary>Anti aliasing in 3d viewport.</summary>
	public bool bEditorEnableAA;
	///<summary>The last position on the new asset dialog box.</summary>
	public int NewAssetIndex;
}
