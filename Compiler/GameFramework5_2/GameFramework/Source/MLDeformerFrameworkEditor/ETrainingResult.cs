#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerEditorModel.h")]
///<summary>Training process return codes.</summary>
public enum ETrainingResult {
	Success=0,
	Aborted=1,
	AbortedCantUse=2,
	FailOnData=3,
	FailPythonError=4,
}
