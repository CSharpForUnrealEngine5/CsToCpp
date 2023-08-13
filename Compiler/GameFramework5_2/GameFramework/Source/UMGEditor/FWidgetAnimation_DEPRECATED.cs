namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used only for loading old animations</summary>
[CppInclude("WidgetBlueprint.h")]
public partial struct FWidgetAnimation_DEPRECATED {
	public UMovieScene MovieScene;
	public TArray<FWidgetAnimationBinding> AnimationBindings;
}
