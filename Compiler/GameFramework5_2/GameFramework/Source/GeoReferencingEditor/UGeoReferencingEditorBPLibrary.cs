#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingEditorBPLibrary.h")]
public partial class UGeoReferencingEditorBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Retrieve the Viewport-Space position of the mouse in the Level Editor Viewport. If the Level editor not are in focus it will return false.</summary>
	public static void GetViewportCursorLocation(bool Focused,FVector2D ScreenLocation) {}
	///<summary>Retrieve information about the viewport under the mouse cursor.</summary>
	public static void GetViewportCursorInformation(bool Focused,FVector2D ScreenLocation,FVector WorldLocation,FVector WorldDirection) {}
	///<summary>LineTrace under mouse cursor and return various information</summary>
	public static void LineTraceViewport(FVector2D ScreenLocation,TArray<AActor> ActorsToIgnore,bool bTraceComplex,bool bShowTrace,bool bSuccess,FHitResult HitResult) {}
	///<summary>LineTrace at specific location/direction</summary>
	public static void LineTrace(FVector WorldLocation,FVector WorldDirection,TArray<AActor> ActorsToIgnore,bool TraceComplex,bool ShowTrace,bool Success,FHitResult HitResult) {}
}
