using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Texts : ScriptableObject
{
	public static List<textAndPoints> texts = new List<textAndPoints>
	{
		new textAndPoints("The Gods are angry and crave lives to be sacrificed,\n" +
			"but the voters are stingy and refuses to take one for the team!\n" +
			"'Sacrifice the Cats! They have 8 lives to spare anyway'", 3),

	};

}

public struct textAndPoints
{
	public string text;
	public int point;

	public textAndPoints(string _text, int _points)
	{
		this.text = _text;
		this.point = _points;
	}
}
