namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameter binding block entry</summary>
[CppInclude("Param/AnimNextParameterBlockBindingReference.h")]
public partial class UAnimNextParameterBlockBindingReference : UAnimNextParameterBlockEntry {
	public static UClass StaticClass() {return default;}
	///<summary>Parameter name we reference</summary>
	public FName ParameterName;
	///<summary>Parameter library we reference</summary>
	public UAnimNextParameterLibrary Library;
	///<summary>Parameter block we reference</summary>
	public UAnimNextParameterBlock Block;
}
