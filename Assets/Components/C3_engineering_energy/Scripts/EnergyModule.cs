
public class EnergyModule
{
	//public for testing
	public string name;
	public int energyDemand, coolantLevel;
	public float energyLevel, heatLevel;
	//--

	public EnergyModule (string name,
		int energyDemand)
	{
		this.name = name;
		this.energyDemand = energyDemand;
		coolantLevel = 0;
		energyLevel = 1.0f;
		heatLevel = 0.0f;
	}

	public string Name
	{
		get {
			return name;
		}
	}

	public int EnergyDemand
	{
		get {
			return energyDemand;
		}
	}

	public int CoolantLevel
	{
		get {
			return coolantLevel;
		}
		set {
			coolantLevel = value;
		}
	}

	public float EnergyLevel
	{
		get {
			return energyLevel;
		}
		set {
			energyLevel = value;
		}
	}

	public float HeatLevel
	{
		get {
			return heatLevel;
		}
		set {
			heatLevel = value;
		}
	}
}
