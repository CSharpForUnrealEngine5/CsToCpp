namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The widget blueprint enables extending UUserWidget the user extensible UWidget.</summary>
[CppInclude("WidgetBlueprint.h")]
public partial class UWidgetBlueprint : UBaseWidgetBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>Bindings</summary>
	public TArray<FDelegateEditorBinding> Bindings;
	///<summary>AnimationData_DEPRECATED</summary>
	public TArray<FWidgetAnimation_DEPRECATED> AnimationData_DEPRECATED;
	///<summary>Animations</summary>
	public TArray<UWidgetAnimation> Animations;
	///<summary>Don&#39;t directly modify this property to change the palette category.  The actual value is stored</summary>
	public string PaletteCategory;
	///<summary>The desired tick frequency set by the user on the UserWidget&#39;s CDO.</summary>
	public EWidgetTickFrequency TickFrequency;
	///<summary>The computed frequency that the widget will need to be ticked at.  You can find the reasons for</summary>
	public EWidgetCompileTimeTickPrediction TickPrediction;
	///<summary>The reasons we may need to tick this widget.</summary>
	public string TickPredictionReason;
	///<summary>The total number of property bindings.  Consider this as a performance warning.</summary>
	public int PropertyBindings;
	///<summary>ThumbnailSizeMode</summary>
	public EThumbnailPreviewSizeMode ThumbnailSizeMode;
	///<summary>ThumbnailCustomSize</summary>
	public FVector2D ThumbnailCustomSize;
	///<summary>ThumbnailImage</summary>
	public UTexture2D ThumbnailImage;
}
