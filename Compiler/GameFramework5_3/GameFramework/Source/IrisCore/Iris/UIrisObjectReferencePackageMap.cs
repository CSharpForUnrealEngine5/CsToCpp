namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom packagemap implementation used to be able to capture UObject* references from external serialization.</summary>
[CppInclude("Iris/Serialization/IrisObjectReferencePackageMap.h")]
public partial class UIrisObjectReferencePackageMap : UPackageMap {
	public static UClass StaticClass() {return default;}
}
