namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System that finalizes creation of easing channels by allocating new channels for hierarchical blend targets if necessary</summary>
[CppInclude("Systems/WeightAndEasingEvaluatorSystem.h")]
public partial class UMovieSceneHierarchicalEasingFinalizationSystem : UMovieSceneEntityInstantiatorSystem {
	public static UClass StaticClass() {return default;}
	///<summary>InstantiatorSystem</summary>
	public UMovieSceneHierarchicalEasingInstantiatorSystem InstantiatorSystem;
}
