namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameter binding block entry</summary>
[CppInclude("Param/AnimNextParameterBlockBinding.h")]
public partial class UAnimNextParameterBlockBinding : UAnimNextParameterBlockEntry {
	public static UClass StaticClass() {return default;}
	///<summary>Parameter name we reference</summary>
	public FName ParameterName;
	///<summary>Parameter library we reference</summary>
	public UAnimNextParameterLibrary Library;
	///<summary>Binding graph</summary>
	public URigVMGraph BindingGraph;
}
