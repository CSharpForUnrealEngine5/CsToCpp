namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGLoadAlembicElement.h")]
public partial class UPCGLoadAlembicSettings : UPCGExternalDataSettings {
	public static UClass StaticClass() {return default;}
	///<summary>AlembicFilePath</summary>
	public FFilePath AlembicFilePath;
	///<summary>Scale to apply during import. Note that for both Max/Maya presets the value flips the Y axis.</summary>
	public FVector ConversionScale;
	///<summary>Rotation in Euler angles applied during import. For Max, use (90, 0, 0).</summary>
	public FVector ConversionRotation;
	///<summary>Flips rotation direction (W), useful together with swizzling</summary>
	public bool bConversionFlipHandedness;
	///<summary>SetupFromStandard</summary>
	public void SetupFromStandard(EPCGLoadAlembicStandardSetup InSetup) {}
	///<summary>Setup</summary>
	public EPCGLoadAlembicStandardSetup Setup;
}
