namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-exposed functionality for wrapping native functionality and constructing valid FAnimationCurveIdentifier instances</summary>
[CppInclude("Animation/AnimData/CurveIdentifier.h")]
public partial class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>@return       Whether or not the Curve Identifier is valid</summary>
	public static bool IsValid(FAnimationCurveIdentifier Identifier) { return default; }
	///<summary>@return       The name used for displaying the Curve Identifier</summary>
	public static FName GetName(FAnimationCurveIdentifier Identifier) { return default; }
	///<summary>@return       The animation curve type for the curve represented by the Curve Identifier</summary>
	public static ERawCurveTrackTypes GetType(FAnimationCurveIdentifier Identifier) { return default; }
	///<summary>Constructs a valid FAnimationCurveIdentifier instance.</summary>
	public static void SetCurveIdentifier(FAnimationCurveIdentifier InOutIdentifier,FName Name,ERawCurveTrackTypes CurveType) {}
	///<summary>GetCurveIdentifier</summary>
	public static FAnimationCurveIdentifier GetCurveIdentifier(USkeleton InSkeleton,FName Name,ERawCurveTrackTypes CurveType) { return default; }
	///<summary>Tries to construct a valid FAnimationCurveIdentifier instance. It tries to find the underlying SmartName on the provided Skeleton for the provided curve type.</summary>
	public static FAnimationCurveIdentifier FindCurveIdentifier(USkeleton InSkeleton,FName Name,ERawCurveTrackTypes CurveType) { return default; }
	///<summary>Retrieves all curve identifiers for a specific curve types from the provided Skeleton</summary>
	public static TArray<FAnimationCurveIdentifier> GetCurveIdentifiers(USkeleton InSkeleton,ERawCurveTrackTypes CurveType) { return default; }
	///<summary>Converts a valid FAnimationCurveIdentifier instance with RCT_Transform curve type to target a child curve.</summary>
	public static bool GetTransformChildCurveIdentifier(FAnimationCurveIdentifier InOutIdentifier,ETransformCurveChannel Channel,EVectorCurveChannel Axis) { return default; }
}
