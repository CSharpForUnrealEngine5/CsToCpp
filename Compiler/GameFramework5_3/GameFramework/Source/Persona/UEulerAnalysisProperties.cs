namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpaceAnalysis.h")]
public partial class UEulerAnalysisProperties : UAnalysisProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Axis for the analysis function</summary>
	public EAnalysisEulerAxis FunctionAxis;
	///<summary>The bone or socket used for analysis</summary>
	public FBoneSocketTarget BoneSocket;
	///<summary>Used for some analysis functions - specifies the bone/socket axis that points in the facing/forwards direction</summary>
	public EAnalysisLinearAxis BoneFacingAxis;
	///<summary>Used for some analysis functions - specifies the bone/socket axis that points to the &quot;right&quot;</summary>
	public EAnalysisLinearAxis BoneRightAxis;
	///<summary>The space in which to perform the analysis. Fixed will use the analysis bone/socket at the first frame</summary>
	public EAnalysisSpace Space;
	///<summary>Bone or socket that defines the analysis space (when it isn&#39;t World)</summary>
	public FBoneSocketTarget SpaceBoneSocket;
	///<summary>World or bone/socket axis that specifies the character&#39;s facing direction</summary>
	public EAnalysisLinearAxis CharacterFacingAxis;
	///<summary>World or bone/socket axis that specifies the character&#39;s up direction</summary>
	public EAnalysisLinearAxis CharacterUpAxis;
	///<summary>Fraction through each animation at which analysis starts</summary>
	public float StartTimeFraction;
	///<summary>Fraction through each animation at which analysis ends</summary>
	public float EndTimeFraction;
}
