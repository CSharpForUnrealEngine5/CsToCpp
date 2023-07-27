#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorSupport/CompositingEditorSupportLibrary.h")]
public partial class UCompositingPickerAsyncTask : UBlueprintAsyncActionBase {
// CompositingPickerAsyncTask
	public static UCompositingPickerAsyncTask OpenCompositingPicker(UTextureRenderTarget2D PickerTarget,UTexture DisplayImage,string WindowTitle,bool bAverageColorOnDrag/*=true*/,bool bUseImplicitGamma/*=true*/) { return default; }
	public FOnPixelPicked OnPick;
	public FOnPixelPicked OnCancel;
	public FOnPixelPicked OnAccept;
	public UTextureRenderTarget2D PickerTarget;
	public UTexture PickerDisplayImage;
}
