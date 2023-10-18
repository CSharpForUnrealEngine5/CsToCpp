namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocomotionAnalysis.h")]
public partial class ULocomotionAnalysisProperties : UAnalysisProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Axis for the analysis function</summary>
	public EAnalysisLocomotionAxis FunctionAxis;
	///<summary>The primary bone or socket used for analysis</summary>
	public FBoneSocketTarget PrimaryBoneSocket;
	///<summary>The secondary bone or socket used for analysis</summary>
	public FBoneSocketTarget SecondaryBoneSocket;
	///<summary>World or bone/socket axis that specifies the character&#39;s facing direction</summary>
	public EAnalysisLinearAxis CharacterFacingAxis;
	///<summary>World or bone/socket axis that specifies the character&#39;s up direction</summary>
	public EAnalysisLinearAxis CharacterUpAxis;
}
