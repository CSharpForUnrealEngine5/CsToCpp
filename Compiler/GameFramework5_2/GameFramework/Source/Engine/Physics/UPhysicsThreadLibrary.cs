#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/PhysicsThreadLibrary.h")]
public partial class UPhysicsThreadLibrary : UBlueprintFunctionLibrary {
	///<summary>Add a force to a single rigid body.</summary>
	public static void AddForce(FBodyInstanceAsyncPhysicsTickHandle Handle,FVector Force,bool bAccelChange/*=false*/) {}
}
