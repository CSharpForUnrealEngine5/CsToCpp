#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVTools/UVGenerationDataprepOperation.h")]
///<summary>For each static mesh to process, generate an unwrapped UV map in the specified channel</summary>
public partial class UUVGenerationFlattenMappingOperation : UDataprepOperation {
// UVGenerationFlattenMappingOperation
	public EUnwrappedUVDatasmithOperationChannelSelection ChannelSelection;
	public int UVChannel;
	public float AngleThreshold;
}
