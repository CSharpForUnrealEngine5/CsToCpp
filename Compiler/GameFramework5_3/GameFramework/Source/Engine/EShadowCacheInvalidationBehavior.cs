namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SceneTypes.h")]
///<summary>Setting to control shadow invalidation behavior (in particular with respect to Virtual Shadow Maps and future methods).</summary>
public enum EShadowCacheInvalidationBehavior {
	Auto=0,
	Always=1,
	Rigid=2,
	Static=3,
}
