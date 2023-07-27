#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/SlateBlueprintLibrary.h")]
public partial class USlateBlueprintLibrary : UBlueprintFunctionLibrary {
// SlateBlueprintLibrary
	public static bool IsUnderLocation(FGeometry Geometry,FVector2D AbsoluteCoordinate) { return default; }
	public static FVector2D AbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteCoordinate) { return default; }
	public static FVector2D LocalToAbsolute(FGeometry Geometry,FVector2D LocalCoordinate) { return default; }
	public static FVector2D GetLocalTopLeft(FGeometry Geometry) { return default; }
	public static FVector2D GetLocalSize(FGeometry Geometry) { return default; }
	public static FVector2D GetAbsoluteSize(FGeometry Geometry) { return default; }
	public static float TransformScalarAbsoluteToLocal(FGeometry Geometry,float AbsoluteScalar) { return default; }
	public static float TransformScalarLocalToAbsolute(FGeometry Geometry,float LocalScalar) { return default; }
	public static FVector2D TransformVectorAbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteVector) { return default; }
	public static FVector2D TransformVectorLocalToAbsolute(FGeometry Geometry,FVector2D LocalVector) { return default; }
	public static bool EqualEqual_SlateBrush(FSlateBrush A,FSlateBrush B) { return default; }
	public static void LocalToViewport(UObject WorldContextObject,FGeometry Geometry,FVector2D LocalCoordinate,FVector2D PixelPosition,FVector2D ViewportPosition) {}
	public static void AbsoluteToViewport(UObject WorldContextObject,FVector2D AbsoluteDesktopCoordinate,FVector2D PixelPosition,FVector2D ViewportPosition) {}
	public static void ScreenToWidgetLocal(UObject WorldContextObject,FGeometry Geometry,FVector2D ScreenPosition,FVector2D LocalCoordinate,bool bIncludeWindowPosition/*=false*/) {}
	public static void ScreenToWidgetAbsolute(UObject WorldContextObject,FVector2D ScreenPosition,FVector2D AbsoluteCoordinate,bool bIncludeWindowPosition/*=false*/) {}
	public static void ScreenToViewport(UObject WorldContextObject,FVector2D ScreenPosition,FVector2D ViewportPosition) {}
}
