namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This settings class is used to create a PCG node that will apply a &quot;Match and Set&quot; operation</summary>
[CppInclude("Elements/PCGPointMatchAndSet.h")]
public partial class UPCGPointMatchAndSetSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Recreates the match &amp; set instance stored in this settings object if needed.</summary>
	public void SetMatchAndSetType(UClass InMatchAndSetType) {}
	///<summary>Defines the type of Match &amp; Set object to use.</summary>
	public UClass MatchAndSetType;
	///<summary>Instance of MatchAndSetType, stores the data that will be used in these settings.</summary>
	public UPCGMatchAndSetBase MatchAndSetInstance;
	///<summary>&quot;Set&quot; part of the Match &amp; Set - defines what will be changed in the operation</summary>
	public FPCGAttributePropertyOutputSelector SetTarget;
	///<summary>If the &quot;Set&quot; part is an attribute, then the type must be provided</summary>
	public EPCGMetadataTypes SetTargetType;
	///<summary>For string types, the subtype is used to cleanup the UI.</summary>
	public EPCGMetadataTypesConstantStructStringMode SetTargetStringMode;
	///<summary>Property used to sidestep edit condition issues - reflects SetTarget.Selection == Attribute</summary>
	public bool bSetTargetIsAttribute;
}
