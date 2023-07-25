#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorSequenceObjectReference.h")]
///<summary>An external reference to an level sequence object, resolvable through an arbitrary context.</summary>
public partial struct FActorSequenceObjectReference {
// ActorSequenceObjectReference
	public EActorSequenceObjectReferenceType Type;
	public FGuid ActorId;
	public string PathToComponent;
}
