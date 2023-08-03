#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The machine learning deformer asset class.</summary>
[CppInclude("MLDeformerAsset.h")]
public partial class UMLDeformerAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The ML Deformer model, used to deform the mesh.</summary>
	public UMLDeformerModel Model;
}
