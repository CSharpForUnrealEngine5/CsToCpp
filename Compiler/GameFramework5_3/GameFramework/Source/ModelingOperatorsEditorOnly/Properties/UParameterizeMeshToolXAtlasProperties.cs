namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/ParameterizeMeshProperties.h")]
public partial class UParameterizeMeshToolXAtlasProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Number of solve iterations; higher values generally result in better UV islands.</summary>
	public int MaxIterations;
}
