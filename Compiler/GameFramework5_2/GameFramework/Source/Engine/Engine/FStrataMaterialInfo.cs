#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Gather information from the Substrate material graph to setup material for runtime.</summary>
public partial struct FStrataMaterialInfo {
// StrataMaterialInfo
	public ushort ShadingModelField;
	public byte bHasShadingModelFromExpression;
	public uint ConnectedProperties;
	public TArray<USubsurfaceProfile> SubsurfaceProfiles;
}
