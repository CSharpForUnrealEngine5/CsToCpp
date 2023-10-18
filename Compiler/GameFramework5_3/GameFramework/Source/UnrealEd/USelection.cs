namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages selections of objects.</summary>
[CppInclude("Selection.h")]
public partial class USelection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Underlying element selection set (if any).</summary>
	public UTypedElementSelectionSet ElementSelectionSet;
}
