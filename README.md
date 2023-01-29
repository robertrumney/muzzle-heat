# MuzzleHeat

A Unity C# script for adding heat effect to the muzzle of a firearm in a Unity game.

## Usage

- Attach the `MuzzleHeat` script to the game object that represents the muzzle of your firearm.
- Assign the muzzle material to the `muzzleMaterial` public variable in the inspector.
- Assign the fire key code to the `fire` public variable in the inspector.
- Enable/disable the semi-automatic firing mode by setting the `semiAuto` public variable.

## Integration Suggestions

Here are a few suggestions to get the most out of the `MuzzleHeat` script:

- You can modify the `Fire()` function to add your own custom code for firing.
- You can modify the `CoolMuzzle()` coroutine to change the cooling rate of the muzzle heat effect.
- If you don't want to use the muzzle heat effect, you can set the `usesMuzzleHeat` private variable to `false`.
- You can add a particle system to the muzzle game object to enhance the heat effect.

## License
A simple 5 minute script example by Robert Rumney, feel free to use as you please without credit!
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
