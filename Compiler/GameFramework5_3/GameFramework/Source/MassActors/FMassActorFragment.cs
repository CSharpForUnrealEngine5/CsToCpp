namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment to save the actor pointer of a mass entity if it exist</summary>
[CppInclude("MassActorSubsystem.h")]
public partial struct FMassActorFragment {
	public TWeakObjectPtr<AActor> Actor;
}
