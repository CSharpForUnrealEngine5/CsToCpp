#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial struct FPCGTaggedData {
// PCGTaggedData
	public UPCGData Data;
	public TSet<string> Tags;
	public string Pin;
	public bool bPinlessData;
}
