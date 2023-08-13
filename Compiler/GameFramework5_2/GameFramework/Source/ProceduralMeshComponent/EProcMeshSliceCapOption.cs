namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetProceduralMeshLibrary.h")]
///<summary>Options for creating cap geometry when slicing</summary>
public enum EProcMeshSliceCapOption {
	NoCap=0,
	CreateNewSectionForCap=1,
	UseLastSectionForCap=2,
}
