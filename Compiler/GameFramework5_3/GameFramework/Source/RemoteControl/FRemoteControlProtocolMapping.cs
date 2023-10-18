namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Mapping of the range of the values for the protocol</summary>
[CppInclude("RemoteControlProtocolBinding.h")]
public partial struct FRemoteControlProtocolMapping {
	public FGuid Id;
	public TArray<byte> InterpolationRangePropertyData;
	public TArray<byte> InterpolationMappingPropertyData;
	public TArray<byte> InterpolationRangePropertyDataCache;
	public TArray<byte> InterpolationMappingPropertyDataCache;
	public int InterpolationMappingPropertyElementNum;
	public object BoundPropertyPath;
}
