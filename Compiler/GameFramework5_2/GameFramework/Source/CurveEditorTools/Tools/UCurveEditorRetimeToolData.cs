namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/CurveEditorRetimeTool.h")]
public partial class UCurveEditorRetimeToolData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of anchor points. Assumes they&#39;re in order from lowest input time to greatest.</summary>
	public TArray<FCurveEditorRetimeAnchor> RetimingAnchors;
}
