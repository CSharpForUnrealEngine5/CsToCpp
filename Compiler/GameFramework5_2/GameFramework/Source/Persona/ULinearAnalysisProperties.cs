namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpaceAnalysis.h")]
public partial class ULinearAnalysisProperties : UAnalysisProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Axis for the analysis function</summary>
	public EAnalysisLinearAxis FunctionAxis;
	///<summary>The bone or socket used for analysis</summary>
	public FBoneSocketTarget BoneSocket;
	///<summary>The space in which to perform the analysis. Fixed will use the analysis bone/socket at the first frame</summary>
	public EAnalysisSpace Space;
	///<summary>Bone or socket that defines the analysis space (when it isn&#39;t World)</summary>
	public FBoneSocketTarget SpaceBoneSocket;
	///<summary>Fraction through each animation at which analysis starts</summary>
	public float StartTimeFraction;
	///<summary>Fraction through each animation at which analysis ends</summary>
	public float EndTimeFraction;
}
