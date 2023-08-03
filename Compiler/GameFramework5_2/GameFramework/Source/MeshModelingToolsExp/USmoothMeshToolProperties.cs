#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PropertySet for properties affecting the Smoother.</summary>
[CppInclude("SmoothMeshTool.h")]
public partial class USmoothMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Type of smoothing to apply</summary>
	public ESmoothMeshToolSmoothType SmoothingType;
}
