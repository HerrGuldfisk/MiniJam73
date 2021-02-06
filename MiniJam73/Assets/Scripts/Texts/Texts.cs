using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Texts : ScriptableObject
{
	public static List<textAndPoints> texts = new List<textAndPoints>
	{
		new textAndPoints("The Gods are angry and crave lives to be sacrificed,\n" +
			"but the voters are stingy and refuse to take one for the team!\n" +
			"'Sacrifice the Cats! They have 8 lives to spare anyway'", 5),

		new textAndPoints("A local mobster boss demands your respect.\n" +
			"He wants you to give a public speech praising his endevors in the community.\n" +
			"'Give the speech!'", -5),

		new textAndPoints("A scientist says that murder bees are beneficial,\n" +
			"they could raise the wool production by 5%!\n" +
			"'RELEASE THE BEES!'", -3),

		new textAndPoints("The dry season has brought gigantic fires to the country,\n" +
			"people want the funding of community services to be raised.\n" +
			"'Raise taxes!'", 7),

		new textAndPoints("Plastic waste companies want less regulation,\n" +
			"they lose money on filtering out toxic particles.\n" +
			"'Deregulate the plastic waste industry'", -10),

		new textAndPoints("Police brutality is on the rise,\n" +
			"people want a reform and demand change.\n" +
			"'Validate the problem and promise change'", 5),

		new textAndPoints("A dead hooker was found in your summer house,\n" +
			"reporters are asking for a comment.\n" +
			"'Throw a tantrum and call out the media for faking their stories'", -15),

		new textAndPoints("Big Pharma is making big bucks on insulin,\n" +
			"you are offered a slice of the pie.\n" +
			"'Justify high insulin prices by citing a bible verse'", -4),

		new textAndPoints("A neighbouring country is systematically abusing a minority,\n" +
			"people want you to stop trading with them.\n" +
			"'Start a trade war and lose billions'", 5),

		new textAndPoints("Gray aliens are contacting all the leaders of the world,\n" +
			"the public is unaware.\n" +
			"'Spend trillions to keep it a secret'", 2),

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
