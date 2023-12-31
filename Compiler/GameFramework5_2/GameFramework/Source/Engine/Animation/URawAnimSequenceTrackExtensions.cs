namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
public partial class URawAnimSequenceTrackExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the positional keys contained by the FRawAnimSequenceTrack</summary>
	public static TArray<FVector> GetPositionalKeys(FRawAnimSequenceTrack Track) { return default; }
	///<summary>Returns the rotational keys contained by the FRawAnimSequenceTrack</summary>
	public static TArray<FQuat> GetRotationalKeys(FRawAnimSequenceTrack Track) { return default; }
	///<summary>Returns the scale keys contained by the FRawAnimSequenceTrack</summary>
	public static TArray<FVector> GetScaleKeys(FRawAnimSequenceTrack Track) { return default; }
}
