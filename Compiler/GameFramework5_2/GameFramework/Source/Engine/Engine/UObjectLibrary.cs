#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that holds a library of Objects</summary>
[CppInclude("Engine/ObjectLibrary.h")]
public partial class UObjectLibrary : UObject {
	///<summary>Class that Objects must be of. If ContainsBlueprints is true, this is the native class that the blueprints are instances of and not UClass</summary>
	public UClass ObjectBaseClass;
	///<summary>True if this library holds blueprint classes, false if it holds other objects</summary>
	public bool bHasBlueprintClasses;
	///<summary>List of Objects in library</summary>
	public TArray<UObject> Objects;
	///<summary>Weak pointers to objects</summary>
	public TArray<TWeakObjectPtr<UObject>> WeakObjects;
	///<summary>If this library should use weak pointers</summary>
	public bool bUseWeakReferences;
	///<summary>True if we&#39;ve already fully loaded this library, can&#39;t do it twice</summary>
	public bool bIsFullyLoaded;
}
