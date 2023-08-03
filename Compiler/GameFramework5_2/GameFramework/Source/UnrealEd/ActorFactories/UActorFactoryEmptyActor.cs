#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFactories/ActorFactoryEmptyActor.h")]
public partial class UActorFactoryEmptyActor : UActorFactory {
	public static UClass StaticClass() {return default;}
	///<summary>If true a sprite will be added to visualize the actor in the world</summary>
	public bool bVisualizeActor;
}
