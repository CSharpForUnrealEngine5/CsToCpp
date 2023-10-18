namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPrimitiveTool.h")]
public partial class UProceduralTorusToolProperties : UProceduralShapeToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Major radius of the torus, measured from the torus center to the center of the torus tube</summary>
	public float MajorRadius;
	///<summary>Minor radius of the torus, measured from the center ot the torus tube to the tube surface</summary>
	public float MinorRadius;
	///<summary>Number of radial slices along the torus tube</summary>
	public int MajorSlices;
	///<summary>Number of radial slices around the torus tube</summary>
	public int MinorSlices;
}
