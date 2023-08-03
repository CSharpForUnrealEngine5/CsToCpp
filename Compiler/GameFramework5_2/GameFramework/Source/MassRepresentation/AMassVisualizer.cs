#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor holding the mass visual component responsible to handle the representation of the mass agent as the static mesh instances</summary>
[CppInclude("MassVisualizer.h")]
public partial class AMassVisualizer : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>VisComponent</summary>
	public UMassVisualizationComponent VisComponent;
}
