namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsObjectBlueprintLibrary.h")]
public partial class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetClosestPhysicsObjectFromWorldLocation</summary>
	public static FClosestPhysicsObjectResult GetClosestPhysicsObjectFromWorldLocation(UPrimitiveComponent Component,FVector WorldLocation) { return default; }
	///<summary>ExtractClosestPhysicsObjectResults</summary>
	public static bool ExtractClosestPhysicsObjectResults(FClosestPhysicsObjectResult Result,string OutName) { return default; }
	///<summary>GetPhysicsObjectWorldTransform</summary>
	public static FTransform GetPhysicsObjectWorldTransform(UPrimitiveComponent Component,string BoneName) { return default; }
}
