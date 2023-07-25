#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectInstanceDescriptor.h")]
///<summary>Set of parameters + state that defines a CustomizableObjectInstance.</summary>
public partial struct FCustomizableObjectInstanceDescriptor {
// CustomizableObjectInstanceDescriptor
	public UCustomizableObject CustomizableObject;
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters;
	public TArray<FCustomizableObjectIntParameterValue> IntParameters;
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters;
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters;
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters;
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters;
	public TMap<string,FMultilayerProjector> MultilayerProjectors;
}
