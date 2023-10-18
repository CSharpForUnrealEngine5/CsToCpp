namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsUserSettings.h")]
public partial class UMovieSceneUserExportFBXControlRigSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Imported File Name</summary>
	public string ExportFileName;
	///<summary>This will set the fbx sdk compatibility when exporting to fbx file. The default value is 2013</summary>
	public EFbxExportCompatibility FbxExportCompatibility;
	///<summary>If enabled, save as ascii instead of binary</summary>
	public bool bASCII;
	///<summary>Convert the scene from FBX coordinate system to UE coordinate system with front X axis instead of -Y</summary>
	public bool bForceFrontXAxis;
	///<summary>Whether or not import onto selected controls or all controls</summary>
	public bool bExportOnlySelectedControls;
	///<summary>Mappings for how Control Rig Control Attributes Map to the incoming Transforms</summary>
	public TArray<FControlToTransformMappings> ControlChannelMappings;
	///<summary>If enabled, export sequencer animation in its local time, relative to its sequence.</summary>
	public bool bExportLocalTime;
	///<summary>Load the default or metahuman preset into the current mappings</summary>
	public void LoadControlMappingsFromPreset(bool bMetaHumanPreset) {}
}
