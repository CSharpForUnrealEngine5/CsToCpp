namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeTextureFactoryNode.h")]
public partial class UInterchangeTextureFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize node data</summary>
	public void InitializeTextureNode(string UniqueID,string DisplayLabel,string InAssetName) {}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>Get the translated texture node unique ID.</summary>
	public bool GetCustomTranslatedTextureNodeUid(string AttributeValue) { return default; }
	///<summary>Set the translated texture node unique ID. This is the reference to the node that was create by the translator and this node is needed to get the texture payload.</summary>
	public bool SetCustomTranslatedTextureNodeUid(string AttributeValue) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustBrightness(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustBrightness</summary>
	public bool SetCustomAdjustBrightness(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustBrightnessCurve(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustBrightnessCurve</summary>
	public bool SetCustomAdjustBrightnessCurve(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustVibrance(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustVibrance</summary>
	public bool SetCustomAdjustVibrance(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustSaturation(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustSaturation</summary>
	public bool SetCustomAdjustSaturation(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustRGBCurve(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustRGBCurve</summary>
	public bool SetCustomAdjustRGBCurve(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustHue(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustHue</summary>
	public bool SetCustomAdjustHue(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustMinAlpha(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustMinAlpha</summary>
	public bool SetCustomAdjustMinAlpha(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAdjustMaxAlpha(float AttributeValue) { return default; }
	///<summary>SetCustomAdjustMaxAlpha</summary>
	public bool SetCustomAdjustMaxAlpha(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustombChromaKeyTexture(bool AttributeValue) { return default; }
	///<summary>SetCustombChromaKeyTexture</summary>
	public bool SetCustombChromaKeyTexture(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomChromaKeyThreshold(float AttributeValue) { return default; }
	///<summary>SetCustomChromaKeyThreshold</summary>
	public bool SetCustomChromaKeyThreshold(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomChromaKeyColor(FColor AttributeValue) { return default; }
	///<summary>SetCustomChromaKeyColor</summary>
	public bool SetCustomChromaKeyColor(FColor AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomCompressionNoAlpha(bool AttributeValue) { return default; }
	///<summary>SetCustomCompressionNoAlpha</summary>
	public bool SetCustomCompressionNoAlpha(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomDeferCompression(bool AttributeValue) { return default; }
	///<summary>SetCustomDeferCompression</summary>
	public bool SetCustomDeferCompression(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomLossyCompressionAmount(byte AttributeValue) { return default; }
	///<summary>SetCustomLossyCompressionAmount</summary>
	public bool SetCustomLossyCompressionAmount(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomMaxTextureSize(int AttributeValue) { return default; }
	///<summary>SetCustomMaxTextureSize</summary>
	public bool SetCustomMaxTextureSize(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomCompressionQuality(byte AttributeValue) { return default; }
	///<summary>SetCustomCompressionQuality</summary>
	public bool SetCustomCompressionQuality(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomCompressionSettings(byte AttributeValue) { return default; }
	///<summary>SetCustomCompressionSettings</summary>
	public bool SetCustomCompressionSettings(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAlphaCoverageThresholds(FVector4 AttributeValue) { return default; }
	///<summary>SetCustomAlphaCoverageThresholds</summary>
	public bool SetCustomAlphaCoverageThresholds(FVector4 AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustombDoScaleMipsForAlphaCoverage(bool AttributeValue) { return default; }
	///<summary>SetCustombDoScaleMipsForAlphaCoverage</summary>
	public bool SetCustombDoScaleMipsForAlphaCoverage(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustombFlipGreenChannel(bool AttributeValue) { return default; }
	///<summary>SetCustombFlipGreenChannel</summary>
	public bool SetCustombFlipGreenChannel(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomPowerOfTwoMode(byte AttributeValue) { return default; }
	///<summary>SetCustomPowerOfTwoMode</summary>
	public bool SetCustomPowerOfTwoMode(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomPaddingColor(FColor AttributeValue) { return default; }
	///<summary>SetCustomPaddingColor</summary>
	public bool SetCustomPaddingColor(FColor AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomFilter(byte AttributeValue) { return default; }
	///<summary>SetCustomFilter</summary>
	public bool SetCustomFilter(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomMipLoadOptions(byte AttributeValue) { return default; }
	///<summary>SetCustomMipLoadOptions</summary>
	public bool SetCustomMipLoadOptions(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomSRGB(bool AttributeValue) { return default; }
	///<summary>SetCustomSRGB</summary>
	public bool SetCustomSRGB(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustombUseLegacyGamma(bool AttributeValue) { return default; }
	///<summary>SetCustombUseLegacyGamma</summary>
	public bool SetCustombUseLegacyGamma(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomVirtualTextureStreaming(bool AttributeValue) { return default; }
	///<summary>SetCustomVirtualTextureStreaming</summary>
	public bool SetCustomVirtualTextureStreaming(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustombPreserveBorder(bool AttributeValue) { return default; }
	///<summary>SetCustombPreserveBorder</summary>
	public bool SetCustombPreserveBorder(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomMipGenSettings(byte AttributeValue) { return default; }
	///<summary>SetCustomMipGenSettings</summary>
	public bool SetCustomMipGenSettings(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomLODBias(int AttributeValue) { return default; }
	///<summary>SetCustomLODBias</summary>
	public bool SetCustomLODBias(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomLODGroup(byte AttributeValue) { return default; }
	///<summary>SetCustomLODGroup</summary>
	public bool SetCustomLODGroup(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomDownscale(float AttributeValue) { return default; }
	///<summary>SetCustomDownscale</summary>
	public bool SetCustomDownscale(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomDownscaleOptions(byte AttributeValue) { return default; }
	///<summary>SetCustomDownscaleOptions</summary>
	public bool SetCustomDownscaleOptions(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomCompositeTextureMode(byte AttributeValue) { return default; }
	///<summary>SetCustomCompositeTextureMode</summary>
	public bool SetCustomCompositeTextureMode(byte AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomCompositePower(float AttributeValue) { return default; }
	///<summary>SetCustomCompositePower</summary>
	public bool SetCustomCompositePower(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomAllowNonPowerOfTwo(bool AttributeValue) { return default; }
	///<summary>* Should the factory allow the import of texture that would have a resolution that is not a power of two</summary>
	public bool SetCustomAllowNonPowerOfTwo(bool AttributeValue) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomPreferCompressedSourceData(bool AttributeValue) { return default; }
	///<summary>* Should the factory tell the translator to provide a compressed source data payload when available.</summary>
	public bool SetCustomPreferCompressedSourceData(bool AttributeValue) { return default; }
}
