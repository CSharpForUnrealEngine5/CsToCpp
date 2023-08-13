namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class containing definition of a navigation area</summary>
[CppInclude("NavAreas/NavArea.h")]
public partial class UNavArea : UNavAreaBase {
	public static UClass StaticClass() {return default;}
	///<summary>travel cost multiplier for path distance</summary>
	public float DefaultCost;
	///<summary>entering cost</summary>
	public float FixedAreaEnteringCost;
	///<summary>area color in navigation view</summary>
	public FColor DrawColor;
	///<summary>restrict area only to specified agents</summary>
	public FNavAgentSelector SupportedAgents;
	///<summary>DEPRECATED AGENT CONFIG</summary>
	public bool bSupportsAgent0;
	///<summary>bSupportsAgent1</summary>
	public bool bSupportsAgent1;
	///<summary>bSupportsAgent2</summary>
	public bool bSupportsAgent2;
	///<summary>bSupportsAgent3</summary>
	public bool bSupportsAgent3;
	///<summary>bSupportsAgent4</summary>
	public bool bSupportsAgent4;
	///<summary>bSupportsAgent5</summary>
	public bool bSupportsAgent5;
	///<summary>bSupportsAgent6</summary>
	public bool bSupportsAgent6;
	///<summary>bSupportsAgent7</summary>
	public bool bSupportsAgent7;
	///<summary>bSupportsAgent8</summary>
	public bool bSupportsAgent8;
	///<summary>bSupportsAgent9</summary>
	public bool bSupportsAgent9;
	///<summary>bSupportsAgent10</summary>
	public bool bSupportsAgent10;
	///<summary>bSupportsAgent11</summary>
	public bool bSupportsAgent11;
	///<summary>bSupportsAgent12</summary>
	public bool bSupportsAgent12;
	///<summary>bSupportsAgent13</summary>
	public bool bSupportsAgent13;
	///<summary>bSupportsAgent14</summary>
	public bool bSupportsAgent14;
	///<summary>bSupportsAgent15</summary>
	public bool bSupportsAgent15;
}
