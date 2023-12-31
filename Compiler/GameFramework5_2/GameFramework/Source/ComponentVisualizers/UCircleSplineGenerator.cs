namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineGeneratorPanel.h")]
public partial class UCircleSplineGenerator : USplineGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>Number of points making up shape</summary>
	public int NumberOfPoints;
	///<summary>Radius of circle</summary>
	public float Radius;
	///<summary>If enabled, will reverse the direction of the circle</summary>
	public bool bReverseDir;
	///<summary>If enabled, will start the shape tangent to the current path</summary>
	public bool bKeepFirstKeyTangent;
	///<summary>If enabled, will switch the circle&#39;s center to the right of the curve</summary>
	public bool bBranchRight;
}
