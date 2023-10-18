namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGLoadAlembic.h")]
public partial struct FPCGLoadAlembicBPData {
	public FFilePath AlembicFilePath;
	public FAbcConversionSettings ConversionSettings;
	public bool bConversionFlipHandedness;
	public TMap<string,FPCGAttributePropertyInputSelector> AttributeMapping;
}
