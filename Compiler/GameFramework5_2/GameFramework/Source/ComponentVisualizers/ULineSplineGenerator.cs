#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplineGeneratorPanel.h")]
public partial class ULineSplineGenerator : USplineGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>NumberOfPoints</summary>
	public int NumberOfPoints;
	///<summary>Length</summary>
	public double Length;
	///<summary>bEnableUpToNextPoint</summary>
	public bool bEnableUpToNextPoint;
	///<summary>If enabled, will add points up until the next existing point</summary>
	public bool bUpToNextPoint;
}
