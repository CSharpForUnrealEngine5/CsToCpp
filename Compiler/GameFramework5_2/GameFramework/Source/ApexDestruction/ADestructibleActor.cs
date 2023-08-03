#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleActor.h")]
public partial class ADestructibleActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>DestructibleComponent</summary>
	public UDestructibleComponent DestructibleComponent;
	///<summary>OnActorFracture</summary>
	public FActorFractureSignature OnActorFracture;
	///<summary>bAffectNavigation</summary>
	public bool bAffectNavigation;
}
