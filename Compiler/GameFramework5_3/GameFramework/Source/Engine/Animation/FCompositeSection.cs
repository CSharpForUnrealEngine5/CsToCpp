namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Section data for each track. Reference of data will be stored in the child class for the way they want</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial struct FCompositeSection {
	public FName SectionName;
	public float StartTime_DEPRECATED;
	public FName NextSectionName;
	public TArray<UAnimMetaData> MetaData;
}
