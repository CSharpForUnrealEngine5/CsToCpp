#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbilitySystemTestAttributeSet.h")]
public partial class UAbilitySystemTestAttributeSet : UAttributeSet {
	public static UClass StaticClass() {return default;}
	///<summary>NOTE ON MUTABLE:</summary>
	public float MaxHealth;
	///<summary>You can&#39;t make a GameplayEffect modify Health Directly (go through)</summary>
	public float Health;
	///<summary>Mana</summary>
	public float Mana;
	///<summary>MaxMana</summary>
	public float MaxMana;
	///<summary>This Damage is just used for applying negative health mods. Its not a &#39;persistent&#39; attribute. // You can&#39;t make a GameplayEffect &#39;powered&#39; by Damage (Its transient)</summary>
	public float Damage;
	///<summary>This Attribute is the actual spell damage for this actor. It will power spell based GameplayEffects</summary>
	public float SpellDamage;
	///<summary>This Attribute is the actual physical damage for this actor. It will power physical based GameplayEffects</summary>
	public float PhysicalDamage;
	///<summary>CritChance</summary>
	public float CritChance;
	///<summary>CritMultiplier</summary>
	public float CritMultiplier;
	///<summary>ArmorDamageReduction</summary>
	public float ArmorDamageReduction;
	///<summary>DodgeChance</summary>
	public float DodgeChance;
	///<summary>LifeSteal</summary>
	public float LifeSteal;
	///<summary>Strength</summary>
	public float Strength;
	///<summary>StackingAttribute1</summary>
	public float StackingAttribute1;
	///<summary>StackingAttribute2</summary>
	public float StackingAttribute2;
	///<summary>NoStackAttribute</summary>
	public float NoStackAttribute;
}
