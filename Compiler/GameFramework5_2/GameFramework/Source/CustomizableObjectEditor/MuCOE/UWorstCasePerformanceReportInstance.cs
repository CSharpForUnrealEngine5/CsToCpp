#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/SCustomizableObjectEditorPerformanceReport.h")]
///<summary>Instances performing worst in some aspect</summary>
public partial class UWorstCasePerformanceReportInstance : UObject {
// WorstCasePerformanceReportInstance
	public UCustomizableObjectInstance WorstCaseInstance;
	public int LOD;
	public int TextureBytes;
	public int NumFaces;
	public float UpdateTime;
	public int LongestUpdateTimeStateIndex;
	public int LongestUpdateTimeParameterIndexInCO;
}
