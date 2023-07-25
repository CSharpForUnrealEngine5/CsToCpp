#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ObjectLibrary.h")]
///<summary>Class that holds a library of Objects</summary>
public partial class UObjectLibrary : UObject {
// ObjectLibrary
	public UClass ObjectBaseClass;
	public bool bHasBlueprintClasses;
	public TArray<UObject> Objects;
	public TArray<TWeakObjectPtr<UObject>> WeakObjects;
	public bool bUseWeakReferences;
	public bool bIsFullyLoaded;
}
