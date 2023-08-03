#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instances performing worst in some aspect</summary>
[CppInclude("MuCOE/SCustomizableObjectEditorPerformanceReport.h")]
public partial class UWorstCasePerformanceReportInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>&quot;PerformanceReport|BiggestTextureSize&quot;</summary>
	public UCustomizableObjectInstance WorstCaseInstance;
	///<summary>&quot;PerformanceReport|BiggestTextureSize&quot;</summary>
	public int LOD;
	///<summary>Total texture memory size that this instance had when the worst case was recorded (currently only relevant when LARGEST_TEXTURE_SIZE)</summary>
	public int TextureBytes;
	///<summary>Amount of triangles this instance had when the worst case was recorded (currently only relevant when MOST_TRIANGLES)</summary>
	public int NumFaces;
	///<summary>How long it took this instance to update when the worst case was recorded (currently only relevant when SLOWEST_UPDATE_PARAM_IN_RELEVANT_STATE or SLOWEST_UPDATE_PARAM_IN_RELEVANT_STATE)</summary>
	public float UpdateTime;
	///<summary>State CO index where this instance took most cycles to update (currently only relevant when SLOWEST_UPDATE_ENTER_STATE or SLOWEST_UPDATE_PARAM_IN_RELEVANT_STATE)</summary>
	public int LongestUpdateTimeStateIndex;
	///<summary>Parameter CO index where this instance took most cycles to update (currently only relevant when SLOWEST_UPDATE_PARAM_IN_RELEVANT_STATE)</summary>
	public int LongestUpdateTimeParameterIndexInCO;
}
