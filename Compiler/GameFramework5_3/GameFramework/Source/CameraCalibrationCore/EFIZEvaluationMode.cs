namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Mode that controls where FIZ inputs are sourced from and how they are used to evaluate the LensFile</summary>
public enum EFIZEvaluationMode {
	UseLiveLink=0,
	UseCameraSettings=1,
	UseRecordedValues=2,
	DoNotEvaluate=3,
}
