namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility functions for Level Sequences to implement VCamHUD UI.</summary>
[CppInclude("FunctionLibraries/LevelSequenceVCamLibrary.h")]
public partial class ULevelSequenceVCamLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Checks whether this sequence has any camera cuts set up.</summary>
	public static bool HasAnyCameraCutsInLevelSequence(ULevelSequence Sequence) { return default; }
	///<summary>Gets all cameras currently spawned by the active level sequence.</summary>
	public static TArray<FPilotableSequenceCameraInfo> FindPilotableCamerasInActiveLevelSequence() { return default; }
}
