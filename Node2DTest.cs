using Godot;
using System;

public partial class Node2DTest : Node2D
{
	//Couldn't find any of these custom signals in the editor. Also, I don't know how to use them yet.

	[Signal]
	public delegate void HealthDepletedEventHandler();

	private int _health = 10;

	public void TakeDamage(int damage)
	{
		_health -= damage;

		if (_health <= 0)
		{
			EmitSignal(SignalName.HealthDepleted);
		}
	}
}
