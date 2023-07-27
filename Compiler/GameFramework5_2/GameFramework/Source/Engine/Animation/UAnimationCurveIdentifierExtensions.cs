#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
///<summary>Script-exposed functionality for wrapping native functionality and constructing valid FAnimationCurveIdentifier instances</summary>
public partial class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary {
// AnimationCurveIdentifierExtensions
	public static bool IsValid(FAnimationCurveIdentifier Identifier) { return default; }
	public static string GetName(FAnimationCurveIdentifier Identifier) { return default; }
	public static ERawCurveTrackTypes GetType(FAnimationCurveIdentifier Identifier) { return default; }
	public static FAnimationCurveIdentifier GetCurveIdentifier(USkeleton InSkeleton,string Name,ERawCurveTrackTypes CurveType) { return default; }
	public static FAnimationCurveIdentifier FindCurveIdentifier(USkeleton InSkeleton,string Name,ERawCurveTrackTypes CurveType) { return default; }
	public static TArray<FAnimationCurveIdentifier> GetCurveIdentifiers(USkeleton InSkeleton,ERawCurveTrackTypes CurveType) { return default; }
	public static bool GetTransformChildCurveIdentifier(FAnimationCurveIdentifier InOutIdentifier,ETransformCurveChannel Channel,EVectorCurveChannel Axis) { return default; }
}
