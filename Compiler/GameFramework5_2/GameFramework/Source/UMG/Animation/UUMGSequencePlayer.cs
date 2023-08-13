namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/UMGSequencePlayer.h")]
public partial class UUMGSequencePlayer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>@return</summary>
	public string GetUserTag() { return default; }
	///<summary>SetUserTag</summary>
	public void SetUserTag(string InUserTag) {}
	///<summary>Animation being played</summary>
	public UWidgetAnimation Animation;
	///<summary>RootTemplateInstance</summary>
	public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance;
}
