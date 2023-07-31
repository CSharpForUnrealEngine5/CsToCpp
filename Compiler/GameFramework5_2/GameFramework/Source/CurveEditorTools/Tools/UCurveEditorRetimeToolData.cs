#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/CurveEditorRetimeTool.h")]
public partial class UCurveEditorRetimeToolData : UObject {
	///<summary>List of anchor points. Assumes they&#39;re in order from lowest input time to greatest.</summary>
	public TArray<FCurveEditorRetimeAnchor> RetimingAnchors;
}
