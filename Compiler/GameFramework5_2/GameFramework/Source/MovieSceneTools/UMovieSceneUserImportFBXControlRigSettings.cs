#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsUserSettings.h")]
public partial class UMovieSceneUserImportFBXControlRigSettings : UObject {
// MovieSceneUserImportFBXControlRigSettings
	public string ImportedFileName;
	public FFrameNumber ImportedStartTime;
	public FFrameNumber ImportedEndTime;
	public TArray<string> ImportedNodeNames;
	public string ImportedFrameRate;
	public TArray<FControlFindReplaceString> FindAndReplaceStrings;
	public bool bForceFrontXAxis;
	public bool bConvertSceneUnit;
	public float ImportUniformScale;
	public bool bImportOntoSelectedControls;
	public FFrameNumber TimeToInsertOrReplaceAnimation;
	public bool bInsertAnimation;
	public bool bSpecifyTimeRange;
	public FFrameNumber StartTimeRange;
	public FFrameNumber EndTimeRange;
	public TArray<FControlToTransformMappings> ControlChannelMappings;
}
