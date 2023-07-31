#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A drawing canvas.</summary>
[CppInclude("Engine/Canvas.h")]
public partial class UCanvas : UObject {
	///<summary>Modifiable properties.</summary>
	public float OrgX;
	///<summary>Origin for drawing in X.</summary>
	public float OrgY;
	///<summary>Origin for drawing in Y.</summary>
	public float ClipX;
	///<summary>Bottom right clipping region.</summary>
	public float ClipY;
	///<summary>Bottom right clipping region.</summary>
	public FColor DrawColor;
	///<summary>Color for drawing.</summary>
	public bool bCenterX;
	///<summary>Whether to center the text horizontally (about CurX)</summary>
	public bool bCenterY;
	///<summary>Whether to center the text vertically (about CurY)</summary>
	public bool bNoSmooth;
	///<summary>Don&#39;t bilinear filter.</summary>
	public int SizeX;
	///<summary>Zero-based actual dimensions X.</summary>
	public int SizeY;
	///<summary>Internal.</summary>
	public FPlane ColorModulate;
	///<summary>DefaultTexture</summary>
	public UTexture2D DefaultTexture;
	///<summary>Default texture to use</summary>
	public UTexture2D GradientTexture0;
	///<summary>Helper class to render 2d graphs on canvas</summary>
	public UReporterGraph ReporterGraph;
	///<summary>Draws a line on the Canvas.</summary>
	public  void K2_DrawLine(FVector2D ScreenPositionA/*=FVector2D.ZeroVector*/,FVector2D ScreenPositionB/*=FVector2D.ZeroVector*/,float Thickness/*=1.0f*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	///<summary>Draws a texture on the Canvas.</summary>
	public  void K2_DrawTexture(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,FLinearColor RenderColor/*=FLinearColor.White*/,EBlendMode BlendMode/*=BLEND_Translucent*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/) {}
	///<summary>Draws a material on the Canvas.</summary>
	public  void K2_DrawMaterial(UMaterialInterface RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/) {}
	///<summary>Draws text on the Canvas.</summary>
	public  void K2_DrawText(UFont RenderFont,string RenderText,FVector2D ScreenPosition,FVector2D Scale/*=new FVector2D(1.0f,1.0f)*/,FLinearColor RenderColor/*=FLinearColor.White*/,float Kerning/*=0.0f*/,FLinearColor ShadowColor/*=FLinearColor.Black*/,FVector2D ShadowOffset/*=FVector2D.UnitVector*/,bool bCentreX/*=false*/,bool bCentreY/*=false*/,bool bOutlined/*=false*/,FLinearColor OutlineColor/*=FLinearColor.Black*/) {}
	///<summary>Draws a 3x3 grid border with tiled frame and tiled interior on the Canvas.</summary>
	public  void K2_DrawBorder(UTexture BorderTexture,UTexture BackgroundTexture,UTexture LeftBorderTexture,UTexture RightBorderTexture,UTexture TopBorderTexture,UTexture BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize/*=FVector2D.UnitVector*/,FLinearColor RenderColor/*=FLinearColor.White*/,FVector2D BorderScale/*=new FVector2D(0.1f,0.1f)*/,FVector2D BackgroundScale/*=new FVector2D(0.1f,0.1f)*/,float Rotation/*=0.0f*/,FVector2D PivotPoint/*=new FVector2D(0.5f,0.5f)*/,FVector2D CornerSize/*=FVector2D.ZeroVector*/) {}
	///<summary>Draws an unfilled box on the Canvas.</summary>
	public  void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness/*=1.0f*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	///<summary>Draws a set of triangles on the Canvas.</summary>
	public  void K2_DrawTriangle(UTexture RenderTexture,TArray<FCanvasUVTri> Triangles) {}
	///<summary>Draws a set of triangles on the Canvas.</summary>
	public  void K2_DrawMaterialTriangle(UMaterialInterface RenderMaterial,TArray<FCanvasUVTri> Triangles) {}
	///<summary>Draws a polygon on the Canvas.</summary>
	public  void K2_DrawPolygon(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D Radius/*=FVector2D.UnitVector*/,int NumberOfSides/*=3*/,FLinearColor RenderColor/*=FLinearColor.White*/) {}
	///<summary>Performs a projection of a world space coordinates using the projection matrix set up for the Canvas.</summary>
	public  FVector K2_Project(FVector WorldLocation) { return default; }
	///<summary>Performs a deprojection of a screen space coordinate using the projection matrix set up for the Canvas.</summary>
	public  void K2_Deproject(FVector2D ScreenPosition,FVector WorldOrigin,FVector WorldDirection) {}
	///<summary>Returns the wrapped text size in screen space coordinates.</summary>
	public  FVector2D K2_StrLen(UFont RenderFont,string RenderText) { return default; }
	///<summary>Returns the clipped text size in screen space coordinates.</summary>
	public  FVector2D K2_TextSize(UFont RenderFont,string RenderText,FVector2D Scale/*=FVector2D.UnitVector*/) { return default; }
}
