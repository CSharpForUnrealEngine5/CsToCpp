#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingEditorBPLibrary.h")]
public partial class UGeoReferencingEditorBPLibrary : UBlueprintFunctionLibrary {
// GeoReferencingEditorBPLibrary
	public static void GetViewportCursorLocation(bool Focused,FVector2D ScreenLocation) {}
	public static void GetViewportCursorInformation(bool Focused,FVector2D ScreenLocation,FVector WorldLocation,FVector WorldDirection) {}
	public static void LineTraceViewport(FVector2D ScreenLocation,TArray<AActor> ActorsToIgnore,bool bTraceComplex,bool bShowTrace,bool bSuccess,FHitResult HitResult) {}
	public static void LineTrace(FVector WorldLocation,FVector WorldDirection,TArray<AActor> ActorsToIgnore,bool TraceComplex,bool ShowTrace,bool Success,FHitResult HitResult) {}
}
