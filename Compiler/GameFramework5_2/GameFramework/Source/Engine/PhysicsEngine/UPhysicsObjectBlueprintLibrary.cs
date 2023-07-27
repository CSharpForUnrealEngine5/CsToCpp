#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsObjectBlueprintLibrary.h")]
public partial class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary {
// PhysicsObjectBlueprintLibrary
	public static FClosestPhysicsObjectResult GetClosestPhysicsObjectFromWorldLocation(UPrimitiveComponent Component,FVector WorldLocation) { return default; }
	public static bool ExtractClosestPhysicsObjectResults(FClosestPhysicsObjectResult Result,string OutName) { return default; }
	public static FTransform GetPhysicsObjectWorldTransform(UPrimitiveComponent Component,string BoneName) { return default; }
}
