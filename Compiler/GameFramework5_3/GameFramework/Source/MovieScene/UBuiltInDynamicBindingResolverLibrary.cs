namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default dynamic binding resolver library, with several basic resolver functions.</summary>
[CppInclude("MovieSceneDynamicBinding.h")]
public partial class UBuiltInDynamicBindingResolverLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Resolve the bound object to the player&#39;s pawn</summary>
	public static FMovieSceneDynamicBindingResolveResult ResolveToPlayerPawn(UObject WorldContextObject,int PlayerControllerIndex/*=0*/) { return default; }
}
