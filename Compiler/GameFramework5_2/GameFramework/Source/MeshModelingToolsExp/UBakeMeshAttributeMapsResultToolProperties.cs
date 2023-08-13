namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeMapsToolBase.h")]
public partial class UBakeMeshAttributeMapsResultToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Bake</summary>
	public TMap<EBakeMapType,UTexture2D> Result;
}
