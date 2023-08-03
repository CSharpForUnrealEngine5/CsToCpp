#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/SlateBlueprintLibrary.h")]
public partial class USlateBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.</summary>
	public static bool IsUnderLocation(FGeometry Geometry,FVector2D AbsoluteCoordinate) { return default; }
	///<summary>Absolute coordinates could be either desktop or window space depending on what space the root of the widget hierarchy is in.</summary>
	public static FVector2D AbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteCoordinate) { return default; }
	///<summary>Translates local coordinates into absolute coordinates</summary>
	public static FVector2D LocalToAbsolute(FGeometry Geometry,FVector2D LocalCoordinate) { return default; }
	///<summary>Returns the local top/left of the geometry in local space.</summary>
	public static FVector2D GetLocalTopLeft(FGeometry Geometry) { return default; }
	///<summary>Returns the size of the geometry in local space.</summary>
	public static FVector2D GetLocalSize(FGeometry Geometry) { return default; }
	///<summary>Returns the size of the geometry in absolute space.</summary>
	public static FVector2D GetAbsoluteSize(FGeometry Geometry) { return default; }
	///<summary>TransformScalarAbsoluteToLocal</summary>
	public static float TransformScalarAbsoluteToLocal(FGeometry Geometry,float AbsoluteScalar) { return default; }
	///<summary>TransformScalarLocalToAbsolute</summary>
	public static float TransformScalarLocalToAbsolute(FGeometry Geometry,float LocalScalar) { return default; }
	///<summary>TransformVectorAbsoluteToLocal</summary>
	public static FVector2D TransformVectorAbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteVector) { return default; }
	///<summary>TransformVectorLocalToAbsolute</summary>
	public static FVector2D TransformVectorLocalToAbsolute(FGeometry Geometry,FVector2D LocalVector) { return default; }
	///<summary>Returns whether brushes A and B are identical.</summary>
	public static bool EqualEqual_SlateBrush(FSlateBrush A,FSlateBrush B) { return default; }
	///<summary>Translates local coordinate of the geometry provided into local viewport coordinates.</summary>
	public static void LocalToViewport(UObject WorldContextObject,FGeometry Geometry,FVector2D LocalCoordinate,FVector2D PixelPosition,FVector2D ViewportPosition) {}
	///<summary>Translates absolute coordinate in desktop space of the geometry provided into local viewport coordinates.</summary>
	public static void AbsoluteToViewport(UObject WorldContextObject,FVector2D AbsoluteDesktopCoordinate,FVector2D PixelPosition,FVector2D ViewportPosition) {}
	///<summary>Translates a screen position in pixels into the local space of a widget with the given geometry.</summary>
	public static void ScreenToWidgetLocal(UObject WorldContextObject,FGeometry Geometry,FVector2D ScreenPosition,FVector2D LocalCoordinate,bool bIncludeWindowPosition/*=false*/) {}
	///<summary>Translates a screen position in pixels into absolute application coordinates.</summary>
	public static void ScreenToWidgetAbsolute(UObject WorldContextObject,FVector2D ScreenPosition,FVector2D AbsoluteCoordinate,bool bIncludeWindowPosition/*=false*/) {}
	///<summary>Translates a screen position in pixels into the local space of the viewport widget.</summary>
	public static void ScreenToViewport(UObject WorldContextObject,FVector2D ScreenPosition,FVector2D ViewportPosition) {}
}
