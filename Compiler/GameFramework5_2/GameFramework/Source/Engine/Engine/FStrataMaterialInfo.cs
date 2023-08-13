namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gather information from the Substrate material graph to setup material for runtime.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FStrataMaterialInfo {
	public ushort ShadingModelField;
	public byte bHasShadingModelFromExpression;
	public uint ConnectedProperties;
	public TArray<USubsurfaceProfile> SubsurfaceProfiles;
}
