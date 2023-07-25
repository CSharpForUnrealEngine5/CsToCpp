#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetBlueprint.h")]
///<summary>The widget blueprint enables extending UUserWidget the user extensible UWidget.</summary>
public partial class UWidgetBlueprint : UBaseWidgetBlueprint {
// WidgetBlueprint
	public TArray<FDelegateEditorBinding> Bindings;
	public TArray<FWidgetAnimation_DEPRECATED> AnimationData_DEPRECATED;
	public TArray<UWidgetAnimation> Animations;
	public string PaletteCategory;
	public EWidgetTickFrequency TickFrequency;
	public EWidgetCompileTimeTickPrediction TickPrediction;
	public string TickPredictionReason;
	public int PropertyBindings;
	public EThumbnailPreviewSizeMode ThumbnailSizeMode;
	public FVector2D ThumbnailCustomSize;
	public UTexture2D ThumbnailImage;
}
