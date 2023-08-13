namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneEvent.h")]
public partial struct FMovieSceneEvent {
	public FMovieSceneEventPtrs Ptrs;
	public TMap<string,FMovieSceneEventPayloadVariable> PayloadVariables;
	public string CompiledFunctionName;
	public string BoundObjectPinName;
	public TWeakObjectPtr<UObject> WeakEndpoint;
	public FGuid GraphGuid_DEPRECATED;
	public FGuid NodeGuid_DEPRECATED;
	public TWeakObjectPtr<UObject> FunctionEntry_DEPRECATED;
}
