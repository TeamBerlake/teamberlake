using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour
{

	#region Variables

	[SerializeField]
	private				GameObjectColor			m_color				= GameObjectColor.GREY;

	#endregion // Variables

	#region MonoBehaviour Overrides

	/// <summary>
	/// Awake this instance.
	/// </summary>
	private void Awake ()
	{

	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	private void Start ()
	{
	
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	private void Update ()
	{
	
	}

	private void OnTriggerEnter (Collider col)
	{
		Debug.Log("yea");
		Shape so = col.GetComponent<Shape>();

		// Check if the shape object component of the object that hits this exists
		if (so == null)
		{
			Debug.Log("NO!");
			return;
		}
		Debug.Log(so.CurrentColor + " = " + m_color);

		// Check if the object that hit this collectible has the same color
		if (so.CurrentColor == m_color)
		{
			Debug.Log("YEA!");
			// Collect
			_Collect();
		}
	}

	#endregion // MonoBehaviour Overrides

	#region Private Functions

	/// <summary>
	/// The behaviours that a collectible will follow when it gets collected by a object successfully.
	/// </summary>
	private void _Collect ()
	{
		Debug.Log("Collected successfully!");
		GameObject.Destroy(gameObject);
	}

	#endregion Private Functions

	#region Properties

	public	GameObjectColor CurrentColor
	{
		get { return m_color; }
	}

	#endregion //Properties
}
