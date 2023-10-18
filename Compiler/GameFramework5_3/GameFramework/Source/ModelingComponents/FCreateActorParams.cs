namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateActorParams is a collection of input data intended to be passed to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateActorParams {
	public UWorld TargetWorld;
	public string BaseName;
	public FTransform Transform;
	public AActor TemplateActor;
}
