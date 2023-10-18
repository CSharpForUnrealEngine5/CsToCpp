namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineGeneratorPanel.h")]
public partial class USquareSplineGenerator : USplineGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Length</summary>
	public float Length;
	///<summary>If enabled, will switch the shape&#39;s center to the right of the curve</summary>
	public bool bBranchRight;
}
