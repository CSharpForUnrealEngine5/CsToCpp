namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableTool_RenderAPI is helper Object that is created internally by a UScriptableInteractiveTool</summary>
[CppInclude("ScriptableInteractiveTool.h")]
public partial class UScriptableTool_RenderAPI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DrawLine</summary>
	public UScriptableTool_RenderAPI DrawLine(FVector Start,FVector End,FLinearColor Color,float Thickness/*=1.0f*/,float DepthBias/*=0.0f*/,bool bDepthTested/*=true*/) { return default; }
	///<summary>DrawRectWidthHeightXY</summary>
	public UScriptableTool_RenderAPI DrawRectWidthHeightXY(FTransform Transform,double Width,double Height,FLinearColor Color,float LineThickness/*=1.0f*/,float DepthBias/*=0.0f*/,bool bDepthTested/*=true*/,bool bCentered/*=true*/) { return default; }
}
