namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImportGDTF.h")]
public partial struct FDMXImportGDTFChannelFunction {
	public FName Name;
	public FDMXImportGDTFAttribute Attribute;
	public string OriginalAttribute;
	public FDMXImportGDTFDMXValue DMXFrom;
	public FDMXImportGDTFDMXValue DMXValue;
	public float PhysicalFrom;
	public float PhysicalTo;
	public float RealFade;
	public FDMXImportGDTFWheel Wheel;
	public FDMXImportGDTFEmitter Emitter;
	public FDMXImportGDTFFilter Filter;
	public EDMXImportGDTFDMXInvert DMXInvert;
	public string ModeMaster;
	public FDMXImportGDTFDMXValue ModeFrom;
	public FDMXImportGDTFDMXValue ModeTo;
	public TArray<FDMXImportGDTFChannelSet> ChannelSets;
}
