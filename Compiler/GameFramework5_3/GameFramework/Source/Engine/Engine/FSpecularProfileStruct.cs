namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>struct with all the settings we want in USpecularProfile, separate to make it easer to pass this data around in the engine.</summary>
[CppInclude("Engine/SpecularProfile.h")]
public partial struct FSpecularProfileStruct {
	public ESpecularProfileFormat Format;
	public FRuntimeCurveLinearColor ViewColor;
	public FRuntimeCurveLinearColor LightColor;
	public UTexture2D Texture;
}
