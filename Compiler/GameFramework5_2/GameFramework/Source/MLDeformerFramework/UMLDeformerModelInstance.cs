#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of the ML Deformer model.</summary>
[CppInclude("MLDeformerModelInstance.h")]
public partial class UMLDeformerModelInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The ML Deformer model that this is an instance of.</summary>
	public UMLDeformerModel Model;
}
