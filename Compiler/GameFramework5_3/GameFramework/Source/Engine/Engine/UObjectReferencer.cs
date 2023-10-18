namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ObjectReferencer.h")]
public partial class UObjectReferencer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of objects being referenced.</summary>
	public TArray<UObject> ReferencedObjects;
}
