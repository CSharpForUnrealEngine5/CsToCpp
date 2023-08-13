namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInteractiveGizmo is the base class for all Gizmos in the InteractiveToolsFramework.</summary>
[CppInclude("InteractiveGizmo.h")]
public partial class UInteractiveGizmo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The current set of InputBehaviors provided by this Gizmo</summary>
	public UInputBehaviorSet InputBehaviors;
}
