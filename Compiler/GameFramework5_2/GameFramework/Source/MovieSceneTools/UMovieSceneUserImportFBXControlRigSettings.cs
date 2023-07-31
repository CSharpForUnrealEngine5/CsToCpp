#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsUserSettings.h")]
public partial class UMovieSceneUserImportFBXControlRigSettings : UObject {
	///<summary>Imported File Name</summary>
	public string ImportedFileName;
	///<summary>Imported File Duration in Seconds</summary>
	public FFrameNumber ImportedStartTime;
	///<summary>Imported File</summary>
	public FFrameNumber ImportedEndTime;
	///<summary>List Of Imported Names in FBX File</summary>
	public TArray<string> ImportedNodeNames;
	///<summary>Incoming File Frame Rate</summary>
	public string ImportedFrameRate;
	///<summary>Strings In Imported Node To Find And Replace</summary>
	public TArray<FControlFindReplaceString> FindAndReplaceStrings;
	///<summary>Convert the scene from FBX coordinate system to UE coordinate system with front X axis instead of -Y</summary>
	public bool bForceFrontXAxis;
	///<summary>Convert the scene from FBX unit to UE unit(centimeter)</summary>
	public bool bConvertSceneUnit;
	///<summary>Import Uniform Scale</summary>
	public float ImportUniformScale;
	///<summary>Whether or not import onto selected controls or all controls</summary>
	public bool bImportOntoSelectedControls;
	///<summary>Time that we insert or replace the imported animation</summary>
	public FFrameNumber TimeToInsertOrReplaceAnimation;
	///<summary>Whether or not we insert or replace, by default we insert</summary>
	public bool bInsertAnimation;
	///<summary>Whether to import over specific Time Range</summary>
	public bool bSpecifyTimeRange;
	///<summary>Start Time Range To Import</summary>
	public FFrameNumber StartTimeRange;
	///<summary>End Time Range To Import</summary>
	public FFrameNumber EndTimeRange;
	///<summary>Mappings for how Control Rig Control Attributes Map to the incoming Transforms</summary>
	public TArray<FControlToTransformMappings> ControlChannelMappings;
}
