namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of the heads-up display. This has a canvas and a debug canvas on which primitives can be drawn.</summary>
[CppInclude("GameFramework/HUD.h")]
public partial class AHUD : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlayerController which owns this HUD.</summary>
	public APlayerController PlayerOwner;
	///<summary>Tells whether the game was paused due to lost focus</summary>
	public bool bLostFocusPaused;
	///<summary>Whether or not the HUD should be drawn.</summary>
	public bool bShowHUD;
	///<summary>If true, current ViewTarget shows debug information using its DisplayDebug().</summary>
	public bool bShowDebugInfo;
	///<summary>Current target in our considered Targets list for &#39;showdebug&#39;</summary>
	public int CurrentTargetIndex;
	///<summary>If true, show hitbox debugging info.</summary>
	public bool bShowHitBoxDebugInfo;
	///<summary>If true, render actor overlays.</summary>
	public bool bShowOverlays;
	///<summary>Put shadow on debug strings</summary>
	public bool bEnableDebugTextShadow;
	///<summary>Holds a list of Actors that need PostRender() calls.</summary>
	public TArray<AActor> PostRenderedActors;
	///<summary>Array of names specifying what debug info to display for viewtarget actor.</summary>
	public TArray<string> DebugDisplay;
	///<summary>Array of names specifying what subsets of debug info to display for viewtarget actor.</summary>
	public TArray<string> ToggledDebugCategories;
	///<summary>Canvas to Draw HUD on.  Only valid during PostRender() event.</summary>
	public UCanvas Canvas;
	///<summary>&#39;Foreground&#39; debug canvas, will draw in front of Slate UI.</summary>
	public UCanvas DebugCanvas;
	///<summary>List of debug strings attached to actors, sorted by actor first, then by order of addition</summary>
	public TArray<FDebugTextInfo> DebugTextList;
	///<summary>hides or shows HUD</summary>
	public virtual void ShowHUD() {}
	///<summary>Toggles displaying properties of player&#39;s current ViewTarget</summary>
	public virtual void ShowDebug(string DebugType/*=NAME_None*/) {}
	///<summary>Toggles sub categories of show debug to customize display</summary>
	public void ShowDebugToggleSubCategory(string Category) {}
	///<summary>Toggles &#39;ShowDebug&#39; from showing debug info between reticle target actor (of subclass &lt;DesiredClass&gt;) and camera view target</summary>
	public void ShowDebugForReticleTargetToggle(UClass DesiredClass) {}
	///<summary>Class filter for selecting &#39;ShowDebugTargetActor&#39; when &#39;bShowDebugForReticleTarget&#39; is true.</summary>
	public UClass ShowDebugTargetDesiredClass;
	///<summary>Show Debug Actor used if &#39;bShowDebugForReticleTarget&#39; is true, only updated if trace from reticle hit a new Actor of class &#39;ShowDebugTargetDesiredClass&#39;</summary>
	public AActor ShowDebugTargetActor;
	///<summary>Add debug text for a specific actor to be displayed via DrawDebugTextList().  If the debug text is invalid then it will</summary>
	public void AddDebugText(string DebugText,AActor SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UFont InFont,float FontScale,bool bDrawShadow) {}
	///<summary>Remove all debug strings added via AddDebugText</summary>
	public void RemoveAllDebugStrings() {}
	///<summary>Remove debug strings for the given actor</summary>
	public void RemoveDebugText(AActor SrcActor,bool bLeaveDurationText) {}
	///<summary>Hook to allow blueprints to do custom HUD drawing. See: bSuppressNativeHUD to control HUD drawing in base class.</summary>
	public void ReceiveDrawHUD(int SizeX,int SizeY) {}
	///<summary>Called when a hit box is clicked on. Provides the name associated with that box.</summary>
	public void ReceiveHitBoxClick(string BoxName) {}
	///<summary>Called when a hit box is unclicked. Provides the name associated with that box.</summary>
	public void ReceiveHitBoxRelease(string BoxName) {}
	///<summary>Called when a hit box is moused over.</summary>
	public void ReceiveHitBoxBeginCursorOver(string BoxName) {}
	///<summary>Called when a hit box no longer has the mouse over it.</summary>
	public void ReceiveHitBoxEndCursorOver(string BoxName) {}
	///<summary>Returns the width and height of a string.</summary>
	public void GetTextSize(string Text,float OutWidth,float OutHeight,UFont Font/*=NULL*/,float Scale/*=1.0f*/) {}
	///<summary>Draws a string on the HUD.</summary>
	public void DrawText(string Text,FLinearColor TextColor,float ScreenX,float ScreenY,UFont Font/*=NULL*/,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	///<summary>Draws a 2D line on the HUD.</summary>
	public void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness/*=0.0f*/) {}
	///<summary>Draws a colored untextured quad on the HUD.</summary>
	public void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH) {}
	///<summary>Draws a textured quad on the HUD.</summary>
	public void DrawTexture(UTexture Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor/*=FLinearColor.White*/,EBlendMode BlendMode/*=BLEND_Translucent*/,float Scale/*=1.0f*/,bool bScalePosition/*=false*/,float Rotation/*=0.0f*/,FVector2D RotPivot/*=FVector2D.ZeroVector*/) {}
	///<summary>Draws a textured quad on the HUD. Assumes 1:1 texel density.</summary>
	public void DrawTextureSimple(UTexture Texture,float ScreenX,float ScreenY,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	///<summary>Draws a material-textured quad on the HUD.</summary>
	public void DrawMaterial(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale/*=1.0f*/,bool bScalePosition/*=false*/,float Rotation/*=0.0f*/,FVector2D RotPivot/*=FVector2D.ZeroVector*/) {}
	///<summary>Draws a material-textured quad on the HUD.  Assumes UVs such that the entire material is shown.</summary>
	public void DrawMaterialSimple(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale/*=1.0f*/,bool bScalePosition/*=false*/) {}
	///<summary>DrawMaterialTriangle</summary>
	public void DrawMaterialTriangle(UMaterialInterface Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color/*=FLinearColor.White*/,FLinearColor V1_Color/*=FLinearColor.White*/,FLinearColor V2_Color/*=FLinearColor.White*/) {}
	///<summary>Transforms a 3D world-space vector into 2D screen coordinates</summary>
	public FVector Project(FVector Location,bool bClampToZeroPlane/*=true*/) { return default; }
	///<summary>Transforms a 2D screen location into a 3D location and direction</summary>
	public void Deproject(float ScreenX,float ScreenY,FVector WorldPosition,FVector WorldDirection) {}
	///<summary>Returns the array of actors inside a selection rectangle, with a class filter.</summary>
	public void GetActorsInSelectionRectangle(UClass ClassFilter,FVector2D FirstPoint,FVector2D SecondPoint,TArray<AActor> OutActors,bool bIncludeNonCollidingComponents/*=true*/,bool bActorMustBeFullyEnclosed/*=false*/) {}
	///<summary>Add a hitbox to the hud</summary>
	public void AddHitBox(FVector2D Position,FVector2D Size,string InName,bool bConsumesInput,int Priority/*=0*/) {}
	///<summary>Returns the PlayerController for this HUD&#39;s player.</summary>
	public APlayerController GetOwningPlayerController() { return default; }
	///<summary>Returns the Pawn for this HUD&#39;s player.</summary>
	public APawn GetOwningPawn() { return default; }
	///<summary>Cycle to next target in our considered targets list for &#39;showdebug&#39;</summary>
	public virtual void NextDebugTarget() {}
	///<summary>Cycle to previous target in our considered targets list for &#39;showdebug&#39;</summary>
	public virtual void PreviousDebugTarget() {}
}
