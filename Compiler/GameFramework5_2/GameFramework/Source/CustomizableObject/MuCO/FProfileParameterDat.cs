namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FProfileParameterDat {
	public string ProfileName;
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters;
	public TArray<FCustomizableObjectIntParameterValue> IntParameters;
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters;
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters;
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters;
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters;
}
