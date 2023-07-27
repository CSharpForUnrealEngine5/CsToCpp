#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/HUD.h")]
///<summary>Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn.</summary>
public partial class AHUD : AActor {
// HUD
	public APlayerController PlayerOwner;
	public bool bLostFocusPaused;
	public bool bShowHUD;
	public bool bShowDebugInfo;
	public int CurrentTargetIndex;
	public bool bShowHitBoxDebugInfo;
	public bool bShowOverlays;
	public bool bEnableDebugTextShadow;
	public TArray<AActor> PostRenderedActors;
	public TArray<string> DebugDisplay;
	public TArray<string> ToggledDebugCategories;
	public UCanvas Canvas;
	public UCanvas DebugCanvas;
	public TArray<FDebugTextInfo> DebugTextList;
	public  void ShowHUD() {}
	public  void ShowDebug(string DebugType/*=NAME_None*/) {}
	public  void ShowDebugToggleSubCategory(string Category) {}
	public  void ShowDebugForReticleTargetToggle(UClass DesiredClass) {}
	public UClass ShowDebugTargetDesiredClass;
	public AActor ShowDebugTargetActor;
	public  void AddDebugText(string DebugText,AActor SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UFont InFont,float FontScale,bool bDrawShadow) {}
	public  void RemoveAllDebugStrings() {}
	public  void RemoveDebugText(AActor SrcActor,bool bLeaveDurationText) {}
	public  void ReceiveDrawHUD(int SizeX,int SizeY) {}
	public  void ReceiveHitBoxClick(string BoxName) {}
	public  void ReceiveHitBoxRelease(string BoxName) {}
	public  void ReceiveHitBoxBeginCursorOver(string BoxName) {}
	public  void ReceiveHitBoxEndCursorOver(string BoxName) {}
	public  void GetTextSize(string Text,float OutWidth,float OutHeight,UFont Font/*=NULL*/,float Scale/*=1.0f*/) {}
	public  void DrawText(string Text,FLinearColor TextColor,float ScreenX,float ScreenY,UFont Font/*=NULL*/,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	public  void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness/*=0.0f*/) {}
	public  void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH) {}
	public  void DrawTexture(UTexture Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor/*=FLinearColor.White*/,EBlendMode BlendMode/*=BLEND_Translucent*/,float Scale/*=1.0f*/,bool bScalePosition/*=false*/,float Rotation/*=0.0f*/,FVector2D RotPivot/*=FVector2D.ZeroVector*/) {}
	public  void DrawTextureSimple(UTexture Texture,float ScreenX,float ScreenY,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	public  void DrawMaterial(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale/*=1.0f*/,bool bScalePosition/*=false*/,float Rotation/*=0.0f*/,FVector2D RotPivot/*=FVector2D.ZeroVector*/) {}
	public  void DrawMaterialSimple(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	public  void DrawMaterialTriangle(UMaterialInterface Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color/*=FLinearColor.White*/,FLinearColor V1_Color/*=FLinearColor.White*/,FLinearColor V2_Color/*=FLinearColor.White*/) {}
	public  FVector Project(FVector Location,bool bClampToZeroPlane/*=true*/) { return default; }
	public  void Deproject(float ScreenX,float ScreenY,FVector WorldPosition,FVector WorldDirection) {}
	public  void GetActorsInSelectionRectangle(UClass ClassFilter,FVector2D FirstPoint,FVector2D SecondPoint,TArray<AActor> OutActors,bool bIncludeNonCollidingComponents/*=true*/,bool bActorMustBeFullyEnclosed/*=false*/) {}
	public  void AddHitBox(FVector2D Position,FVector2D Size,string InName,bool bConsumesInput,int Priority/*=0*/) {}
	public  APlayerController GetOwningPlayerController() { return default; }
	public  APawn GetOwningPawn() { return default; }
	public  void NextDebugTarget() {}
	public  void PreviousDebugTarget() {}
}
