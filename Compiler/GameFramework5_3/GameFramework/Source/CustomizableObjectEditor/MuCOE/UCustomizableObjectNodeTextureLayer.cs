namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTextureLayer.h")]
public partial class UCustomizableObjectNodeTextureLayer : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Layers</summary>
	public TArray<FCustomizableObjectTextureLayer> Layers;
	///<summary>OutputPinReference</summary>
	public FEdGraphPinReference OutputPinReference;
}
