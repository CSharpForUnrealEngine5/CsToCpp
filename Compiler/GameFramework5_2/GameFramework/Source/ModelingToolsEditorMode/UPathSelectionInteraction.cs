#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPathSelectionInteraction is a simple drag-interaction for Selection, which essentially just</summary>
[CppInclude("ModelingSelectionInteraction.h")]
public partial class UPathSelectionInteraction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectionInteraction</summary>
	public TWeakObjectPtr<UModelingSelectionInteraction> SelectionInteraction;
}
