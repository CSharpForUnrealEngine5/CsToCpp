namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneEvent.h")]
public partial struct FMovieSceneEvent {
	public FMovieSceneEventPtrs Ptrs;
	public TMap<FName,FMovieSceneEventPayloadVariable> PayloadVariables;
	public FName CompiledFunctionName;
	public FName BoundObjectPinName;
	public TWeakObjectPtr<UObject> WeakEndpoint;
	public FGuid GraphGuid_DEPRECATED;
	public FGuid NodeGuid_DEPRECATED;
	public TWeakObjectPtr<UObject> FunctionEntry_DEPRECATED;
}
