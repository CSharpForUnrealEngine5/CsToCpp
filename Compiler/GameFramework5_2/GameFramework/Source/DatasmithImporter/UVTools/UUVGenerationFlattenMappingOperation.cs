#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, generate an unwrapped UV map in the specified channel</summary>
[CppInclude("UVTools/UVGenerationDataprepOperation.h")]
public partial class UUVGenerationFlattenMappingOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>ChannelSelection</summary>
	public EUnwrappedUVDatasmithOperationChannelSelection ChannelSelection;
	///<summary>The UV channel where to generate the flatten mapping</summary>
	public int UVChannel;
	///<summary>AngleThreshold</summary>
	public float AngleThreshold;
}
