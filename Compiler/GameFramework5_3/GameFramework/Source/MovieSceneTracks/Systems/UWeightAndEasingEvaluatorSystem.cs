namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System that combines manual weights and easings and propagates them to entities with matching EasingChannelID components</summary>
[CppInclude("Systems/WeightAndEasingEvaluatorSystem.h")]
public partial class UWeightAndEasingEvaluatorSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
}
