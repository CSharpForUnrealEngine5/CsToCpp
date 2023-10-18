namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerMorphModelInputInfo.h")]
public partial class UMLDeformerMorphModelInputInfo : UMLDeformerInputInfo {
	public static UClass StaticClass() {return default;}
	///<summary>The buffer of mask values, which contains one float per imported vertex, for all input items.</summary>
	public TArray<float> InputItemMaskBuffer;
}
