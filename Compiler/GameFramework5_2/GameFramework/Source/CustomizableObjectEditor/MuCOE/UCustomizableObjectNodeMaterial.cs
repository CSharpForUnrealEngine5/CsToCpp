#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterial.h")]
public partial class UCustomizableObjectNodeMaterial : UCustomizableObjectNodeMaterialBase {
	public static UClass StaticClass() {return default;}
	///<summary>Material</summary>
	public UMaterialInterface Material;
	///<summary>Set all Mateiral Texture Parameters to the specified mode. Each Texture Parameter Pin can override this mode.</summary>
	public ENodePinMode TextureParametersMode;
	///<summary>Tags</summary>
	public TArray<string> Tags;
	///<summary>Selects which Mesh component of the Instance this material belongs to</summary>
	public int MeshComponentIndex;
	///<summary>Relates a Parameter id (key) to a Pin (value). Only used to improve performance.</summary>
	public TMap<FGuid,FEdGraphPinReference> PinsParameter;
	///<summary>Relates an Image pin (key) to its Image Pin Mode (value).</summary>
	public TMap<FGuid,EPinMode> PinsImagePinMode;
	///<summary>Connected NodeStaticMesh or NodeSkeletalMesh Mesh UPROPERTY changed callback function. Sets the default material.</summary>
	public  void MeshPostEditChangeProperty(FPostEditChangePropertyDelegateParameters Parameters) {}
	///<summary>Set all pins to Mutable mode. Even so, each pin can override its behaviour.</summary>
	public bool bDefaultPinModeMutable_DEPRECATED;
	///<summary>Images_DEPRECATED</summary>
	public TArray<FCustomizableObjectNodeMaterialImage> Images_DEPRECATED;
	///<summary>VectorParams_DEPRECATED</summary>
	public TArray<FCustomizableObjectNodeMaterialVector> VectorParams_DEPRECATED;
	///<summary>ScalarParams_DEPRECATED</summary>
	public TArray<FCustomizableObjectNodeMaterialScalar> ScalarParams_DEPRECATED;
}
