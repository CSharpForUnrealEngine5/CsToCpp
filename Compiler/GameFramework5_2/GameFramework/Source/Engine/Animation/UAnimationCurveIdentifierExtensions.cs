#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
///<summary>Script-exposed functionality for wrapping native functionality and constructing valid FAnimationCurveIdentifier instances</summary>
public partial class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary {
// AnimationCurveIdentifierExtensions
	public bool IsValid(FAnimationCurveIdentifier Identifier) { return default; }
	public string GetName(FAnimationCurveIdentifier Identifier) { return default; }
	public ERawCurveTrackTypes GetType(FAnimationCurveIdentifier Identifier) { return default; }
	public FAnimationCurveIdentifier GetCurveIdentifier(UObject InSkeleton,string Name,ERawCurveTrackTypes CurveType) { return default; }
	public FAnimationCurveIdentifier FindCurveIdentifier(UObject InSkeleton,string Name,ERawCurveTrackTypes CurveType) { return default; }
	public TArray<FAnimationCurveIdentifier> GetCurveIdentifiers(UObject InSkeleton,ERawCurveTrackTypes CurveType) { return default; }
	public bool GetTransformChildCurveIdentifier(FAnimationCurveIdentifier InOutIdentifier,ETransformCurveChannel Channel,EVectorCurveChannel Axis) { return default; }
}
