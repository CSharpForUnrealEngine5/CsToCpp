#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingEditorBPLibrary.h")]
public partial class UGeoReferencingEditorBPLibrary : UBlueprintFunctionLibrary {
// GeoReferencingEditorBPLibrary
	public void GetViewportCursorLocation(bool Focused,FVector2D ScreenLocation) {}
	public void GetViewportCursorInformation(bool Focused,FVector2D ScreenLocation,FVector WorldLocation,FVector WorldDirection) {}
	public void LineTraceViewport(FVector2D ScreenLocation,TArray<UObject> ActorsToIgnore,bool bTraceComplex,bool bShowTrace,bool bSuccess,FHitResult HitResult) {}
	public void LineTrace(FVector WorldLocation,FVector WorldDirection,TArray<UObject> ActorsToIgnore,bool TraceComplex,bool ShowTrace,bool Success,FHitResult HitResult) {}
}
