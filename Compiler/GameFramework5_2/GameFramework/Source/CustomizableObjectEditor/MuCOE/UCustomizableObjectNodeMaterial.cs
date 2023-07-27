#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterial.h")]
public partial class UCustomizableObjectNodeMaterial : UCustomizableObjectNodeMaterialBase {
// CustomizableObjectNodeMaterial
	public UMaterialInterface Material;
	public ENodePinMode TextureParametersMode;
	public TArray<string> Tags;
	public int MeshComponentIndex;
	public TMap<FGuid,FEdGraphPinReference> PinsParameter;
	public TMap<FGuid,EPinMode> PinsImagePinMode;
	public  void MeshPostEditChangeProperty(FPostEditChangePropertyDelegateParameters Parameters) {}
	public bool bDefaultPinModeMutable_DEPRECATED;
	public TArray<FCustomizableObjectNodeMaterialImage> Images_DEPRECATED;
	public TArray<FCustomizableObjectNodeMaterialVector> VectorParams_DEPRECATED;
	public TArray<FCustomizableObjectNodeMaterialScalar> ScalarParams_DEPRECATED;
}
