#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test patterns actor</summary>
[CppInclude("DisplayClusterTestPatternsActor.h")]
public partial class ADisplayClusterTestPatternsActor : AActor {
	///<summary>Postprocess component</summary>
	public UPostProcessComponent PostProcessComponent;
	///<summary>CalibrationPatterns</summary>
	public TMap<string,UMaterial> CalibrationPatterns;
	///<summary>ViewportPPSettings</summary>
	public TMap<string,FPostProcessSettings> ViewportPPSettings;
}
