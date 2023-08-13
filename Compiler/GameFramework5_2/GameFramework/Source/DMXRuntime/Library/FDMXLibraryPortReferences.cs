namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom struct of in put and output port references for custom details customization with an enabled state</summary>
[CppInclude("Library/DMXLibrary.h")]
public partial struct FDMXLibraryPortReferences {
	public TArray<FDMXInputPortReference> InputPortReferences;
	public TArray<FDMXOutputPortReference> OutputPortReferences;
}
