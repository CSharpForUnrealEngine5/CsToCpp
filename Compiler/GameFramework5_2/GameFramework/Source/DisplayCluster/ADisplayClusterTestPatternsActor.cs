namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test patterns actor</summary>
[CppInclude("DisplayClusterTestPatternsActor.h")]
public partial class ADisplayClusterTestPatternsActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Postprocess component</summary>
	public UPostProcessComponent PostProcessComponent;
	///<summary>CalibrationPatterns</summary>
	public TMap<string,UMaterial> CalibrationPatterns;
	///<summary>ViewportPPSettings</summary>
	public TMap<string,FPostProcessSettings> ViewportPPSettings;
}
