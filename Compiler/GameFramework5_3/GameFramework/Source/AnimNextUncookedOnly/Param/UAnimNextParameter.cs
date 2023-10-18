namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a single parameter</summary>
[CppInclude("Param/AnimNextParameter.h")]
public partial class UAnimNextParameter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The parameter&#39;s type</summary>
	public FAnimNextParamType Type;
	///<summary>Comment to display in editor</summary>
	public string Comment;
}
