#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used only for loading old animations</summary>
[CppInclude("WidgetBlueprint.h")]
public partial struct FWidgetAnimation_DEPRECATED {
	public UMovieScene MovieScene;
	public TArray<FWidgetAnimationBinding> AnimationBindings;
}
