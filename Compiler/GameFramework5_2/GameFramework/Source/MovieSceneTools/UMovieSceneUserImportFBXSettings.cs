namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsUserSettings.h")]
public partial class UMovieSceneUserImportFBXSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Match fbx node names to sequencer node names</summary>
	public bool bMatchByNameOnly;
	///<summary>Convert the scene from FBX coordinate system to UE coordinate system with front X axis instead of -Y</summary>
	public bool bForceFrontXAxis;
	///<summary>Convert the scene from FBX unit to UE unit(centimeter)</summary>
	public bool bConvertSceneUnit;
	///<summary>Import Uniform Scale</summary>
	public float ImportUniformScale;
	///<summary>Whether to create cameras if they don&#39;t already exist in the level.</summary>
	public bool bCreateCameras;
	///<summary>Whether to replace the existing transform track or create a new track/section</summary>
	public bool bReplaceTransformTrack;
	///<summary>Whether to remove keyframes within a tolerance from the imported tracks</summary>
	public bool bReduceKeys;
	///<summary>The tolerance for reduce keys</summary>
	public float ReduceKeysTolerance;
}
