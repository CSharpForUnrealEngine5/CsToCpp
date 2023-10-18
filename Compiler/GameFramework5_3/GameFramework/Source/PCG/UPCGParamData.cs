namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to hold execution parameters that will be consumed in nodes of the graph</summary>
[CppInclude("PCGParamData.h")]
public partial class UPCGParamData : UPCGData {
	public static UClass StaticClass() {return default;}
	///<summary>~End UPCGData interface</summary>
	public UPCGMetadata ConstMetadata() { return default; }
	///<summary>MutableMetadata</summary>
	public UPCGMetadata MutableMetadata() { return default; }
	///<summary>Returns the entry for the given name</summary>
	public long FindMetadataKey(FName InName) { return default; }
	///<summary>Creates an entry for the given name, if not already added</summary>
	public long FindOrAddMetadataKey(FName InName) { return default; }
	///<summary>Creates a new params that keeps only a given key/name</summary>
	public UPCGParamData FilterParamsByName(FName InName) { return default; }
	///<summary>FilterParamsByKey</summary>
	public UPCGParamData FilterParamsByKey(long InKey) { return default; }
	///<summary>Not accessible through blueprint to make sure the constness is preserved</summary>
	public UPCGMetadata Metadata;
	///<summary>NameMap</summary>
	public TMap<FName,long> NameMap;
	///<summary>Cache to keep track of the latest attribute manipulated on this data.</summary>
	public bool bHasCachedLastSelector;
	///<summary>CachedLastSelector</summary>
	public FPCGAttributePropertyInputSelector CachedLastSelector;
}
