namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a dynamic binding endpoint call.</summary>
[CppInclude("MovieSceneDynamicBinding.h")]
public partial struct FMovieSceneDynamicBinding {
	public UFunction Function;
	public object ResolveParamsProperty;
	public TMap<FName,FMovieSceneDynamicBindingPayloadVariable> PayloadVariables;
	public FName CompiledFunctionName;
	public FName ResolveParamsPinName;
	public TWeakObjectPtr<UObject> WeakEndpoint;
}
