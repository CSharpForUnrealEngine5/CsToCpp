#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolBinding.h")]
///<summary>* Mapping of the range of the values for the protocol</summary>
public partial struct FRemoteControlProtocolMapping {
// RemoteControlProtocolMapping
	public FGuid Id;
	public TArray<byte> InterpolationRangePropertyData;
	public TArray<byte> InterpolationMappingPropertyData;
	public TArray<byte> InterpolationRangePropertyDataCache;
	public TArray<byte> InterpolationMappingPropertyDataCache;
	public int InterpolationMappingPropertyElementNum;
	public object BoundPropertyPath;
}
