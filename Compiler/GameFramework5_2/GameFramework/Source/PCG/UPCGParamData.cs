#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGParamData.h")]
///<summary>Class to hold execution parameters that will be consumed in nodes of the graph</summary>
public partial class UPCGParamData : UPCGData {
// PCGParamData
	public  UPCGMetadata ConstMetadata() { return default; }
	public  UPCGMetadata MutableMetadata() { return default; }
	public  long FindMetadataKey(string InName) { return default; }
	public  long FindOrAddMetadataKey(string InName) { return default; }
	public  UPCGParamData FilterParamsByName(string InName) { return default; }
	public  UPCGParamData FilterParamsByKey(long InKey) { return default; }
	public UPCGMetadata Metadata;
	public TMap<string,long> NameMap;
}
