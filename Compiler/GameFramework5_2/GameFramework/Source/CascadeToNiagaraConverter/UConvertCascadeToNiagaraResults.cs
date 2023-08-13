namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper class for passing results back from the ConvertCascadeToNiagara python script.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UConvertCascadeToNiagaraResults : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Init</summary>
	public void Init() {}
	///<summary>Whether the converter process was cancelled by the user.</summary>
	public bool bCancelledByUser;
	///<summary>Whether the converter process was cancelled due to an unrecoverable error in the python script process.</summary>
	public bool bCancelledByPythonError;
}
