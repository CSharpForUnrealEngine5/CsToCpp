namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceActor.h")]
public partial class AMaterialInstanceActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to actors that we want to control paramters of using Matinee.</summary>
	public TArray<AActor> TargetActors;
}
