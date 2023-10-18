namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyBlueprintFunctionLibrary.h")]
public partial class UPropertyBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a path containing information which class declare the property.</summary>
	public static string GetPropertyOriginPath(object Property) { return default; }
	///<summary>Gets only the property name of a property.</summary>
	public static string GetPropertyName(object Property) { return default; }
	///<summary>Loads the actor identified by Params. You can use this for advanced filter queries.</summary>
	public AActor LoadSnapshotActor(FIsDeletedActorValidParams Params) { return default; }
}
