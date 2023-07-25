#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Canvas.h")]
///<summary>A drawing canvas.</summary>
public partial class UCanvas : UObject {
// Canvas
	public float OrgX;
	public float OrgY;
	public float ClipX;
	public float ClipY;
	public FColor DrawColor;
	public bool bCenterX;
	public bool bCenterY;
	public bool bNoSmooth;
	public int SizeX;
	public int SizeY;
	public FPlane ColorModulate;
	public UTexture2D DefaultTexture;
	public UTexture2D GradientTexture0;
	public UReporterGraph ReporterGraph;
	public void K2_DrawLine(FVector2D ScreenPositionA/*=FVector2D.ZeroVector*/,FVector2D ScreenPositionB/*=FVector2D.ZeroVector*/,float Thickness/*=1.0f*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	public void K2_DrawTexture(UObject RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,FLinearColor RenderColor/*=FLinearColor.White*/,EBlendMode BlendMode/*=BLEND_Translucent*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/) {}
	public void K2_DrawMaterial(UObject RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/) {}
	public void K2_DrawText(UObject RenderFont,string RenderText,FVector2D ScreenPosition,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FLinearColor RenderColor/*=FLinearColor.White*/,float Kerning/*=0.0f*/,FLinearColor ShadowColor/*=FLinearColor.Black*/,FVector2D ShadowOffset/*=FVector2D.UnitVector*/,bool bCentreX/*=false*/,bool bCentreY/*=false*/,bool bOutlined/*=false*/,FLinearColor OutlineColor/*=FLinearColor.Black*/) {}
	public void K2_DrawBorder(UObject BorderTexture,UObject BackgroundTexture,UObject LeftBorderTexture,UObject RightBorderTexture,UObject TopBorderTexture,UObject BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,FLinearColor RenderColor/*=FLinearColor.White*/,FVector2D BorderScale/*=new FVector2D(0.1f,0.1f)*/,FVector2D BackgroundScale/*=new FVector2D(0.1f,0.1f)*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/,FVector2D CornerSize/*=FVector2D.ZeroVector*/) {}
	public void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness/*=1.0f*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	public void K2_DrawTriangle(UObject RenderTexture,TArray<FCanvasUVTri> Triangles) {}
	public void K2_DrawMaterialTriangle(UObject RenderMaterial,TArray<FCanvasUVTri> Triangles) {}
	public void K2_DrawPolygon(UObject RenderTexture,FVector2D ScreenPosition,FVector2D Radius/*=FVector2D.UnitVector*/,int NumberOfSides/*=3*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	public FVector K2_Project(FVector WorldLocation) { return default; }
	public void K2_Deproject(FVector2D ScreenPosition,FVector WorldOrigin,FVector WorldDirection) {}
	public FVector2D K2_StrLen(UObject RenderFont,string RenderText) { return default; }
	public FVector2D K2_TextSize(UObject RenderFont,string RenderText,FVector2D Scale/*=FVector2D.UnitVector*/) { return default; }
}
