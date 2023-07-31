#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An external reference to an level sequence object, resolvable through an arbitrary context.</summary>
[CppInclude("ActorSequenceObjectReference.h")]
public partial struct FActorSequenceObjectReference {
	public EActorSequenceObjectReferenceType Type;
	public FGuid ActorId;
	public string PathToComponent;
}
