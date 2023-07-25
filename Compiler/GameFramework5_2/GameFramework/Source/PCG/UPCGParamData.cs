#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGParamData.h")]
///<summary>Class to hold execution parameters that will be consumed in nodes of the graph</summary>
public partial class UPCGParamData : UPCGData {
// PCGParamData
	public UObject ConstMetadata() { return default; }
	public UObject MutableMetadata() { return default; }
	public long FindMetadataKey(string InName) { return default; }
	public long FindOrAddMetadataKey(string InName) { return default; }
	public UObject FilterParamsByName(string InName) { return default; }
	public UObject FilterParamsByKey(long InKey) { return default; }
	public UPCGMetadata Metadata;
	public TMap<string,long> NameMap;
}
