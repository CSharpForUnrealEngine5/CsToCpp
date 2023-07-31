#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set of parameters + state that defines a CustomizableObjectInstance.</summary>
[CppInclude("MuCO/CustomizableObjectInstanceDescriptor.h")]
public partial struct FCustomizableObjectInstanceDescriptor {
	public UCustomizableObject CustomizableObject;
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters;
	public TArray<FCustomizableObjectIntParameterValue> IntParameters;
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters;
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters;
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters;
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters;
	public TMap<string,FMultilayerProjector> MultilayerProjectors;
}
