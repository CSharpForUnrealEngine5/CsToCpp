namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/PhysicsThreadLibrary.h")]
public partial class UPhysicsThreadLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Add a force to a single rigid body.</summary>
	public static void AddForce(FBodyInstanceAsyncPhysicsTickHandle Handle,FVector Force,bool bAccelChange/*=false*/) {}
}
