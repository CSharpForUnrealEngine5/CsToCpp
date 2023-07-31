#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Manages selections of objects.</summary>
[CppInclude("Selection.h")]
public partial class USelection : UObject {
	///<summary>Underlying element selection set (if any).</summary>
	public UTypedElementSelectionSet ElementSelectionSet;
}
