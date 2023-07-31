#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/UMGSequencePlayer.h")]
public partial class UUMGSequencePlayer : UObject {
	///<summary>@return</summary>
	public  string GetUserTag() { return default; }
	///<summary>SetUserTag</summary>
	public  void SetUserTag(string InUserTag) {}
	///<summary>Animation being played</summary>
	public UWidgetAnimation Animation;
	///<summary>RootTemplateInstance</summary>
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}
