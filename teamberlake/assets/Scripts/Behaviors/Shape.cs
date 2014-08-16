using UnityEngine;
using System.Collections;

public class Shape : MonoBehaviour
{

	#region Universal Variables

	[SerializeField]
	protected	GameObjectColor	m_color			= GameObjectColor.GREY;
	protected	bool			m_canBeMoved	= false;

	#endregion // Universal Variables

	#region Monobehavior Functions

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	#endregion // Monobehavior Functions

	#region Private Functions

	private GameObjectColor _CombineColors (GameObjectColor color1, GameObjectColor color2)
	{
		GameObjectColor product = color1;
		if (color1 == GameObjectColor.RED)
		{
			switch (color2)
			{
			case GameObjectColor.BLUE:
				product = GameObjectColor.PURPLE;
				break;
			case GameObjectColor.YELLOW:
				product = GameObjectColor.ORANGE;
				break;
			default:
				break;
			}
		}
		else if (color1 == GameObjectColor.YELLOW)
		{
			switch (color2)
			{
			case GameObjectColor.BLUE:
				product = GameObjectColor.GREEN;
				break;
			case GameObjectColor.RED:
				product = GameObjectColor.ORANGE;
				break;
			default:
				break;
			}
		}
		else if (color1 == GameObjectColor.BLUE)
		{
			switch (color2)
			{
			case GameObjectColor.YELLOW:
				product = GameObjectColor.GREEN;
				break;
			case GameObjectColor.RED:
				product = GameObjectColor.PURPLE;
				break;
			default:
				break;
			}
		}

		return product;
	}

	#endregion // Private Functions

	#region Public Functions

	public bool CanBeMoved
	{
		get {return m_canBeMoved;}
		set {m_canBeMoved = value;}
	}

	public GameObjectColor CurrentColor
	{
		get {return m_color;}
		set {m_color = value;}
	}

	public void MixColor (GameObjectColor s)
	{
		m_color = _CombineColors(m_color, s);
	}

	public void Initialize (Vector3 initialPosition, GameObjectColor color, bool canBeMoved)
	{
		m_canBeMoved = canBeMoved;

		if (m_canBeMoved)
		{
			m_color = color;
		}
		else
		{
			m_color = GameObjectColor.GREY;
		}

		if (this.gameObject != null)
		{
			gameObject.transform.position = initialPosition;
		}
	}

	#endregion // Public Functions
}
