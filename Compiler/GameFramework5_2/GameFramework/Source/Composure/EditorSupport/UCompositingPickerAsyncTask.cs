#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorSupport/CompositingEditorSupportLibrary.h")]
public partial class UCompositingPickerAsyncTask : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>OpenCompositingPicker</summary>
	public static UCompositingPickerAsyncTask OpenCompositingPicker(UTextureRenderTarget2D PickerTarget,UTexture DisplayImage,string WindowTitle,bool bAverageColorOnDrag/*=true*/,bool bUseImplicitGamma/*=true*/) { return default; }
	///<summary>OnPick</summary>
	public FOnPixelPicked OnPick;
	///<summary>OnCancel</summary>
	public FOnPixelPicked OnCancel;
	///<summary>OnAccept</summary>
	public FOnPixelPicked OnAccept;
	///<summary>PickerTarget</summary>
	public UTextureRenderTarget2D PickerTarget;
	///<summary>PickerDisplayImage</summary>
	public UTexture PickerDisplayImage;
}
