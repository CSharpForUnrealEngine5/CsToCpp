namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling how proximity is detected for geometry collections</summary>
[CppInclude("FractureToolProximity.h")]
public partial class UFractureProximitySettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Which method to use to decide whether a given piece of geometry is in proximity with another</summary>
	public EProximityMethod Method;
	///<summary>If hull-based proximity detection is enabled, amount to expand hulls when searching for overlapping neighbors</summary>
	public double DistanceThreshold;
	///<summary>Method to use to determine the contact between two pieces, if the Contact Threshold is greater than 0</summary>
	public EProximityContactMethod ContactMethod;
	///<summary>If greater than zero, proximity will be additionally filtered by a &#39;contact&#39; threshold, in cm, to exclude grazing / corner proximity</summary>
	public double ContactThreshold;
	///<summary>Whether to automatically transform the proximity graph into a connection graph to be used for simulation</summary>
	public bool bUseAsConnectionGraph;
	///<summary>Method to use for determining contact areas that define the strength of connections for destruction simulation</summary>
	public EConnectionContactMethod ContactAreaMethod;
	///<summary>Whether to display the proximity graph edges</summary>
	public bool bShowProximity;
	///<summary>Whether to only show the proximity graph connections for selected bones</summary>
	public bool bOnlyShowForSelected;
	///<summary>Line thickness for connections</summary>
	public float LineThickness;
	///<summary>Line color for connections</summary>
	public FColor LineColor;
	///<summary>Point size for centers</summary>
	public float CenterSize;
	///<summary>Point color for centers</summary>
	public FColor CenterColor;
}
